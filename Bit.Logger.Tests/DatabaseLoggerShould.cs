namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Moq;
    using System;
    using Xunit;
    using static Constants;

    public class DatabaseLoggerShould
    {
        private readonly Mock<ILoggerFactory> mockLoggerFactory;
        private readonly ILoggerFactory loggerFactory;

        public DatabaseLoggerShould()
        {
            mockLoggerFactory = new Mock<ILoggerFactory>(MockBehavior.Strict);

            loggerFactory = mockLoggerFactory.Object;

            mockLoggerFactory
                .SetupCallsWithSource<DatabaseLoggerShould>(TestMessage, TestException)
                .SetupCallsWithoutSource(TestMessage, TestException)
                .Setup(loggerFactory => loggerFactory.AddDatabaseSource(It.IsAny<Configuration>()))
                .Returns(loggerFactory);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload()
        {
            loggerFactory.Trace<DatabaseLoggerShould>(TestMessage);
            loggerFactory.Trace<DatabaseLoggerShould>(TestException);
            loggerFactory.Trace<DatabaseLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Trace<DatabaseLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<DatabaseLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);

            mockLoggerFactory.ResetCalls();

            loggerFactory.Trace(TestMessage);
            loggerFactory.Trace(TestException);
            loggerFactory.Trace(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Trace(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsDebug_OncePerMethodOverload()
        {
            loggerFactory.Debug<DatabaseLoggerShould>(TestMessage);
            loggerFactory.Debug<DatabaseLoggerShould>(TestException);
            loggerFactory.Debug<DatabaseLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Debug<DatabaseLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<DatabaseLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);

            mockLoggerFactory.ResetCalls();

            loggerFactory.Debug(TestMessage);
            loggerFactory.Debug(TestException);
            loggerFactory.Debug(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Debug(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsVerbose_OncePerMethodOverload()
        {
            loggerFactory.Verbose<DatabaseLoggerShould>(TestMessage);
            loggerFactory.Verbose<DatabaseLoggerShould>(TestException);
            loggerFactory.Verbose<DatabaseLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Verbose<DatabaseLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<DatabaseLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);

            mockLoggerFactory.ResetCalls();
            
            loggerFactory.Verbose(TestMessage);
            loggerFactory.Verbose(TestException);
            loggerFactory.Verbose(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Verbose(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsInformation_OncePerMethodOverload()
        {
            loggerFactory.Information<DatabaseLoggerShould>(TestMessage);
            loggerFactory.Information<DatabaseLoggerShould>(TestException);
            loggerFactory.Information<DatabaseLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Information<DatabaseLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<DatabaseLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);

            mockLoggerFactory.ResetCalls();

            loggerFactory.Information(TestMessage);
            loggerFactory.Information(TestException);
            loggerFactory.Information(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Information(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsWarning_OncePerMethodOverload()
        {
            loggerFactory.Warning<DatabaseLoggerShould>(TestMessage);
            loggerFactory.Warning<DatabaseLoggerShould>(TestException);
            loggerFactory.Warning<DatabaseLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Warning<DatabaseLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<DatabaseLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);

            mockLoggerFactory.ResetCalls();

            loggerFactory.Warning(TestMessage);
            loggerFactory.Warning(TestException);
            loggerFactory.Warning(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Warning(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsError_OncePerMethodOverload()
        {
            loggerFactory.Error<DatabaseLoggerShould>(TestMessage);
            loggerFactory.Error<DatabaseLoggerShould>(TestException);
            loggerFactory.Error<DatabaseLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Error<DatabaseLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<DatabaseLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);

            mockLoggerFactory.ResetCalls();
            
            loggerFactory.Error(TestMessage);
            loggerFactory.Error(TestException);
            loggerFactory.Error(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Error(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsCritical_OncePerMethodOverload()
        {
            loggerFactory.Critical<DatabaseLoggerShould>(TestMessage);
            loggerFactory.Critical<DatabaseLoggerShould>(TestException);
            loggerFactory.Critical<DatabaseLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Critical<DatabaseLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<DatabaseLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);

            mockLoggerFactory.ResetCalls();

            loggerFactory.Critical(TestMessage);
            loggerFactory.Critical(TestException);
            loggerFactory.Critical(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Critical(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical(TestMessage, TestException), Times.Once);
        }
    }
}
