namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using System;
    using Xunit;

    public class CustomConsoleHandlerTests
    {
        private Logger logger;
        private const string message = "Test message";
        private readonly Exception exception = new Exception("Test exception");
        private readonly Configuration configuration;

        public CustomConsoleHandlerTests()
        {
            logger = new Logger();

            configuration = new Configuration
            {
                Level = Level.Critical
            };

            var customConsoleHandler = new CustomConsoleHandler(configuration);

            logger.AddHandler(customConsoleHandler);            
        }

        [Fact]
        public void Trace_ShouldBeExposedForCustomLoggerWithSourceClass()
        {
            logger.Trace<CustomConsoleHandlerTests>(message);
            logger.Trace<CustomConsoleHandlerTests>(exception);
            logger.Trace<CustomConsoleHandlerTests>(message, exception);
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
            logger.Debug<CustomConsoleHandlerTests>(message);
            logger.Debug<CustomConsoleHandlerTests>(exception);
            logger.Debug<CustomConsoleHandlerTests>(message, exception);
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
            logger.Verbose<CustomConsoleHandlerTests>(message);
            logger.Verbose<CustomConsoleHandlerTests>(exception);
            logger.Verbose<CustomConsoleHandlerTests>(message, exception);
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
            logger.Information<CustomConsoleHandlerTests>(message);
            logger.Information<CustomConsoleHandlerTests>(exception);
            logger.Information<CustomConsoleHandlerTests>(message, exception);
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
            logger.Information<CustomConsoleHandlerTests>(message);
            logger.Information<CustomConsoleHandlerTests>(exception);
            logger.Information<CustomConsoleHandlerTests>(message, exception);
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
            logger.Error<CustomConsoleHandlerTests>(message);
            logger.Error<CustomConsoleHandlerTests>(exception);
            logger.Error<CustomConsoleHandlerTests>(message, exception);
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
            logger.Critical<CustomConsoleHandlerTests>(message);
            logger.Critical<CustomConsoleHandlerTests>(exception);
            logger.Critical<CustomConsoleHandlerTests>(message, exception);
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