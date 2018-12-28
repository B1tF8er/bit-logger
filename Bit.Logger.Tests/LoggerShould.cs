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
    using static Constants;

    public class LoggerShould
    {
        private readonly Mock<Logger> sut;

        public LoggerShould()
        {
            sut = new Mock<Logger>(MockBehavior.Default);
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
            
            sut.Setup(c => c.ToString()).Returns(expected);

            var actual = sut.Object.ToString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LogMessage_AsTrace_WithSourceClass()
        {
            SetBaseLoggers();

            sut.Object.Trace<LoggerShould>(TestMessage);
            sut.Object.Trace<LoggerShould>(TestException);
            sut.Object.Trace<LoggerShould>(TestMessage, TestException);
        }

        [Fact]
        public void LogMessage_AsTrace_WithoutSourceClass()
        {
            SetBaseLoggers();

            sut.Object.Trace(TestMessage);
            sut.Object.Trace(TestException);
            sut.Object.Trace(TestMessage, TestException);
        }

        [Fact]
        public void LogMessage_AsDebug_WithSourceClass()
        {
            SetBaseLoggers();

            sut.Object.Debug<LoggerShould>(TestMessage);
            sut.Object.Debug<LoggerShould>(TestException);
            sut.Object.Debug<LoggerShould>(TestMessage, TestException);
        }

        [Fact]
        public void LogMessage_AsDebug_WithoutSourceClass()
        {
            SetBaseLoggers();

            sut.Object.Debug(TestMessage);
            sut.Object.Debug(TestException);
            sut.Object.Debug(TestMessage, TestException);
        }

        [Fact]
        public void LogMessage_AsVerbose_WithSourceClass()
        {
            SetBaseLoggers();

            sut.Object.Verbose<LoggerShould>(TestMessage);
            sut.Object.Verbose<LoggerShould>(TestException);
            sut.Object.Verbose<LoggerShould>(TestMessage, TestException);
        }

        [Fact]
        public void LogMessage_AsVerbose_WithoutSourceClass()
        {
            SetBaseLoggers();

            sut.Object.Verbose(TestMessage);
            sut.Object.Verbose(TestException);
            sut.Object.Verbose(TestMessage, TestException);
        }

        [Fact]
        public void LogMessage_AsInformation_WithSourceClass()
        {
            SetBaseLoggers();

            sut.Object.Information<LoggerShould>(TestMessage);
            sut.Object.Information<LoggerShould>(TestException);
            sut.Object.Information<LoggerShould>(TestMessage, TestException);
        }

        [Fact]
        public void LogMessage_AsInformation_WithoutSourceClass()
        {
            SetBaseLoggers();

            sut.Object.Information(TestMessage);
            sut.Object.Information(TestException);
            sut.Object.Information(TestMessage, TestException);
        }

        [Fact]
        public void LogMessage_AsWarning_WithSourceClass()
        {
            SetBaseLoggers();

            sut.Object.Warning<LoggerShould>(TestMessage);
            sut.Object.Warning<LoggerShould>(TestException);
            sut.Object.Warning<LoggerShould>(TestMessage, TestException);
        }

        [Fact]
        public void LogMessage_AsWarning_WithoutSourceClass()
        {
            SetBaseLoggers();

            sut.Object.Warning(TestMessage);
            sut.Object.Warning(TestException);
            sut.Object.Warning(TestMessage, TestException);
        }

        [Fact]
        public void LogMessage_AsError_WithSourceClass()
        {
            SetBaseLoggers();

            sut.Object.Error<LoggerShould>(TestMessage);
            sut.Object.Error<LoggerShould>(TestException);
            sut.Object.Error<LoggerShould>(TestMessage, TestException);
        }

        [Fact]
        public void LogMessage_AsError_WithoutSourceClass()
        {
            SetBaseLoggers();

            sut.Object.Error(TestMessage);
            sut.Object.Error(TestException);
            sut.Object.Error(TestMessage, TestException);
        }

        [Fact]
        public void LogMessage_AsCritical_WithSourceClass()
        {
            SetBaseLoggers();

            sut.Object.Critical<LoggerShould>(TestMessage);
            sut.Object.Critical<LoggerShould>(TestException);
            sut.Object.Critical<LoggerShould>(TestMessage, TestException);
        }

        [Fact]
        public void LogMessage_AsCritical_WithoutSourceClass()
        {
            SetBaseLoggers();

            sut.Object.Critical(TestMessage);
            sut.Object.Critical(TestException);
            sut.Object.Critical(TestMessage, TestException);
        }

        [Fact]
        public void LogFiveHundredMessages_AsInformation_WithSourceClass()
        {
            SetBaseLoggers();

            foreach (var r in Enumerable.Range(0, 501))
            {
                sut.Object.Information<LoggerShould>(TestMessage);
                sut.Object.Information<LoggerShould>(TestException);
                sut.Object.Information<LoggerShould>(TestMessage, TestException);
            }
        }

        [Fact]
        public void LogFiveHundredMessages_AsInformation_WithoutSourceClass()
        {
            SetBaseLoggers();

            foreach (var r in Enumerable.Range(0, 501))
            {
                sut.Object.Information(TestMessage);
                sut.Object.Information(TestException);
                sut.Object.Information(TestMessage, TestException);
            }
        }

        private void SetBaseLoggers()
        {
            sut.Object.AddConsoleSource(It.IsAny<Configuration>());
            sut.Object.AddDatabaseSource(It.IsAny<Configuration>());
            sut.Object.AddFileSource(It.IsAny<Configuration>());
        }
    }
}