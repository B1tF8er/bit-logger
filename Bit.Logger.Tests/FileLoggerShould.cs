namespace Bit.Logger.Tests
{
    using Config;
    using Contract;
    using Moq;
    using Xunit;
    using static Constants;

    public class FileLoggerShould
    {
        private readonly Mock<ILoggerFactory> sut;

        public FileLoggerShould()
        {
            sut = new Mock<ILoggerFactory>(MockBehavior.Strict);

            sut
                .SetupCallsWithSource<FileLoggerShould>()
                .SetupCallsWithoutSource()
                .Setup(l => l.AddFileSource(It.IsAny<Configuration>()))
                .Returns(sut.Object);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Trace<FileLoggerShould>(TestMessage);
            sut.Object.Trace<FileLoggerShould>(TestException);
            sut.Object.Trace<FileLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Trace<FileLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Trace<FileLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Trace<FileLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload_WithoutSourceClass()
        {
            sut.Object.Trace(TestMessage);
            sut.Object.Trace(TestException);
            sut.Object.Trace(TestMessage, TestException);

            sut.Verify(l => l.Trace(TestMessage), Times.Once);
            sut.Verify(l => l.Trace(TestException), Times.Once);
            sut.Verify(l => l.Trace(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsDebug_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Debug<FileLoggerShould>(TestMessage);
            sut.Object.Debug<FileLoggerShould>(TestException);
            sut.Object.Debug<FileLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Debug<FileLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Debug<FileLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Debug<FileLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsDebug_OncePerMethodOverload_WithoutSourceClass()
        {
            sut.Object.Debug(TestMessage);
            sut.Object.Debug(TestException);
            sut.Object.Debug(TestMessage, TestException);

            sut.Verify(l => l.Debug(TestMessage), Times.Once);
            sut.Verify(l => l.Debug(TestException), Times.Once);
            sut.Verify(l => l.Debug(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsVerbose_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Verbose<FileLoggerShould>(TestMessage);
            sut.Object.Verbose<FileLoggerShould>(TestException);
            sut.Object.Verbose<FileLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Verbose<FileLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Verbose<FileLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Verbose<FileLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsVerbose_OncePerMethodOverload_WithoutSourceClass()
        {
            sut.Object.Verbose(TestMessage);
            sut.Object.Verbose(TestException);
            sut.Object.Verbose(TestMessage, TestException);

            sut.Verify(l => l.Verbose(TestMessage), Times.Once);
            sut.Verify(l => l.Verbose(TestException), Times.Once);
            sut.Verify(l => l.Verbose(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsInformation_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Information<FileLoggerShould>(TestMessage);
            sut.Object.Information<FileLoggerShould>(TestException);
            sut.Object.Information<FileLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Information<FileLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Information<FileLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Information<FileLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsInformation_OncePerMethodOverload_WithoutSourceClass()
        {
            sut.Object.Information(TestMessage);
            sut.Object.Information(TestException);
            sut.Object.Information(TestMessage, TestException);

            sut.Verify(l => l.Information(TestMessage), Times.Once);
            sut.Verify(l => l.Information(TestException), Times.Once);
            sut.Verify(l => l.Information(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsWarning_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Warning<FileLoggerShould>(TestMessage);
            sut.Object.Warning<FileLoggerShould>(TestException);
            sut.Object.Warning<FileLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Warning<FileLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Warning<FileLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Warning<FileLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsWarning_OncePerMethodOverload_WithoutSourceClass()
        {
            sut.Object.Warning(TestMessage);
            sut.Object.Warning(TestException);
            sut.Object.Warning(TestMessage, TestException);

            sut.Verify(l => l.Warning(TestMessage), Times.Once);
            sut.Verify(l => l.Warning(TestException), Times.Once);
            sut.Verify(l => l.Warning(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsError_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Error<FileLoggerShould>(TestMessage);
            sut.Object.Error<FileLoggerShould>(TestException);
            sut.Object.Error<FileLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Error<FileLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Error<FileLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Error<FileLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsError_OncePerMethodOverload_WithoutSourceClass()
        {
            sut.Object.Error(TestMessage);
            sut.Object.Error(TestException);
            sut.Object.Error(TestMessage, TestException);

            sut.Verify(l => l.Error(TestMessage), Times.Once);
            sut.Verify(l => l.Error(TestException), Times.Once);
            sut.Verify(l => l.Error(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsCritical_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Critical<FileLoggerShould>(TestMessage);
            sut.Object.Critical<FileLoggerShould>(TestException);
            sut.Object.Critical<FileLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Critical<FileLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Critical<FileLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Critical<FileLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsCritical_OncePerMethodOverload_WithoutSourceClass()
        {
            sut.Object.Critical(TestMessage);
            sut.Object.Critical(TestException);
            sut.Object.Critical(TestMessage, TestException);

            sut.Verify(l => l.Critical(TestMessage), Times.Once);
            sut.Verify(l => l.Critical(TestException), Times.Once);
            sut.Verify(l => l.Critical(TestMessage, TestException), Times.Once);
        }
    }
}
