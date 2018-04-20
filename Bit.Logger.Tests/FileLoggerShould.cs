namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Moq;
    using System;
    using Xunit;
    using static SetupExtensions;

    public class FileLoggerShould
    {
        private readonly Mock<ILogger> mockLogger;
        private readonly ILogger logger;
        private readonly Exception exception;
        private const string message = "Test message";

        public FileLoggerShould()
        {
            mockLogger = new Mock<ILogger>(MockBehavior.Strict);

            logger = mockLogger.Object;

            exception = new Exception("Test exception");

            mockLogger
                .SetupCallsWithSource<FileLoggerShould>(message, exception)
                .SetupCallsWithoutSource(message, exception)
                .Setup(logger => logger.AddFileHandler(It.IsAny<Configuration>()))
                .Returns(logger);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload()
        {
            logger.Trace<FileLoggerShould>(message);
            logger.Trace<FileLoggerShould>(exception);
            logger.Trace<FileLoggerShould>(message, exception);

            mockLogger.Verify(logger => logger.Trace<FileLoggerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Trace<FileLoggerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Trace<FileLoggerShould>(message, exception), Times.Once);

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
            logger.Debug<FileLoggerShould>(message);
            logger.Debug<FileLoggerShould>(exception);
            logger.Debug<FileLoggerShould>(message, exception);

            mockLogger.Verify(logger => logger.Debug<FileLoggerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Debug<FileLoggerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Debug<FileLoggerShould>(message, exception), Times.Once);

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
            logger.Verbose<FileLoggerShould>(message);
            logger.Verbose<FileLoggerShould>(exception);
            logger.Verbose<FileLoggerShould>(message, exception);

            mockLogger.Verify(logger => logger.Verbose<FileLoggerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Verbose<FileLoggerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Verbose<FileLoggerShould>(message, exception), Times.Once);

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
            logger.Information<FileLoggerShould>(message);
            logger.Information<FileLoggerShould>(exception);
            logger.Information<FileLoggerShould>(message, exception);

            mockLogger.Verify(logger => logger.Information<FileLoggerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Information<FileLoggerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Information<FileLoggerShould>(message, exception), Times.Once);

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
            logger.Warning<FileLoggerShould>(message);
            logger.Warning<FileLoggerShould>(exception);
            logger.Warning<FileLoggerShould>(message, exception);

            mockLogger.Verify(logger => logger.Warning<FileLoggerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Warning<FileLoggerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Warning<FileLoggerShould>(message, exception), Times.Once);

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
            logger.Error<FileLoggerShould>(message);
            logger.Error<FileLoggerShould>(exception);
            logger.Error<FileLoggerShould>(message, exception);

            mockLogger.Verify(logger => logger.Error<FileLoggerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Error<FileLoggerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Error<FileLoggerShould>(message, exception), Times.Once);

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
            logger.Critical<FileLoggerShould>(message);
            logger.Critical<FileLoggerShould>(exception);
            logger.Critical<FileLoggerShould>(message, exception);

            mockLogger.Verify(logger => logger.Critical<FileLoggerShould>(message), Times.Once);
            mockLogger.Verify(logger => logger.Critical<FileLoggerShould>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Critical<FileLoggerShould>(message, exception), Times.Once);

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
