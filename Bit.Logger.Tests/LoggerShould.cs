namespace Bit.Logger.Tests
{
    using Config;
    using LogBuffer;
    using Models;
    using Moq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class LoggerShould
    {
        private readonly Mock<Logger> sut;

        public LoggerShould()
        {
            sut = new Mock<Logger>(MockBehavior.Strict);
        }

        [Fact]
        public void AddConsoleSource_AndReturnConsoleLogger()
        {
            sut.Object.AddConsoleSource(It.IsAny<Configuration>());

            var actual = sut.Object.Loggers.Single();

            Assert.NotNull(actual);
            Assert.True(actual is ILogger);
            Assert.True(actual is IConfiguration);
            Assert.True(actual is ILogBuffer<string>);
        }

        [Fact]
        public void AddConsoleSource_AndReturnDatabaseLogger()
        {
            sut.Object.AddDatabaseSource(It.IsAny<Configuration>());

            var actual = sut.Object.Loggers.Single();

            Assert.NotNull(actual);
            Assert.True(actual is ILogger);
            Assert.True(actual is IConfiguration);
            Assert.True(actual is ILogBuffer<Log>);
        }

        [Fact]
        public void AddConsoleSource_AndReturnFileLogger()
        {
            sut.Object.AddFileSource(It.IsAny<Configuration>());

            var actual = sut.Object.Loggers.Single();

            Assert.NotNull(actual);
            Assert.True(actual is ILogger);
            Assert.True(actual is IConfiguration);
            Assert.True(actual is ILogBuffer<string>);
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

            sut.Object.AddConsoleSource(It.IsAny<Configuration>());
            sut.Object.AddDatabaseSource(It.IsAny<Configuration>());
            sut.Object.AddFileSource(It.IsAny<Configuration>());
            sut.Setup(c => c.ToString()).Returns(expected);

            var actual = sut.Object.ToString();

            Assert.Equal(expected, actual);
        }
    }
}