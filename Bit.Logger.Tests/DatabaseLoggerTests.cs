namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using System;
    using Xunit;

    public class DatabaseLoggerTests
    {
        private ILogger logger;
        private const string message = "Test message";
        private readonly Exception exception = new Exception("Test exception");
        private readonly DatabaseConfiguration configuration;

        public DatabaseLoggerTests()
        {
            configuration = new DatabaseConfiguration
            {
                ShowDate = true,
                ShowTime = true,
                ShowLevel = true,
                Level = Level.Critical,
                ConnectionString = "testConnectionString"
            };

            logger = new Logger();

            logger.AddDatabaseHandler(configuration);
        }

        [Fact]
        public void Trace_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Trace<DatabaseLoggerTests>(message);
            logger.Trace<DatabaseLoggerTests>(exception);
            logger.Trace<DatabaseLoggerTests>(message, exception);
        }

        [Fact]
        public void Debug_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Debug<DatabaseLoggerTests>(message);
            logger.Debug<DatabaseLoggerTests>(exception);
            logger.Debug<DatabaseLoggerTests>(message, exception);
        }

        [Fact]
        public void Verbose_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Verbose<DatabaseLoggerTests>(message);
            logger.Verbose<DatabaseLoggerTests>(exception);
            logger.Verbose<DatabaseLoggerTests>(message, exception);
        }

        [Fact]
        public void Information_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Information<DatabaseLoggerTests>(message);
            logger.Information<DatabaseLoggerTests>(exception);
            logger.Information<DatabaseLoggerTests>(message, exception);
        }

        [Fact]
        public void Warning_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Warning<DatabaseLoggerTests>(message);
            logger.Warning<DatabaseLoggerTests>(exception);
            logger.Warning<DatabaseLoggerTests>(message, exception);
        }

        [Fact]
        public void Error_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Error<DatabaseLoggerTests>(message);
            logger.Error<DatabaseLoggerTests>(exception);
            logger.Error<DatabaseLoggerTests>(message, exception);
        }

        [Fact]
        public void Critical_WithSourceClassAndLevelEqualToCritical_ShouldLogMessage()
        {
            logger.Critical<DatabaseLoggerTests>(message);
            logger.Critical<DatabaseLoggerTests>(exception);
            logger.Critical<DatabaseLoggerTests>(message, exception);
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
