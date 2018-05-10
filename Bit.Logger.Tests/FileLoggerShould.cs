namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Moq;
    using System;
    using Xunit;
    using static Constants;

    public class FileLoggerShould
    {
        private readonly Mock<ILoggerFactory> mockLoggerFactory;
        private readonly ILoggerFactory loggerFactory;

        public FileLoggerShould()
        {
            mockLoggerFactory = new Mock<ILoggerFactory>(MockBehavior.Strict);

            loggerFactory = mockLoggerFactory.Object;

            mockLoggerFactory
                .SetupCallsWithSource<FileLoggerShould>(TestMessage, TestException)
                .SetupCallsWithoutSource(TestMessage, TestException)
                .Setup(loggerFactory => loggerFactory.AddFileSource(It.IsAny<Configuration>()))
                .Returns(loggerFactory);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload()
        {
            loggerFactory.Trace<FileLoggerShould>(TestMessage);
            loggerFactory.Trace<FileLoggerShould>(TestException);
            loggerFactory.Trace<FileLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Trace<FileLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<FileLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<FileLoggerShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Debug<FileLoggerShould>(TestMessage);
            loggerFactory.Debug<FileLoggerShould>(TestException);
            loggerFactory.Debug<FileLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Debug<FileLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<FileLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<FileLoggerShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Verbose<FileLoggerShould>(TestMessage);
            loggerFactory.Verbose<FileLoggerShould>(TestException);
            loggerFactory.Verbose<FileLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Verbose<FileLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<FileLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<FileLoggerShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Information<FileLoggerShould>(TestMessage);
            loggerFactory.Information<FileLoggerShould>(TestException);
            loggerFactory.Information<FileLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Information<FileLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<FileLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<FileLoggerShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Warning<FileLoggerShould>(TestMessage);
            loggerFactory.Warning<FileLoggerShould>(TestException);
            loggerFactory.Warning<FileLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Warning<FileLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<FileLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<FileLoggerShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Error<FileLoggerShould>(TestMessage);
            loggerFactory.Error<FileLoggerShould>(TestException);
            loggerFactory.Error<FileLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Error<FileLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<FileLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<FileLoggerShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Critical<FileLoggerShould>(TestMessage);
            loggerFactory.Critical<FileLoggerShould>(TestException);
            loggerFactory.Critical<FileLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Critical<FileLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<FileLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<FileLoggerShould>(TestMessage, TestException), Times.Once);

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
