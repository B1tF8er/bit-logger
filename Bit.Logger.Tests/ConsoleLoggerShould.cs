namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Moq;
    using System;
    using Xunit;
    using static Constants;

    public class ConsoleLoggerShould
    {
        private readonly Mock<ILoggerFactory> mockLoggerFactory;
        private readonly ILoggerFactory loggerFactory;

        public ConsoleLoggerShould()
        {
            mockLoggerFactory = new Mock<ILoggerFactory>(MockBehavior.Strict);

            loggerFactory = mockLoggerFactory.Object;

            mockLoggerFactory
                .SetupCallsWithSource<ConsoleLoggerShould>(TestMessage, TestException)
                .SetupCallsWithoutSource(TestMessage, TestException)
                .Setup(loggerFactory => loggerFactory.AddConsoleSource(It.IsAny<Configuration>()))
                .Returns(loggerFactory);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload()
        {
            loggerFactory.Trace<ConsoleLoggerShould>(TestMessage);
            loggerFactory.Trace<ConsoleLoggerShould>(TestException);
            loggerFactory.Trace<ConsoleLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Trace<ConsoleLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<ConsoleLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Debug<ConsoleLoggerShould>(TestMessage);
            loggerFactory.Debug<ConsoleLoggerShould>(TestException);
            loggerFactory.Debug<ConsoleLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Debug<ConsoleLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<ConsoleLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Verbose<ConsoleLoggerShould>(TestMessage);
            loggerFactory.Verbose<ConsoleLoggerShould>(TestException);
            loggerFactory.Verbose<ConsoleLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Verbose<ConsoleLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<ConsoleLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Information<ConsoleLoggerShould>(TestMessage);
            loggerFactory.Information<ConsoleLoggerShould>(TestException);
            loggerFactory.Information<ConsoleLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Information<ConsoleLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<ConsoleLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Warning<ConsoleLoggerShould>(TestMessage);
            loggerFactory.Warning<ConsoleLoggerShould>(TestException);
            loggerFactory.Warning<ConsoleLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Warning<ConsoleLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<ConsoleLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Error<ConsoleLoggerShould>(TestMessage);
            loggerFactory.Error<ConsoleLoggerShould>(TestException);
            loggerFactory.Error<ConsoleLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Error<ConsoleLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<ConsoleLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Critical<ConsoleLoggerShould>(TestMessage);
            loggerFactory.Critical<ConsoleLoggerShould>(TestException);
            loggerFactory.Critical<ConsoleLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Critical<ConsoleLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<ConsoleLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);

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
