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

        public CustomLoggersShould()
        {
            mockLoggerFactory = new Mock<ILoggerFactory>(MockBehavior.Strict);

            mockLoggerFactory
                .SetupCallsWithSource<CustomLoggersShould>(TestMessage, TestException)
                .SetupCallsWithoutSource(TestMessage, TestException)
                .Setup(loggerFactory => loggerFactory.AddSources(It.IsAny<IEnumerable<ILogger>>()))
                .Returns(mockLoggerFactory.Object);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Trace<CustomLoggersShould>(TestMessage);
            mockLoggerFactory.Object.Trace<CustomLoggersShould>(TestException);
            mockLoggerFactory.Object.Trace<CustomLoggersShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggersShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggersShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<CustomLoggersShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload_WithoutSourceClass()
        {
            mockLoggerFactory.Object.Trace(TestMessage);
            mockLoggerFactory.Object.Trace(TestException);
            mockLoggerFactory.Object.Trace(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Trace(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsDebug_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Debug<CustomLoggersShould>(TestMessage);
            mockLoggerFactory.Object.Debug<CustomLoggersShould>(TestException);
            mockLoggerFactory.Object.Debug<CustomLoggersShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggersShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggersShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<CustomLoggersShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsDebug_OncePerMethodOverload_WithoutSourceClass()
        {
            mockLoggerFactory.Object.Debug(TestMessage);
            mockLoggerFactory.Object.Debug(TestException);
            mockLoggerFactory.Object.Debug(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Debug(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsVerbose_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Verbose<CustomLoggersShould>(TestMessage);
            mockLoggerFactory.Object.Verbose<CustomLoggersShould>(TestException);
            mockLoggerFactory.Object.Verbose<CustomLoggersShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggersShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggersShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<CustomLoggersShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsVerbose_OncePerMethodOverload_WithoutSourceClass()
        {
            mockLoggerFactory.Object.Verbose(TestMessage);
            mockLoggerFactory.Object.Verbose(TestException);
            mockLoggerFactory.Object.Verbose(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Verbose(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsInformation_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Information<CustomLoggersShould>(TestMessage);
            mockLoggerFactory.Object.Information<CustomLoggersShould>(TestException);
            mockLoggerFactory.Object.Information<CustomLoggersShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggersShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggersShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<CustomLoggersShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsInformation_OncePerMethodOverload_WithoutSourceClass()
        {
            mockLoggerFactory.Object.Information(TestMessage);
            mockLoggerFactory.Object.Information(TestException);
            mockLoggerFactory.Object.Information(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Information(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsWarning_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Warning<CustomLoggersShould>(TestMessage);
            mockLoggerFactory.Object.Warning<CustomLoggersShould>(TestException);
            mockLoggerFactory.Object.Warning<CustomLoggersShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggersShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggersShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<CustomLoggersShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsWarning_OncePerMethodOverload_WithoutSourceClass()
        {
            mockLoggerFactory.Object.Warning(TestMessage);
            mockLoggerFactory.Object.Warning(TestException);
            mockLoggerFactory.Object.Warning(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Warning(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsError_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Error<CustomLoggersShould>(TestMessage);
            mockLoggerFactory.Object.Error<CustomLoggersShould>(TestException);
            mockLoggerFactory.Object.Error<CustomLoggersShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggersShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggersShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<CustomLoggersShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsError_OncePerMethodOverload_WithoutSourceClass()
        {
            mockLoggerFactory.Object.Error(TestMessage);
            mockLoggerFactory.Object.Error(TestException);
            mockLoggerFactory.Object.Error(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Error(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsCritical_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Critical<CustomLoggersShould>(TestMessage);
            mockLoggerFactory.Object.Critical<CustomLoggersShould>(TestException);
            mockLoggerFactory.Object.Critical<CustomLoggersShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggersShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggersShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<CustomLoggersShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsCritical_OncePerMethodOverload_WithoutSourceClass()
        {
            mockLoggerFactory.Object.Critical(TestMessage);
            mockLoggerFactory.Object.Critical(TestException);
            mockLoggerFactory.Object.Critical(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Critical(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical(TestMessage, TestException), Times.Once);
        }
    }
}