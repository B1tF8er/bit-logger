namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Moq;
    using System;
    using Xunit;
    using static Constants;

    public class CustomLoggerShould
    {
        private readonly Mock<ILoggerFactory> mockLoggerFactory;
        private readonly ILoggerFactory loggerFactory;

        public CustomLoggerShould()
        {
            mockLoggerFactory = new Mock<ILoggerFactory>(MockBehavior.Strict);

            loggerFactory = mockLoggerFactory.Object;

            mockLoggerFactory
                .SetupCallsWithSource<CustomLoggerShould>(TestMessage, TestException)
                .SetupCallsWithoutSource(TestMessage, TestException)
                .Setup(loggerFactory => loggerFactory.AddSource(It.IsAny<ILogger>()))
                .Returns(loggerFactory);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload()
        {
            loggerFactory.Trace<CustomLoggerShould>(TestMessage);
            loggerFactory.Trace<CustomLoggerShould>(TestException);
            loggerFactory.Trace<CustomLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggerShould>(TestMessage, TestException), Times.Once);

            mockLoggerFactory.ResetCalls();

            loggerFactory.Trace(TestMessage);
            loggerFactory.Trace(TestException);
            loggerFactory.Trace(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Trace(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsDebug_OncePerMethodOverload()
        {
            loggerFactory.Debug<CustomLoggerShould>(TestMessage);
            loggerFactory.Debug<CustomLoggerShould>(TestException);
            loggerFactory.Debug<CustomLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggerShould>(TestMessage, TestException), Times.Once);

            mockLoggerFactory.ResetCalls();

            loggerFactory.Debug(TestMessage);
            loggerFactory.Debug(TestException);
            loggerFactory.Debug(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Debug(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsVerbose_OncePerMethodOverload()
        {
            loggerFactory.Verbose<CustomLoggerShould>(TestMessage);
            loggerFactory.Verbose<CustomLoggerShould>(TestException);
            loggerFactory.Verbose<CustomLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggerShould>(TestMessage, TestException), Times.Once);

            mockLoggerFactory.ResetCalls();
            
            loggerFactory.Verbose(TestMessage);
            loggerFactory.Verbose(TestException);
            loggerFactory.Verbose(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Verbose(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsInformation_OncePerMethodOverload()
        {
            loggerFactory.Information<CustomLoggerShould>(TestMessage);
            loggerFactory.Information<CustomLoggerShould>(TestException);
            loggerFactory.Information<CustomLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggerShould>(TestMessage, TestException), Times.Once);

            mockLoggerFactory.ResetCalls();

            loggerFactory.Information(TestMessage);
            loggerFactory.Information(TestException);
            loggerFactory.Information(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Information(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsWarning_OncePerMethodOverload()
        {
            loggerFactory.Warning<CustomLoggerShould>(TestMessage);
            loggerFactory.Warning<CustomLoggerShould>(TestException);
            loggerFactory.Warning<CustomLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggerShould>(TestMessage, TestException), Times.Once);

            mockLoggerFactory.ResetCalls();

            loggerFactory.Warning(TestMessage);
            loggerFactory.Warning(TestException);
            loggerFactory.Warning(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Warning(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsError_OncePerMethodOverload()
        {
            loggerFactory.Error<CustomLoggerShould>(TestMessage);
            loggerFactory.Error<CustomLoggerShould>(TestException);
            loggerFactory.Error<CustomLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggerShould>(TestMessage, TestException), Times.Once);

            mockLoggerFactory.ResetCalls();
            
            loggerFactory.Error(TestMessage);
            loggerFactory.Error(TestException);
            loggerFactory.Error(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Error(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsCritical_OncePerMethodOverload()
        {
            loggerFactory.Critical<CustomLoggerShould>(TestMessage);
            loggerFactory.Critical<CustomLoggerShould>(TestException);
            loggerFactory.Critical<CustomLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggerShould>(TestMessage, TestException), Times.Once);

            mockLoggerFactory.ResetCalls();

            loggerFactory.Critical(TestMessage);
            loggerFactory.Critical(TestException);
            loggerFactory.Critical(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Critical(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical(TestMessage, TestException), Times.Once);
        }
    }
}