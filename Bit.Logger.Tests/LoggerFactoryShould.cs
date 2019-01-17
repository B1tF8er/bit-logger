namespace Bit.Logger.Tests
{
    using Config;
    using Contract;
    using Enums;
    using Factory;
    using Moq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;
    using static Enums.Level;
    using static Enums.ShowLevel;
    using static LoggerFactoryExtensions;

    public class LoggerFactoryShould
    {
        private readonly Mock<LoggerFactory> sut;

        public LoggerFactoryShould()
        {
            sut = new Mock<LoggerFactory>(MockBehavior.Default);
        }

        [Fact]
        public void AddConsoleSource_AndReturnConsoleLogger()
        {
            sut.Object.AddConsoleSource(It.IsAny<Configuration>());

            var actual = sut.Object.Loggers.Single();

            Assert.NotNull(actual);
            Assert.True(actual is IConsoleLogger);
        }

        [Fact]
        public void AddDatabaseSource_AndReturnDatabaseLogger()
        {
            sut.Object.AddDatabaseSource(It.IsAny<Configuration>());

            var actual = sut.Object.Loggers.Single();

            Assert.NotNull(actual);
            Assert.True(actual is IDatabaseLogger);
        }

        [Fact]
        public void AddFileSource_AndReturnFileLogger()
        {
            sut.Object.AddFileSource(It.IsAny<Configuration>());

            var actual = sut.Object.Loggers.Single();

            Assert.NotNull(actual);
            Assert.True(actual is IFileLogger);
        }

        [Fact]
        public void AddSource_AndReturnILogger()
        {
            var customLogger = new Mock<ILogger>().Object;

            sut.Object.AddSource(customLogger);

            var actual = sut.Object.Loggers.Single();

            Assert.NotNull(actual);
            Assert.True(actual is ILogger);
        }

        [Fact]
        public void AddSources_AndReturnILogger()
        {
            var customLogger = new Mock<ILogger>().Object;
            var customLoggers = new List<ILogger>
            {
                customLogger, customLogger, customLogger
            };

            sut.Object.AddSources(customLoggers);

            var actual = sut.Object.Loggers.First();

            Assert.NotNull(actual);
            Assert.True(actual is ILogger);
        }

        [Fact]
        public void Throw_ArgumentNullException_WhenAddSourceHasNullValue()
        {
            var expectedMessage = $"Value cannot be null.{Environment.NewLine}Parameter name: logger";

            var actualException = Assert.Throws<ArgumentNullException>(() => sut.Object.AddSource(null));

            Assert.Equal(expectedMessage, actualException.Message);
        }

        [Fact]
        public void Throw_ArgumentNullException_WhenAddSourcesHasANullValue()
        {
            var customLogger = new Mock<ILogger>().Object;
            var customLoggers = new List<ILogger>
            {
                customLogger, null, customLogger
            };

            var expectedMessage = $"Value cannot be null.{Environment.NewLine}Parameter name: loggers";

            var actualException = Assert.Throws<ArgumentNullException>(() => sut.Object.AddSources(customLoggers));

            Assert.Equal(expectedMessage, actualException.Message);
        }

        [Fact]
        public void Return_LoggersAdded_WhenToStringIsCalled()
        {
            var expected = $"Console{Environment.NewLine}Database{Environment.NewLine}File{Environment.NewLine}";
            
            sut.Setup(c => c.ToString()).Returns(expected);

            var actual = sut.Object.ToString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LogFiveHundredMessages_WithoutSourceClass_AndLevel()
        {
            SetBaseLoggers(level: Trace, showLevel: Yes);

            foreach (var index in Enumerable.Range(0, 30))
                sut.LogAllLevelsWithoutClass();
        }

        [Fact]
        public void LogFiveHundredMessages_WithSourceClass_AndNoLevel()
        {
            SetBaseLoggers(level: Trace, showLevel: No);

            foreach (var index in Enumerable.Range(0, 30))
                sut.LogAllLevelsWithClass<LoggerFactoryShould>();
        }

        private void SetBaseLoggers(Level level, ShowLevel showLevel)
        {
            var configuration = new Configuration
            {
                Level = level,
                ShowLevel = showLevel
            };

            sut.Object.AddConsoleSource(configuration);
            sut.Object.AddDatabaseSource(configuration);
            sut.Object.AddFileSource(configuration);
        }
    }
}