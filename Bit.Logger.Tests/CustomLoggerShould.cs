namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Moq;
    using System;
    using Xunit;

    public class CustomLoggerShould
    {
        private readonly Mock<ILoggerFactoty> mockLoggerFactory;
        private readonly ILoggerFactoty loggerFactory;
        private readonly Exception exception;
        private const string message = "Test message";

        public CustomLoggerShould()
        {
            mockLoggerFactory = new Mock<ILoggerFactoty>(MockBehavior.Strict);

            loggerFactory = mockLoggerFactory.Object;

            exception = new Exception("Test exception");

            mockLoggerFactory
                .SetupCallsWithSource<CustomLoggerShould>(message, exception)
                .SetupCallsWithoutSource(message, exception)
                .Setup(loggerFactory => loggerFactory.AddLogger(It.IsAny<ILogger>()))
                .Returns(loggerFactory);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload()
        {
            loggerFactory.Trace<CustomLoggerShould>(message);
            loggerFactory.Trace<CustomLoggerShould>(exception);
            loggerFactory.Trace<CustomLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggerShould>(message, exception), Times.Once);

            mockLoggerFactory.ResetCalls();

            loggerFactory.Trace(message);
            loggerFactory.Trace(exception);
            loggerFactory.Trace(message, exception);

            mockLoggerFactory.Verify(logger => logger.Trace(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace(message, exception), Times.Once);
        }

        [Fact]
        public void LogMessage_AsDebug_OncePerMethodOverload()
        {
            loggerFactory.Debug<CustomLoggerShould>(message);
            loggerFactory.Debug<CustomLoggerShould>(exception);
            loggerFactory.Debug<CustomLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggerShould>(message, exception), Times.Once);

            mockLoggerFactory.ResetCalls();

            loggerFactory.Debug(message);
            loggerFactory.Debug(exception);
            loggerFactory.Debug(message, exception);

            mockLoggerFactory.Verify(logger => logger.Debug(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug(message, exception), Times.Once);
        }

        [Fact]
        public void LogMessage_AsVerbose_OncePerMethodOverload()
        {
            loggerFactory.Verbose<CustomLoggerShould>(message);
            loggerFactory.Verbose<CustomLoggerShould>(exception);
            loggerFactory.Verbose<CustomLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggerShould>(message, exception), Times.Once);

            mockLoggerFactory.ResetCalls();
            
            loggerFactory.Verbose(message);
            loggerFactory.Verbose(exception);
            loggerFactory.Verbose(message, exception);

            mockLoggerFactory.Verify(logger => logger.Verbose(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose(message, exception), Times.Once);
        }

        [Fact]
        public void LogMessage_AsInformation_OncePerMethodOverload()
        {
            loggerFactory.Information<CustomLoggerShould>(message);
            loggerFactory.Information<CustomLoggerShould>(exception);
            loggerFactory.Information<CustomLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggerShould>(message, exception), Times.Once);

            mockLoggerFactory.ResetCalls();

            loggerFactory.Information(message);
            loggerFactory.Information(exception);
            loggerFactory.Information(message, exception);

            mockLoggerFactory.Verify(logger => logger.Information(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information(message, exception), Times.Once);
        }

        [Fact]
        public void LogMessage_AsWarning_OncePerMethodOverload()
        {
            loggerFactory.Warning<CustomLoggerShould>(message);
            loggerFactory.Warning<CustomLoggerShould>(exception);
            loggerFactory.Warning<CustomLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggerShould>(message, exception), Times.Once);

            mockLoggerFactory.ResetCalls();

            loggerFactory.Warning(message);
            loggerFactory.Warning(exception);
            loggerFactory.Warning(message, exception);

            mockLoggerFactory.Verify(logger => logger.Warning(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning(message, exception), Times.Once);
        }

        [Fact]
        public void LogMessage_AsError_OncePerMethodOverload()
        {
            loggerFactory.Error<CustomLoggerShould>(message);
            loggerFactory.Error<CustomLoggerShould>(exception);
            loggerFactory.Error<CustomLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggerShould>(message, exception), Times.Once);

            mockLoggerFactory.ResetCalls();
            
            loggerFactory.Error(message);
            loggerFactory.Error(exception);
            loggerFactory.Error(message, exception);

            mockLoggerFactory.Verify(logger => logger.Error(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error(message, exception), Times.Once);
        }

        [Fact]
        public void LogMessage_AsCritical_OncePerMethodOverload()
        {
            loggerFactory.Critical<CustomLoggerShould>(message);
            loggerFactory.Critical<CustomLoggerShould>(exception);
            loggerFactory.Critical<CustomLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggerShould>(message, exception), Times.Once);

            mockLoggerFactory.ResetCalls();

            loggerFactory.Critical(message);
            loggerFactory.Critical(exception);
            loggerFactory.Critical(message, exception);

            mockLoggerFactory.Verify(logger => logger.Critical(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical(message, exception), Times.Once);
        }
    }
}