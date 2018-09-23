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

        public DatabaseLoggerShould()
        {
            mockLoggerFactory = new Mock<ILoggerFactory>(MockBehavior.Strict);

            mockLoggerFactory
                .SetupCallsWithSource<DatabaseLoggerShould>(TestMessage, TestException)
                .SetupCallsWithoutSource(TestMessage, TestException)
                .Setup(loggerFactory => loggerFactory.AddDatabaseSource(It.IsAny<Configuration>()))
                .Returns(mockLoggerFactory.Object);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Trace<DatabaseLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Trace<DatabaseLoggerShould>(TestException);
            mockLoggerFactory.Object.Trace<DatabaseLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Trace<DatabaseLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<DatabaseLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Debug<DatabaseLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Debug<DatabaseLoggerShould>(TestException);
            mockLoggerFactory.Object.Debug<DatabaseLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Debug<DatabaseLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<DatabaseLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Verbose<DatabaseLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Verbose<DatabaseLoggerShould>(TestException);
            mockLoggerFactory.Object.Verbose<DatabaseLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Verbose<DatabaseLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<DatabaseLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Information<DatabaseLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Information<DatabaseLoggerShould>(TestException);
            mockLoggerFactory.Object.Information<DatabaseLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Information<DatabaseLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<DatabaseLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Warning<DatabaseLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Warning<DatabaseLoggerShould>(TestException);
            mockLoggerFactory.Object.Warning<DatabaseLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Warning<DatabaseLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<DatabaseLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Error<DatabaseLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Error<DatabaseLoggerShould>(TestException);
            mockLoggerFactory.Object.Error<DatabaseLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Error<DatabaseLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<DatabaseLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Critical<DatabaseLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Critical<DatabaseLoggerShould>(TestException);
            mockLoggerFactory.Object.Critical<DatabaseLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Critical<DatabaseLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<DatabaseLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);
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
