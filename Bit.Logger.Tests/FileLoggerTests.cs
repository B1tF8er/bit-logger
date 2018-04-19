namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Moq;
    using System;
    using Xunit;
    using static SetupExtensions;

    public class FileLoggerTests
    {
        private readonly Mock<ILogger> mockLogger;
        private readonly ILogger logger;
        private readonly Exception exception;
        private const string message = "Test message";

        public FileLoggerTests()
        {
            mockLogger = new Mock<ILogger>(MockBehavior.Strict);

            logger = mockLogger.Object;

            exception = new Exception("Test exception");

            mockLogger
                .SetupCallsWithSource<FileLoggerTests>(message, exception)
                .SetupCallsWithoutSource(message, exception)
                .Setup(logger => logger.AddFileHandler(It.IsAny<Configuration>()))
                .Returns(logger);
        }

        [Fact]
        public void Trace_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Trace<FileLoggerTests>(message);
            logger.Trace<FileLoggerTests>(exception);
            logger.Trace<FileLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Trace<FileLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Trace<FileLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Trace<FileLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Debug_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Debug<FileLoggerTests>(message);
            logger.Debug<FileLoggerTests>(exception);
            logger.Debug<FileLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Debug<FileLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Debug<FileLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Debug<FileLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Verbose_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Verbose<FileLoggerTests>(message);
            logger.Verbose<FileLoggerTests>(exception);
            logger.Verbose<FileLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Verbose<FileLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Verbose<FileLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Verbose<FileLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Information_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Information<FileLoggerTests>(message);
            logger.Information<FileLoggerTests>(exception);
            logger.Information<FileLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Information<FileLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Information<FileLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Information<FileLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Warning_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Warning<FileLoggerTests>(message);
            logger.Warning<FileLoggerTests>(exception);
            logger.Warning<FileLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Warning<FileLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Warning<FileLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Warning<FileLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Error_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Error<FileLoggerTests>(message);
            logger.Error<FileLoggerTests>(exception);
            logger.Error<FileLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Error<FileLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Error<FileLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Error<FileLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Critical_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Critical<FileLoggerTests>(message);
            logger.Critical<FileLoggerTests>(exception);
            logger.Critical<FileLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Critical<FileLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Critical<FileLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Critical<FileLoggerTests>(message, exception), Times.Once);
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
