namespace Bit.Logger.Tests
{
    using Config;
    using Moq;
    using System;
    using Xunit;
    using static Constants;

    public class ConsoleLoggerShould
    {
        private readonly Mock<ILoggerFactory> mockLoggerFactory;

        public ConsoleLoggerShould()
        {
            mockLoggerFactory = new Mock<ILoggerFactory>(MockBehavior.Strict);

            mockLoggerFactory
                .SetupCallsWithSource<ConsoleLoggerShould>(TestMessage, TestException)
                .SetupCallsWithoutSource(TestMessage, TestException)
                .Setup(loggerFactory => loggerFactory.AddConsoleSource(It.IsAny<Configuration>()))
                .Returns(mockLoggerFactory.Object);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Trace<ConsoleLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Trace<ConsoleLoggerShould>(TestException);
            mockLoggerFactory.Object.Trace<ConsoleLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Trace<ConsoleLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<ConsoleLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload_WithoutSourceClass()
        {
            mockLoggerFactory.Object.Trace(TestMessage);
            mockLoggerFactory.Object.Trace(TestException);
            mockLoggerFactory.Object.Trace(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Trace(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsDebug_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Debug<ConsoleLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Debug<ConsoleLoggerShould>(TestException);
            mockLoggerFactory.Object.Debug<ConsoleLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Debug<ConsoleLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<ConsoleLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsDebug_OncePerMethodOverload_WithoutSourceClass()
        {
            mockLoggerFactory.Object.Debug(TestMessage);
            mockLoggerFactory.Object.Debug(TestException);
            mockLoggerFactory.Object.Debug(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Debug(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsVerbose_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Verbose<ConsoleLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Verbose<ConsoleLoggerShould>(TestException);
            mockLoggerFactory.Object.Verbose<ConsoleLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Verbose<ConsoleLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<ConsoleLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsVerbose_OncePerMethodOverload_WithoutSourceClass()
        {
            mockLoggerFactory.Object.Verbose(TestMessage);
            mockLoggerFactory.Object.Verbose(TestException);
            mockLoggerFactory.Object.Verbose(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Verbose(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsInformation_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Information<ConsoleLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Information<ConsoleLoggerShould>(TestException);
            mockLoggerFactory.Object.Information<ConsoleLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Information<ConsoleLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<ConsoleLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsInformation_OncePerMethodOverload_WithoutSourceClass()
        {
            mockLoggerFactory.Object.Information(TestMessage);
            mockLoggerFactory.Object.Information(TestException);
            mockLoggerFactory.Object.Information(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Information(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsWarning_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Warning<ConsoleLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Warning<ConsoleLoggerShould>(TestException);
            mockLoggerFactory.Object.Warning<ConsoleLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Warning<ConsoleLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<ConsoleLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsWarning_OncePerMethodOverload_WithoutSourceClass()
        {
            mockLoggerFactory.Object.Warning(TestMessage);
            mockLoggerFactory.Object.Warning(TestException);
            mockLoggerFactory.Object.Warning(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Warning(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsError_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Error<ConsoleLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Error<ConsoleLoggerShould>(TestException);
            mockLoggerFactory.Object.Error<ConsoleLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Error<ConsoleLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<ConsoleLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsError_OncePerMethodOverload_WithoutSourceClass()
        {
            mockLoggerFactory.Object.Error(TestMessage);
            mockLoggerFactory.Object.Error(TestException);
            mockLoggerFactory.Object.Error(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Error(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsCritical_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Critical<ConsoleLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Critical<ConsoleLoggerShould>(TestException);
            mockLoggerFactory.Object.Critical<ConsoleLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Critical<ConsoleLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<ConsoleLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsCritical_OncePerMethodOverload_WithoutSourceClass()
        {
            mockLoggerFactory.Object.Critical(TestMessage);
            mockLoggerFactory.Object.Critical(TestException);
            mockLoggerFactory.Object.Critical(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Critical(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical(TestMessage, TestException), Times.Once);
        }
    }
}
