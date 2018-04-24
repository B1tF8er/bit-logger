namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Moq;
    using System;
    using Xunit;

    public class FileLoggerShould
    {
        private readonly Mock<ILoggerFactory> mockLoggerFactory;
        private readonly ILoggerFactory loggerFactory;
        private readonly Exception exception;
        private const string message = "Test message";

        public FileLoggerShould()
        {
            mockLoggerFactory = new Mock<ILoggerFactory>(MockBehavior.Strict);

            loggerFactory = mockLoggerFactory.Object;

            exception = new Exception("Test exception");

            mockLoggerFactory
                .SetupCallsWithSource<FileLoggerShould>(message, exception)
                .SetupCallsWithoutSource(message, exception)
                .Setup(loggerFactory => loggerFactory.AddFile(It.IsAny<Configuration>()))
                .Returns(loggerFactory);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload()
        {
            loggerFactory.Trace<FileLoggerShould>(message);
            loggerFactory.Trace<FileLoggerShould>(exception);
            loggerFactory.Trace<FileLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Trace<FileLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<FileLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<FileLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Debug<FileLoggerShould>(message);
            loggerFactory.Debug<FileLoggerShould>(exception);
            loggerFactory.Debug<FileLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Debug<FileLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<FileLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<FileLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Verbose<FileLoggerShould>(message);
            loggerFactory.Verbose<FileLoggerShould>(exception);
            loggerFactory.Verbose<FileLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Verbose<FileLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<FileLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<FileLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Information<FileLoggerShould>(message);
            loggerFactory.Information<FileLoggerShould>(exception);
            loggerFactory.Information<FileLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Information<FileLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<FileLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<FileLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Warning<FileLoggerShould>(message);
            loggerFactory.Warning<FileLoggerShould>(exception);
            loggerFactory.Warning<FileLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Warning<FileLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<FileLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<FileLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Error<FileLoggerShould>(message);
            loggerFactory.Error<FileLoggerShould>(exception);
            loggerFactory.Error<FileLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Error<FileLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<FileLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<FileLoggerShould>(message, exception), Times.Once);

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
            loggerFactory.Critical<FileLoggerShould>(message);
            loggerFactory.Critical<FileLoggerShould>(exception);
            loggerFactory.Critical<FileLoggerShould>(message, exception);

            mockLoggerFactory.Verify(logger => logger.Critical<FileLoggerShould>(message), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<FileLoggerShould>(exception), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<FileLoggerShould>(message, exception), Times.Once);

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
