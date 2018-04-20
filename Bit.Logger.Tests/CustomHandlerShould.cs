namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Bit.Logger.Handlers;
    using Moq;
    using System;
    using Xunit;

    public class CustomHandlerShould
    {
        private readonly Mock<ILogger> mockLogger;
        private readonly ILogger logger;
        private readonly Exception exception;
        private const string message = "Test message";

        public CustomHandlerShould()
        {
            mockLogger = new Mock<ILogger>(MockBehavior.Strict);

            logger = mockLogger.Object;

            exception = new Exception("Test exception");

            mockLogger
                .SetupCallsWithSource<CustomHandlerShould>(message, exception)
                .SetupCallsWithoutSource(message, exception)
                .Setup(logger => logger.AddHandler(It.IsAny<IHandler>()))
                .Returns(logger);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload()
        {
            logger.Trace<CustomHandlerShould>(message);
            logger.Trace<CustomHandlerShould>(exception);
            logger.Trace<CustomHandlerShould>(message, exception);

            mockLogger.Verify(logger => logger.Trace<CustomHandlerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Trace<CustomHandlerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Trace<CustomHandlerShould>(message, exception), Times.Once);

            mockLogger.ResetCalls();

            logger.Trace(message);
            logger.Trace(exception);
            logger.Trace(message, exception);

            mockLogger.Verify(logger => logger.Trace(message), Times.Once);
            mockLogger.Verify(logger => logger.Trace(exception), Times.Once);
            mockLogger.Verify(logger => logger.Trace(message, exception), Times.Once);
        }

        [Fact]
        public void LogMessage_AsDebug_OncePerMethodOverload()
        {
            logger.Debug<CustomHandlerShould>(message);
            logger.Debug<CustomHandlerShould>(exception);
            logger.Debug<CustomHandlerShould>(message, exception);

            mockLogger.Verify(logger => logger.Debug<CustomHandlerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Debug<CustomHandlerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Debug<CustomHandlerShould>(message, exception), Times.Once);

            mockLogger.ResetCalls();

            logger.Debug(message);
            logger.Debug(exception);
            logger.Debug(message, exception);

            mockLogger.Verify(logger => logger.Debug(message), Times.Once);
            mockLogger.Verify(logger => logger.Debug(exception), Times.Once);
            mockLogger.Verify(logger => logger.Debug(message, exception), Times.Once);
        }

        [Fact]
        public void LogMessage_AsVerbose_OncePerMethodOverload()
        {
            logger.Verbose<CustomHandlerShould>(message);
            logger.Verbose<CustomHandlerShould>(exception);
            logger.Verbose<CustomHandlerShould>(message, exception);

            mockLogger.Verify(logger => logger.Verbose<CustomHandlerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Verbose<CustomHandlerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Verbose<CustomHandlerShould>(message, exception), Times.Once);

            mockLogger.ResetCalls();
            
            logger.Verbose(message);
            logger.Verbose(exception);
            logger.Verbose(message, exception);

            mockLogger.Verify(logger => logger.Verbose(message), Times.Once);
            mockLogger.Verify(logger => logger.Verbose(exception), Times.Once);
            mockLogger.Verify(logger => logger.Verbose(message, exception), Times.Once);
        }

        [Fact]
        public void LogMessage_AsInformation_OncePerMethodOverload()
        {
            logger.Information<CustomHandlerShould>(message);
            logger.Information<CustomHandlerShould>(exception);
            logger.Information<CustomHandlerShould>(message, exception);

            mockLogger.Verify(logger => logger.Information<CustomHandlerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Information<CustomHandlerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Information<CustomHandlerShould>(message, exception), Times.Once);

            mockLogger.ResetCalls();

            logger.Information(message);
            logger.Information(exception);
            logger.Information(message, exception);

            mockLogger.Verify(logger => logger.Information(message), Times.Once);
            mockLogger.Verify(logger => logger.Information(exception), Times.Once);
            mockLogger.Verify(logger => logger.Information(message, exception), Times.Once);
        }

        [Fact]
        public void LogMessage_AsWarning_OncePerMethodOverload()
        {
            logger.Warning<CustomHandlerShould>(message);
            logger.Warning<CustomHandlerShould>(exception);
            logger.Warning<CustomHandlerShould>(message, exception);

            mockLogger.Verify(logger => logger.Warning<CustomHandlerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Warning<CustomHandlerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Warning<CustomHandlerShould>(message, exception), Times.Once);

            mockLogger.ResetCalls();

            logger.Warning(message);
            logger.Warning(exception);
            logger.Warning(message, exception);

            mockLogger.Verify(logger => logger.Warning(message), Times.Once);
            mockLogger.Verify(logger => logger.Warning(exception), Times.Once);
            mockLogger.Verify(logger => logger.Warning(message, exception), Times.Once);
        }

        [Fact]
        public void LogMessage_AsError_OncePerMethodOverload()
        {
            logger.Error<CustomHandlerShould>(message);
            logger.Error<CustomHandlerShould>(exception);
            logger.Error<CustomHandlerShould>(message, exception);

            mockLogger.Verify(logger => logger.Error<CustomHandlerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Error<CustomHandlerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Error<CustomHandlerShould>(message, exception), Times.Once);

            mockLogger.ResetCalls();
            
            logger.Error(message);
            logger.Error(exception);
            logger.Error(message, exception);

            mockLogger.Verify(logger => logger.Error(message), Times.Once);
            mockLogger.Verify(logger => logger.Error(exception), Times.Once);
            mockLogger.Verify(logger => logger.Error(message, exception), Times.Once);
        }

        [Fact]
        public void LogMessage_AsCritical_OncePerMethodOverload()
        {
            logger.Critical<CustomHandlerShould>(message);
            logger.Critical<CustomHandlerShould>(exception);
            logger.Critical<CustomHandlerShould>(message, exception);

            mockLogger.Verify(logger => logger.Critical<CustomHandlerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Critical<CustomHandlerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Critical<CustomHandlerShould>(message, exception), Times.Once);

            mockLogger.ResetCalls();

            logger.Critical(message);
            logger.Critical(exception);
            logger.Critical(message, exception);

            mockLogger.Verify(logger => logger.Critical(message), Times.Once);
            mockLogger.Verify(logger => logger.Critical(exception), Times.Once);
            mockLogger.Verify(logger => logger.Critical(message, exception), Times.Once);
        }
    }
}