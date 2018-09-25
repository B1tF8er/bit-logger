namespace Bit.Logger.Tests
{
    using Config;
    using Moq;
    using System;
    using Xunit;
    using static Constants;

    public class FileLoggerShould
    {
        private readonly Mock<ILoggerFactory> mockLoggerFactory;

        public FileLoggerShould()
        {
            mockLoggerFactory = new Mock<ILoggerFactory>(MockBehavior.Strict);

            mockLoggerFactory
                .SetupCallsWithSource<FileLoggerShould>(TestMessage, TestException)
                .SetupCallsWithoutSource(TestMessage, TestException)
                .Setup(loggerFactory => loggerFactory.AddFileSource(It.IsAny<Configuration>()))
                .Returns(mockLoggerFactory.Object);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload_WithSourceClass()
        {
            mockLoggerFactory.Object.Trace<FileLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Trace<FileLoggerShould>(TestException);
            mockLoggerFactory.Object.Trace<FileLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Trace<FileLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<FileLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Trace<FileLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Debug<FileLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Debug<FileLoggerShould>(TestException);
            mockLoggerFactory.Object.Debug<FileLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Debug<FileLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<FileLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Debug<FileLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Verbose<FileLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Verbose<FileLoggerShould>(TestException);
            mockLoggerFactory.Object.Verbose<FileLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Verbose<FileLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<FileLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Verbose<FileLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Information<FileLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Information<FileLoggerShould>(TestException);
            mockLoggerFactory.Object.Information<FileLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Information<FileLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<FileLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Information<FileLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Warning<FileLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Warning<FileLoggerShould>(TestException);
            mockLoggerFactory.Object.Warning<FileLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Warning<FileLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<FileLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Warning<FileLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Error<FileLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Error<FileLoggerShould>(TestException);
            mockLoggerFactory.Object.Error<FileLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Error<FileLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<FileLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Error<FileLoggerShould>(TestMessage, TestException), Times.Once);
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
            mockLoggerFactory.Object.Critical<FileLoggerShould>(TestMessage);
            mockLoggerFactory.Object.Critical<FileLoggerShould>(TestException);
            mockLoggerFactory.Object.Critical<FileLoggerShould>(TestMessage, TestException);

            mockLoggerFactory.Verify(logger => logger.Critical<FileLoggerShould>(TestMessage), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<FileLoggerShould>(TestException), Times.Once);
            mockLoggerFactory.Verify(logger => logger.Critical<FileLoggerShould>(TestMessage, TestException), Times.Once);
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
