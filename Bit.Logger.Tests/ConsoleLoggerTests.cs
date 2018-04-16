namespace Bit.Logger.Tests
{
    using System;
    using Bit.Logger;
    using Bit.Logger.Config;
    using Xunit;

    public class ConsoleLoggerTests
    {
        private Logger logger;
        private const string message = "Test message";
        private readonly Exception exception = new Exception("Test exception");
        private readonly ConsoleConfiguration configuration;

        public ConsoleLoggerTests()
        {
            configuration = new ConsoleConfiguration
            {
                ShowDate = true,
                ShowTime = true,
                ShowLevel = true,
                Level = Level.Critical,
                ShowColors = true
            };

            logger = new Logger();

            logger.AddConsoleHandler(configuration);
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
