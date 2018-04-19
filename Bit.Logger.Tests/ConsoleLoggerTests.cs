namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Moq;
    using System;
    using Xunit;

    public class ConsoleLoggerTests
    {
        private readonly Mock<ILogger> mockLogger;
        private readonly ILogger logger;
        private readonly Exception exception;
        private const string message = "Test message";

        public ConsoleLoggerTests()
        {
            mockLogger = new Mock<ILogger>(MockBehavior.Strict);

            logger = mockLogger.Object;

            exception = new Exception("Test exception");

            mockLogger
                .SetupCallsWithSource<ConsoleLoggerTests>(message, exception)
                .SetupCallsWithoutSource(message, exception)
                .Setup(logger => logger.AddConsoleHandler(It.IsAny<Configuration>()))
                .Returns(logger);
        }

        [Fact]
        public void Trace_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Trace<ConsoleLoggerTests>(message);
            logger.Trace<ConsoleLoggerTests>(exception);
            logger.Trace<ConsoleLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Trace<ConsoleLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Trace<ConsoleLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Trace<ConsoleLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Debug_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Debug<ConsoleLoggerTests>(message);
            logger.Debug<ConsoleLoggerTests>(exception);
            logger.Debug<ConsoleLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Debug<ConsoleLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Debug<ConsoleLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Debug<ConsoleLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Verbose_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Verbose<ConsoleLoggerTests>(message);
            logger.Verbose<ConsoleLoggerTests>(exception);
            logger.Verbose<ConsoleLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Verbose<ConsoleLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Verbose<ConsoleLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Verbose<ConsoleLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Information_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Information<ConsoleLoggerTests>(message);
            logger.Information<ConsoleLoggerTests>(exception);
            logger.Information<ConsoleLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Information<ConsoleLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Information<ConsoleLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Information<ConsoleLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Warning_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Warning<ConsoleLoggerTests>(message);
            logger.Warning<ConsoleLoggerTests>(exception);
            logger.Warning<ConsoleLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Warning<ConsoleLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Warning<ConsoleLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Warning<ConsoleLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Error_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Error<ConsoleLoggerTests>(message);
            logger.Error<ConsoleLoggerTests>(exception);
            logger.Error<ConsoleLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Error<ConsoleLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Error<ConsoleLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Error<ConsoleLoggerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Critical_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Critical<ConsoleLoggerTests>(message);
            logger.Critical<ConsoleLoggerTests>(exception);
            logger.Critical<ConsoleLoggerTests>(message, exception);

            mockLogger.Verify(logger => logger.Critical<ConsoleLoggerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Critical<ConsoleLoggerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Critical<ConsoleLoggerTests>(message, exception), Times.Once);
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
