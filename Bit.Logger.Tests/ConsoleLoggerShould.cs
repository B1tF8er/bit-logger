namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Moq;
    using System;
    using Xunit;

    public class ConsoleLoggerShould
    {
        private readonly Mock<ILoggerFactory> mockLoggerFactory;
        private readonly ILoggerFactory loggerFactory;
        private readonly Exception exception;
        private const string message = "Test message";

        public ConsoleLoggerShould()
        {
            mockLoggerFactory = new Mock<ILoggerFactory>(MockBehavior.Strict);

            loggerFactory = mockLoggerFactory.Object;

            exception = new Exception("Test exception");

            mockLoggerFactory
                .SetupCallsWithSource<ConsoleLoggerShould>(message, exception)
                .SetupCallsWithoutSource(message, exception)
                .Setup(loggerFactory => loggerFactory.AddConsoleSource(It.IsAny<Configuration>()))
                .Returns(loggerFactory);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload()
        {
            loggerFactory.Trace<ConsoleLoggerShould>(message);
            loggerFactory.Trace<ConsoleLoggerShould>(exception);
            loggerFactory.Trace<ConsoleLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Trace<ConsoleLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<ConsoleLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<ConsoleLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Debug<ConsoleLoggerShould>(message);
            loggerFactory.Debug<ConsoleLoggerShould>(exception);
            loggerFactory.Debug<ConsoleLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Debug<ConsoleLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<ConsoleLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<ConsoleLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Verbose<ConsoleLoggerShould>(message);
            loggerFactory.Verbose<ConsoleLoggerShould>(exception);
            loggerFactory.Verbose<ConsoleLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Verbose<ConsoleLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<ConsoleLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<ConsoleLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Information<ConsoleLoggerShould>(message);
            loggerFactory.Information<ConsoleLoggerShould>(exception);
            loggerFactory.Information<ConsoleLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Information<ConsoleLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<ConsoleLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<ConsoleLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Warning<ConsoleLoggerShould>(message);
            loggerFactory.Warning<ConsoleLoggerShould>(exception);
            loggerFactory.Warning<ConsoleLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Warning<ConsoleLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<ConsoleLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<ConsoleLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Error<ConsoleLoggerShould>(message);
            loggerFactory.Error<ConsoleLoggerShould>(exception);
            loggerFactory.Error<ConsoleLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Error<ConsoleLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<ConsoleLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<ConsoleLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Critical<ConsoleLoggerShould>(message);
            loggerFactory.Critical<ConsoleLoggerShould>(exception);
            loggerFactory.Critical<ConsoleLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Critical<ConsoleLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<ConsoleLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<ConsoleLoggerShould>(message, exception), Times.Once);

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
