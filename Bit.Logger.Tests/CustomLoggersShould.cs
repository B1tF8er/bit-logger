namespace Bit.Logger.Tests
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using Moq;
    using System;
    using System.Collections.Generic;
    using Xunit;
    using static Constants;

    public class CustomLoggersShould
    {
        private readonly Mock<ILoggerFactory> mockLoggerFactory;
        private readonly ILoggerFactory loggerFactory;

        public CustomLoggersShould()
        {
            mockLoggerFactory = new Mock<ILoggerFactory>(MockBehavior.Strict);

            loggerFactory = mockLoggerFactory.Object;

            mockLoggerFactory
                .SetupCallsWithSource<CustomLoggersShould>(TestMessage, TestException)
                .SetupCallsWithoutSource(TestMessage, TestException)
                .Setup(loggerFactory => loggerFactory.AddSources(It.IsAny<IEnumerable<ILogger>>()))
                .Returns(loggerFactory);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload()
        {
            loggerFactory.Trace<CustomLoggersShould>(TestMessage);
            loggerFactory.Trace<CustomLoggersShould>(TestException);
            loggerFactory.Trace<CustomLoggersShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggersShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggersShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggersShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Debug<CustomLoggersShould>(TestMessage);
            loggerFactory.Debug<CustomLoggersShould>(TestException);
            loggerFactory.Debug<CustomLoggersShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggersShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggersShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggersShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Verbose<CustomLoggersShould>(TestMessage);
            loggerFactory.Verbose<CustomLoggersShould>(TestException);
            loggerFactory.Verbose<CustomLoggersShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggersShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggersShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggersShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Information<CustomLoggersShould>(TestMessage);
            loggerFactory.Information<CustomLoggersShould>(TestException);
            loggerFactory.Information<CustomLoggersShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggersShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggersShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggersShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Warning<CustomLoggersShould>(TestMessage);
            loggerFactory.Warning<CustomLoggersShould>(TestException);
            loggerFactory.Warning<CustomLoggersShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggersShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggersShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggersShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Error<CustomLoggersShould>(TestMessage);
            loggerFactory.Error<CustomLoggersShould>(TestException);
            loggerFactory.Error<CustomLoggersShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggersShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggersShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggersShould>(TestMessage, TestException), Times.Once);

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
            loggerFactory.Critical<CustomLoggersShould>(TestMessage);
            loggerFactory.Critical<CustomLoggersShould>(TestException);
            loggerFactory.Critical<CustomLoggersShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggersShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggersShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggersShould>(TestMessage, TestException), Times.Once);

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