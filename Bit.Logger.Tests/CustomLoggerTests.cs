namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using System;
    using Xunit;

    public class CustomLoggerTests
    {
        private Logger logger;
        private const string message = "Test message";
        private readonly Exception exception = new Exception("Test exception");
        private readonly ConsoleConfiguration configuration;

        public CustomLoggerTests()
        {
            logger = new Logger();

            var customLogger = new CustomLogger();

            logger.AddHandler(customLogger);            
        }

        [Fact]
        public void Trace_ShouldBeExposedForCustomLoggerWithSourceClass()
        {
            logger.Trace<CustomLoggerTests>(message);
            logger.Trace<CustomLoggerTests>(exception);
            logger.Trace<CustomLoggerTests>(message, exception);
        }

        [Fact]
        public void Trace_ShouldBeExposedForCustomLoggerWithoutSourceClass()
        {
            logger.Trace(message);
            logger.Trace(exception);
            logger.Trace(message, exception);
        }

        [Fact]
        public void Debug_ShouldBeExposedForCustomLoggerWithSourceClass()
        {
            logger.Debug<CustomLoggerTests>(message);
            logger.Debug<CustomLoggerTests>(exception);
            logger.Debug<CustomLoggerTests>(message, exception);
        }

        [Fact]
        public void Debug_ShouldBeExposedForCustomLoggerWithoutSourceClass()
        {
            logger.Debug(message);
            logger.Debug(exception);
            logger.Debug(message, exception);
        }

        [Fact]
        public void Verbose_ShouldBeExposedForCustomLoggerWithSourceClass()
        {
            logger.Verbose<CustomLoggerTests>(message);
            logger.Verbose<CustomLoggerTests>(exception);
            logger.Verbose<CustomLoggerTests>(message, exception);
        }

        [Fact]
        public void Verbose_ShouldBeExposedForCustomLoggerWithoutSourceClass()
        {
            logger.Verbose(message);
            logger.Verbose(exception);
            logger.Verbose(message, exception);
        }

        [Fact]
        public void Information_ShouldBeExposedForCustomLoggerWithSourceClass()
        {
            logger.Information<CustomLoggerTests>(message);
            logger.Information<CustomLoggerTests>(exception);
            logger.Information<CustomLoggerTests>(message, exception);
        }

        [Fact]
        public void Information_ShouldBeExposedForCustomLoggerWithoutSourceClass()
        {
            logger.Information(message);
            logger.Information(exception);
            logger.Information(message, exception);
        }

        [Fact]
        public void Warning_ShouldBeExposedForCustomLoggerWithSourceClass()
        {
            logger.Information<CustomLoggerTests>(message);
            logger.Information<CustomLoggerTests>(exception);
            logger.Information<CustomLoggerTests>(message, exception);
        }

        [Fact]
        public void Warning_ShouldBeExposedForCustomLoggerWithoutSourceClass()
        {
            logger.Information(message);
            logger.Information(exception);
            logger.Information(message, exception);
        }

        [Fact]
        public void Error_ShouldBeExposedForCustomLoggerWithSourceClass()
        {
            logger.Error<CustomLoggerTests>(message);
            logger.Error<CustomLoggerTests>(exception);
            logger.Error<CustomLoggerTests>(message, exception);
        }

        [Fact]
        public void Error_ShouldBeExposedForCustomLoggerWithoutSourceClass()
        {
            logger.Error(message);
            logger.Error(exception);
            logger.Error(message, exception);
        }

        [Fact]
        public void Critical_ShouldBeExposedForCustomLoggerWithSourceClass()
        {
            logger.Critical<CustomLoggerTests>(message);
            logger.Critical<CustomLoggerTests>(exception);
            logger.Critical<CustomLoggerTests>(message, exception);
        }

        [Fact]
        public void Critical_ShouldBeExposedForCustomLoggerWithoutSourceClass()
        {
            logger.Critical(message);
            logger.Critical(exception);
            logger.Critical(message, exception);
        }
    }
}