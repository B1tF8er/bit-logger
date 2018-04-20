namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Moq;
    using System;
    using Xunit;

    public class ConsoleLoggerShould
    {
        private readonly Mock<ILogger> mockLogger;
        private readonly ILogger logger;
        private readonly Exception exception;
        private const string message = "Test message";

        public ConsoleLoggerShould()
        {
            mockLogger = new Mock<ILogger>(MockBehavior.Strict);

            logger = mockLogger.Object;

            exception = new Exception("Test exception");

            mockLogger
                .SetupCallsWithSource<ConsoleLoggerShould>(message, exception)
                .SetupCallsWithoutSource(message, exception)
                .Setup(logger => logger.AddConsoleHandler(It.IsAny<Configuration>()))
                .Returns(logger);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload()
        {
            logger.Trace<ConsoleLoggerShould>(message);
            logger.Trace<ConsoleLoggerShould>(exception);
            logger.Trace<ConsoleLoggerShould>(message, exception);

            mockLogger.Verify(logger => logger.Trace<ConsoleLoggerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Trace<ConsoleLoggerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Trace<ConsoleLoggerShould>(message, exception), Times.Once);

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
            logger.Debug<ConsoleLoggerShould>(message);
            logger.Debug<ConsoleLoggerShould>(exception);
            logger.Debug<ConsoleLoggerShould>(message, exception);

            mockLogger.Verify(logger => logger.Debug<ConsoleLoggerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Debug<ConsoleLoggerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Debug<ConsoleLoggerShould>(message, exception), Times.Once);

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
            logger.Verbose<ConsoleLoggerShould>(message);
            logger.Verbose<ConsoleLoggerShould>(exception);
            logger.Verbose<ConsoleLoggerShould>(message, exception);

            mockLogger.Verify(logger => logger.Verbose<ConsoleLoggerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Verbose<ConsoleLoggerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Verbose<ConsoleLoggerShould>(message, exception), Times.Once);

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
            logger.Information<ConsoleLoggerShould>(message);
            logger.Information<ConsoleLoggerShould>(exception);
            logger.Information<ConsoleLoggerShould>(message, exception);

            mockLogger.Verify(logger => logger.Information<ConsoleLoggerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Information<ConsoleLoggerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Information<ConsoleLoggerShould>(message, exception), Times.Once);

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
            logger.Warning<ConsoleLoggerShould>(message);
            logger.Warning<ConsoleLoggerShould>(exception);
            logger.Warning<ConsoleLoggerShould>(message, exception);

            mockLogger.Verify(logger => logger.Warning<ConsoleLoggerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Warning<ConsoleLoggerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Warning<ConsoleLoggerShould>(message, exception), Times.Once);

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
            logger.Error<ConsoleLoggerShould>(message);
            logger.Error<ConsoleLoggerShould>(exception);
            logger.Error<ConsoleLoggerShould>(message, exception);

            mockLogger.Verify(logger => logger.Error<ConsoleLoggerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Error<ConsoleLoggerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Error<ConsoleLoggerShould>(message, exception), Times.Once);

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
            logger.Critical<ConsoleLoggerShould>(message);
            logger.Critical<ConsoleLoggerShould>(exception);
            logger.Critical<ConsoleLoggerShould>(message, exception);

            mockLogger.Verify(logger => logger.Critical<ConsoleLoggerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Critical<ConsoleLoggerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Critical<ConsoleLoggerShould>(message, exception), Times.Once);

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
