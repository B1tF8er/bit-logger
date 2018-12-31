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
        public void LogMessage_AsTrace_WithSourceClass()
        {
            SetBaseLoggers();

            sut.Object.Trace<LoggerFactoryShould>(TestMessage);
            sut.Object.Trace<LoggerFactoryShould>(TestException);
            sut.Object.Trace<LoggerFactoryShould>(TestMessage, TestException);
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

            sut.Object.Debug<LoggerFactoryShould>(TestMessage);
            sut.Object.Debug<LoggerFactoryShould>(TestException);
            sut.Object.Debug<LoggerFactoryShould>(TestMessage, TestException);
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

            sut.Object.Verbose<LoggerFactoryShould>(TestMessage);
            sut.Object.Verbose<LoggerFactoryShould>(TestException);
            sut.Object.Verbose<LoggerFactoryShould>(TestMessage, TestException);
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

            sut.Object.Information<LoggerFactoryShould>(TestMessage);
            sut.Object.Information<LoggerFactoryShould>(TestException);
            sut.Object.Information<LoggerFactoryShould>(TestMessage, TestException);
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

            sut.Object.Warning<LoggerFactoryShould>(TestMessage);
            sut.Object.Warning<LoggerFactoryShould>(TestException);
            sut.Object.Warning<LoggerFactoryShould>(TestMessage, TestException);
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

            sut.Object.Error<LoggerFactoryShould>(TestMessage);
            sut.Object.Error<LoggerFactoryShould>(TestException);
            sut.Object.Error<LoggerFactoryShould>(TestMessage, TestException);
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

            sut.Object.Critical<LoggerFactoryShould>(TestMessage);
            sut.Object.Critical<LoggerFactoryShould>(TestException);
            sut.Object.Critical<LoggerFactoryShould>(TestMessage, TestException);
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
        public void LogFiveHundredMessages_WithSourceClass()
        {
            SetBaseLoggers();

            foreach (var r in Enumerable.Range(0, 501))
            {
                sut.Object.Trace<LoggerFactoryShould>(TestMessage);
                sut.Object.Debug<LoggerFactoryShould>(TestException);
                sut.Object.Verbose<LoggerFactoryShould>(TestMessage, TestException);
                sut.Object.Information<LoggerFactoryShould>(TestMessage);
            }
        }

        [Fact]
        public void LogFiveHundredMessages_WithoutSourceClass()
        {
            SetBaseLoggers();

            foreach (var r in Enumerable.Range(0, 501))
            {
                sut.Object.Warning(TestException);
                sut.Object.Error(TestMessage, TestException);
                sut.Object.Critical(TestMessage, TestException);
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
    }
}