namespace Bit.Logger.Tests
{
    using Config;
    using Contract;
    using Factory;
    using Moq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;
    using static Constants;
    using static Enums.Level;

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
        public void LogFiveHundredMessages_WithSourceClass()
        {
            SetBaseLoggers();

            foreach (var r in Enumerable.Range(0, 72))
            {
                LogAllLevelsWithoutClass();
                LogAllLevelsWithClass();
            }
        }

        private void SetBaseLoggers()
        {
            var configuration = new Configuration
            {
                Level = Trace
            };

            sut.Object.AddConsoleSource(configuration);
            sut.Object.AddDatabaseSource(configuration);
            sut.Object.AddFileSource(configuration);
        }

        private void LogAllLevelsWithoutClass()
        {
            sut.Object.Trace(TestMessage);
            sut.Object.Debug(TestException);
            sut.Object.Verbose(TestMessage, TestException);
            sut.Object.Information(TestMessage);
            sut.Object.Warning(TestException);
            sut.Object.Error(TestMessage, TestException);
            sut.Object.Critical(TestMessage, TestException);
        }

        private void LogAllLevelsWithClass()
        {
            sut.Object.Trace<LoggerFactoryShould>(TestMessage);
            sut.Object.Debug<LoggerFactoryShould>(TestException);
            sut.Object.Verbose<LoggerFactoryShould>(TestMessage, TestException);
            sut.Object.Information<LoggerFactoryShould>(TestMessage);
            sut.Object.Warning<LoggerFactoryShould>(TestException);
            sut.Object.Error<LoggerFactoryShould>(TestMessage, TestException);
            sut.Object.Critical<LoggerFactoryShould>(TestMessage, TestException);
        }
    }
}