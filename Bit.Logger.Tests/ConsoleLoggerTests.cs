namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Moq;
    using System;
    using Xunit;

    public class ConsoleLoggerTests
    {
        private ILogger logger;
        private readonly Mock<ILogger> mockLogger;
        private const string message = "Test message";
        private readonly Exception exception = new Exception("Test exception");

        public ConsoleLoggerTests()
        {
            mockLogger = new Mock<ILogger>(MockBehavior.Strict);

            mockLogger
                .SetupCallsWithSource<ConsoleLoggerTests>(message, exception)
                .SetupCallsWithoutSource(message, exception)
                .Setup(logger => logger.AddConsoleHandler(It.IsAny<Configuration>()))
                .Returns(mockLogger.Object);

            logger = mockLogger.Object;
        }

        [Fact]
        public void Trace_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Trace<ConsoleLoggerTests>(message);
            logger.Trace<ConsoleLoggerTests>(exception);
            logger.Trace<ConsoleLoggerTests>(message, exception);
        }

        [Fact]
        public void Debug_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Debug<ConsoleLoggerTests>(message);
            logger.Debug<ConsoleLoggerTests>(exception);
            logger.Debug<ConsoleLoggerTests>(message, exception);
        }

        [Fact]
        public void Verbose_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Verbose<ConsoleLoggerTests>(message);
            logger.Verbose<ConsoleLoggerTests>(exception);
            logger.Verbose<ConsoleLoggerTests>(message, exception);
        }

        [Fact]
        public void Information_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Information<ConsoleLoggerTests>(message);
            logger.Information<ConsoleLoggerTests>(exception);
            logger.Information<ConsoleLoggerTests>(message, exception);
        }

        [Fact]
        public void Warning_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Warning<ConsoleLoggerTests>(message);
            logger.Warning<ConsoleLoggerTests>(exception);
            logger.Warning<ConsoleLoggerTests>(message, exception);
        }

        [Fact]
        public void Error_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Error<ConsoleLoggerTests>(message);
            logger.Error<ConsoleLoggerTests>(exception);
            logger.Error<ConsoleLoggerTests>(message, exception);
        }

        [Fact]
        public void Critical_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Critical<ConsoleLoggerTests>(message);
            logger.Critical<ConsoleLoggerTests>(exception);
            logger.Critical<ConsoleLoggerTests>(message, exception);
        }

        [Fact]
        public void Trace_WithoutSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Trace(message);
            logger.Trace(exception);
            logger.Trace(message, exception);
        }

        [Fact]
        public void Debug_WithoutSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Debug(message);
            logger.Debug(exception);
            logger.Debug(message, exception);
        }

        [Fact]
        public void Verbose_WithoutSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Verbose(message);
            logger.Verbose(exception);
            logger.Verbose(message, exception);
        }

        [Fact]
        public void Information_WithoutSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Information(message);
            logger.Information(exception);
            logger.Information(message, exception);
        }

        [Fact]
        public void Warning_WithoutSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Warning(message);
            logger.Warning(exception);
            logger.Warning(message, exception);
        }

        [Fact]
        public void Error_WithoutSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Error(message);
            logger.Error(exception);
            logger.Error(message, exception);
        }

        [Fact]
        public void Critical_WithoutSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Critical(message);
            logger.Critical(exception);
            logger.Critical(message, exception);
        }
    }
}
