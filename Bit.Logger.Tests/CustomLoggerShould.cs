namespace Bit.Logger.Tests
{
    using Config;
    using Moq;
    using System;
    using Xunit;
    using static Constants;

    public class CustomLoggerShould
    {
        private readonly Mock<ILoggerFactory> mockLoggerFactory;

        public CustomLoggerShould()
        {
            mockLoggerFactory = new Mock<ILoggerFactory>(MockBehavior.Strict);

            mockLoggerFactory
                .SetupCallsWithSource<CustomLoggerShould>(TestMessage, TestException)
                .SetupCallsWithoutSource(TestMessage, TestException)
                .Setup(loggerFactory =>  loggerFactory.AddSource(It.IsAny<ILogger>()))
                .Returns(mockLoggerFactory.Object);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Trace<CustomLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Trace<CustomLoggerShould>(TestException);
            mockLoggerFactory.Object.Trace<CustomLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Debug<CustomLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Debug<CustomLoggerShould>(TestException);
            mockLoggerFactory.Object.Debug<CustomLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Verbose<CustomLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Verbose<CustomLoggerShould>(TestException);
            mockLoggerFactory.Object.Verbose<CustomLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Information<CustomLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Information<CustomLoggerShould>(TestException);
            mockLoggerFactory.Object.Information<CustomLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Warning<CustomLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Warning<CustomLoggerShould>(TestException);
            mockLoggerFactory.Object.Warning<CustomLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Error<CustomLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Error<CustomLoggerShould>(TestException);
            mockLoggerFactory.Object.Error<CustomLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Critical<CustomLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Critical<CustomLoggerShould>(TestException);
            mockLoggerFactory.Object.Critical<CustomLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggerShould>(TestMessage, TestException), Times.Once);
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