namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Moq;
    using System;
    using System.Collections.Generic;
    using Xunit;

    public class CustomLoggersShould
    {
        private readonly Mock<ILoggerFactory> mockLoggerFactory;
        private readonly ILoggerFactory loggerFactory;
        private readonly Exception exception;
        private const string message = "Test message";

        public CustomLoggersShould()
        {
            mockLoggerFactory = new Mock<ILoggerFactory>(MockBehavior.Strict);

            loggerFactory = mockLoggerFactory.Object;

            exception = new Exception("Test exception");

            mockLoggerFactory
                .SetupCallsWithSource<CustomLoggersShould>(message, exception)
                .SetupCallsWithoutSource(message, exception)
                .Setup(loggerFactory => loggerFactory.AddSources(It.IsAny<IEnumerable<ILogger>>()))
                .Returns(loggerFactory);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload()
        {
            loggerFactory.Trace<CustomLoggersShould>(message);
            loggerFactory.Trace<CustomLoggersShould>(exception);
            loggerFactory.Trace<CustomLoggersShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggersShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggersShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggersShould>(message, exception), Times.Once);

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
            loggerFactory.Debug<CustomLoggersShould>(message);
            loggerFactory.Debug<CustomLoggersShould>(exception);
            loggerFactory.Debug<CustomLoggersShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggersShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggersShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggersShould>(message, exception), Times.Once);

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
            loggerFactory.Verbose<CustomLoggersShould>(message);
            loggerFactory.Verbose<CustomLoggersShould>(exception);
            loggerFactory.Verbose<CustomLoggersShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggersShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggersShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggersShould>(message, exception), Times.Once);

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
            loggerFactory.Information<CustomLoggersShould>(message);
            loggerFactory.Information<CustomLoggersShould>(exception);
            loggerFactory.Information<CustomLoggersShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggersShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggersShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggersShould>(message, exception), Times.Once);

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
            loggerFactory.Warning<CustomLoggersShould>(message);
            loggerFactory.Warning<CustomLoggersShould>(exception);
            loggerFactory.Warning<CustomLoggersShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggersShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggersShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggersShould>(message, exception), Times.Once);

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
            loggerFactory.Error<CustomLoggersShould>(message);
            loggerFactory.Error<CustomLoggersShould>(exception);
            loggerFactory.Error<CustomLoggersShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggersShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggersShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggersShould>(message, exception), Times.Once);

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
            loggerFactory.Critical<CustomLoggersShould>(message);
            loggerFactory.Critical<CustomLoggersShould>(exception);
            loggerFactory.Critical<CustomLoggersShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggersShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggersShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggersShould>(message, exception), Times.Once);

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