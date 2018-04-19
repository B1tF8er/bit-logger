namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Bit.Logger.Handlers;
    using Moq;
    using System;
    using Xunit;

    public class CustomConsoleHandlerTests
    {
        private readonly Mock<ILogger> mockLogger;
        private readonly ILogger logger;
        private readonly Exception exception;
        private const string message = "Test message";

        public CustomConsoleHandlerTests()
        {
            mockLogger = new Mock<ILogger>(MockBehavior.Strict);

            logger = mockLogger.Object;

            exception = new Exception("Test exception");

            mockLogger
                .SetupCallsWithSource<CustomConsoleHandlerTests>(message, exception)
                .SetupCallsWithoutSource(message, exception)
                .Setup(logger => logger.AddHandler(It.IsAny<IHandler>()))
                .Returns(logger);
        }

        [Fact]
        public void Trace_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Trace<CustomConsoleHandlerTests>(message);
            logger.Trace<CustomConsoleHandlerTests>(exception);
            logger.Trace<CustomConsoleHandlerTests>(message, exception);

            mockLogger.Verify(logger => logger.Trace<CustomConsoleHandlerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Trace<CustomConsoleHandlerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Trace<CustomConsoleHandlerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Debug_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Debug<CustomConsoleHandlerTests>(message);
            logger.Debug<CustomConsoleHandlerTests>(exception);
            logger.Debug<CustomConsoleHandlerTests>(message, exception);

            mockLogger.Verify(logger => logger.Debug<CustomConsoleHandlerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Debug<CustomConsoleHandlerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Debug<CustomConsoleHandlerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Verbose_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Verbose<CustomConsoleHandlerTests>(message);
            logger.Verbose<CustomConsoleHandlerTests>(exception);
            logger.Verbose<CustomConsoleHandlerTests>(message, exception);

            mockLogger.Verify(logger => logger.Verbose<CustomConsoleHandlerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Verbose<CustomConsoleHandlerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Verbose<CustomConsoleHandlerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Information_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Information<CustomConsoleHandlerTests>(message);
            logger.Information<CustomConsoleHandlerTests>(exception);
            logger.Information<CustomConsoleHandlerTests>(message, exception);

            mockLogger.Verify(logger => logger.Information<CustomConsoleHandlerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Information<CustomConsoleHandlerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Information<CustomConsoleHandlerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Warning_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Warning<CustomConsoleHandlerTests>(message);
            logger.Warning<CustomConsoleHandlerTests>(exception);
            logger.Warning<CustomConsoleHandlerTests>(message, exception);

            mockLogger.Verify(logger => logger.Warning<CustomConsoleHandlerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Warning<CustomConsoleHandlerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Warning<CustomConsoleHandlerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Error_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Error<CustomConsoleHandlerTests>(message);
            logger.Error<CustomConsoleHandlerTests>(exception);
            logger.Error<CustomConsoleHandlerTests>(message, exception);

            mockLogger.Verify(logger => logger.Error<CustomConsoleHandlerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Error<CustomConsoleHandlerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Error<CustomConsoleHandlerTests>(message, exception), Times.Once);
        }

        [Fact]
        public void Critical_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Critical<CustomConsoleHandlerTests>(message);
            logger.Critical<CustomConsoleHandlerTests>(exception);
            logger.Critical<CustomConsoleHandlerTests>(message, exception);

            mockLogger.Verify(logger => logger.Critical<CustomConsoleHandlerTests>(message), Times.Once);
            mockLogger.Verify(logger => logger.Critical<CustomConsoleHandlerTests>(exception), Times.Once);
            mockLogger.Verify(logger => logger.Critical<CustomConsoleHandlerTests>(message, exception), Times.Once);
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