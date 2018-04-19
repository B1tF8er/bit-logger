namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Moq;
    using System;
    using Xunit;

    public class DatabaseLoggerTests
    {
        private readonly Mock<ILogger> mockLogger;
        private readonly ILogger logger;
        private readonly Exception exception;
        private const string message = "Test message";

        public DatabaseLoggerTests()
        {
            mockLogger = new Mock<ILogger>(MockBehavior.Strict);

            logger = mockLogger.Object;

            exception = new Exception("Test exception");

            mockLogger
                .SetupCallsWithSource<DatabaseLoggerTests>(message, exception)
                .SetupCallsWithoutSource(message, exception)
                .Setup(logger => logger.AddDatabaseHandler(It.IsAny<Configuration>()))
                .Returns(logger);
        }

        [Fact]
        public void Trace_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Trace<DatabaseLoggerTests>(message);
            logger.Trace<DatabaseLoggerTests>(exception);
            logger.Trace<DatabaseLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Trace<DatabaseLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Trace<DatabaseLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Trace<DatabaseLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Debug_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Debug<DatabaseLoggerTests>(message);
            logger.Debug<DatabaseLoggerTests>(exception);
            logger.Debug<DatabaseLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Debug<DatabaseLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Debug<DatabaseLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Debug<DatabaseLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Verbose_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Verbose<DatabaseLoggerTests>(message);
            logger.Verbose<DatabaseLoggerTests>(exception);
            logger.Verbose<DatabaseLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Verbose<DatabaseLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Verbose<DatabaseLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Verbose<DatabaseLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Information_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Information<DatabaseLoggerTests>(message);
            logger.Information<DatabaseLoggerTests>(exception);
            logger.Information<DatabaseLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Information<DatabaseLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Information<DatabaseLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Information<DatabaseLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Warning_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Warning<DatabaseLoggerTests>(message);
            logger.Warning<DatabaseLoggerTests>(exception);
            logger.Warning<DatabaseLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Warning<DatabaseLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Warning<DatabaseLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Warning<DatabaseLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Error_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Error<DatabaseLoggerTests>(message);
            logger.Error<DatabaseLoggerTests>(exception);
            logger.Error<DatabaseLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Error<DatabaseLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Error<DatabaseLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Error<DatabaseLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Critical_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Critical<DatabaseLoggerTests>(message);
            logger.Critical<DatabaseLoggerTests>(exception);
            logger.Critical<DatabaseLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Critical<DatabaseLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Critical<DatabaseLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Critical<DatabaseLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Trace_WithoutSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Trace(message);
            logger.Trace(exception);
            logger.Trace(message, exception);

            mockLogger.Verify(logger => logger.Trace(message), Times.Once);
            mockLogger.Verify(logger => logger.Trace(exception), Times.Once);
            mockLogger.Verify(logger => logger.Trace(message, exception), Times.Once);
        }

        [Fact]
        public void Debug_WithoutSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Debug(message);
            logger.Debug(exception);
            logger.Debug(message, exception);

            mockLogger.Verify(logger => logger.Debug(message), Times.Once);
            mockLogger.Verify(logger => logger.Debug(exception), Times.Once);
            mockLogger.Verify(logger => logger.Debug(message, exception), Times.Once);
        }

        [Fact]
        public void Verbose_WithoutSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Verbose(message);
            logger.Verbose(exception);
            logger.Verbose(message, exception);

            mockLogger.Verify(logger => logger.Verbose(message), Times.Once);
            mockLogger.Verify(logger => logger.Verbose(exception), Times.Once);
            mockLogger.Verify(logger => logger.Verbose(message, exception), Times.Once);
        }

        [Fact]
        public void Information_WithoutSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Information(message);
            logger.Information(exception);
            logger.Information(message, exception);

            mockLogger.Verify(logger => logger.Information(message), Times.Once);
            mockLogger.Verify(logger => logger.Information(exception), Times.Once);
            mockLogger.Verify(logger => logger.Information(message, exception), Times.Once);
        }

        [Fact]
        public void Warning_WithoutSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Warning(message);
            logger.Warning(exception);
            logger.Warning(message, exception);

            mockLogger.Verify(logger => logger.Warning(message), Times.Once);
            mockLogger.Verify(logger => logger.Warning(exception), Times.Once);
            mockLogger.Verify(logger => logger.Warning(message, exception), Times.Once);
        }

        [Fact]
        public void Error_WithoutSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Error(message);
            logger.Error(exception);
            logger.Error(message, exception);

            mockLogger.Verify(logger => logger.Error(message), Times.Once);
            mockLogger.Verify(logger => logger.Error(exception), Times.Once);
            mockLogger.Verify(logger => logger.Error(message, exception), Times.Once);
        }

        [Fact]
        public void Critical_WithoutSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Critical(message);
            logger.Critical(exception);
            logger.Critical(message, exception);

            mockLogger.Verify(logger => logger.Critical(message), Times.Once);
            mockLogger.Verify(logger => logger.Critical(exception), Times.Once);
            mockLogger.Verify(logger => logger.Critical(message, exception), Times.Once);
        }
    }
}
