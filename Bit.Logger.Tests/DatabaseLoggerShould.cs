namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Moq;
    using System;
    using Xunit;

    public class DatabaseLoggerShould
    {
        private readonly Mock<ILoggerFactory> mockLoggerFactory;
        private readonly ILoggerFactory loggerFactory;
        private readonly Exception exception;
        private const string message = "Test message";

        public DatabaseLoggerShould()
        {
            mockLoggerFactory = new Mock<ILoggerFactory>(MockBehavior.Strict);

            loggerFactory = mockLoggerFactory.Object;

            exception = new Exception("Test exception");

            mockLoggerFactory
                .SetupCallsWithSource<DatabaseLoggerShould>(message, exception)
                .SetupCallsWithoutSource(message, exception)
                .Setup(loggerFactory => loggerFactory.AddDatabaseSource(It.IsAny<Configuration>()))
                .Returns(loggerFactory);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload()
        {
            loggerFactory.Trace<DatabaseLoggerShould>(message);
            loggerFactory.Trace<DatabaseLoggerShould>(exception);
            loggerFactory.Trace<DatabaseLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Trace<DatabaseLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<DatabaseLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<DatabaseLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Debug<DatabaseLoggerShould>(message);
            loggerFactory.Debug<DatabaseLoggerShould>(exception);
            loggerFactory.Debug<DatabaseLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Debug<DatabaseLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<DatabaseLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<DatabaseLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Verbose<DatabaseLoggerShould>(message);
            loggerFactory.Verbose<DatabaseLoggerShould>(exception);
            loggerFactory.Verbose<DatabaseLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Verbose<DatabaseLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<DatabaseLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<DatabaseLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Information<DatabaseLoggerShould>(message);
            loggerFactory.Information<DatabaseLoggerShould>(exception);
            loggerFactory.Information<DatabaseLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Information<DatabaseLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<DatabaseLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<DatabaseLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Warning<DatabaseLoggerShould>(message);
            loggerFactory.Warning<DatabaseLoggerShould>(exception);
            loggerFactory.Warning<DatabaseLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Warning<DatabaseLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<DatabaseLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<DatabaseLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Error<DatabaseLoggerShould>(message);
            loggerFactory.Error<DatabaseLoggerShould>(exception);
            loggerFactory.Error<DatabaseLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Error<DatabaseLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<DatabaseLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<DatabaseLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Critical<DatabaseLoggerShould>(message);
            loggerFactory.Critical<DatabaseLoggerShould>(exception);
            loggerFactory.Critical<DatabaseLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Critical<DatabaseLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<DatabaseLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<DatabaseLoggerShould>(message, exception), Times.Once);

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
