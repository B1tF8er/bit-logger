namespace Bit.Logger.Tests
{
    using Moq;
    using Xunit;
    using static Constants;

    public class CustomLoggerShould
    {
        private readonly Mock<ILoggerFactory> sut;

        public CustomLoggerShould()
        {
            sut = new Mock<ILoggerFactory>(MockBehavior.Strict);

            sut
                .SetupCallsWithSource<CustomLoggerShould>()
                .SetupCallsWithoutSource()
                .Setup(l => l.AddSource(It.IsAny<ILogger>()))
                .Returns(sut.Object);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Trace<CustomLoggerShould>(TestMessage);
            sut.Object.Trace<CustomLoggerShould>(TestException);
            sut.Object.Trace<CustomLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Trace<CustomLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Trace<CustomLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Trace<CustomLoggerShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Debug<CustomLoggerShould>(TestMessage);
            sut.Object.Debug<CustomLoggerShould>(TestException);
            sut.Object.Debug<CustomLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Debug<CustomLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Debug<CustomLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Debug<CustomLoggerShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Verbose<CustomLoggerShould>(TestMessage);
            sut.Object.Verbose<CustomLoggerShould>(TestException);
            sut.Object.Verbose<CustomLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Verbose<CustomLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Verbose<CustomLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Verbose<CustomLoggerShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Information<CustomLoggerShould>(TestMessage);
            sut.Object.Information<CustomLoggerShould>(TestException);
            sut.Object.Information<CustomLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Information<CustomLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Information<CustomLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Information<CustomLoggerShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Warning<CustomLoggerShould>(TestMessage);
            sut.Object.Warning<CustomLoggerShould>(TestException);
            sut.Object.Warning<CustomLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Warning<CustomLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Warning<CustomLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Warning<CustomLoggerShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Error<CustomLoggerShould>(TestMessage);
            sut.Object.Error<CustomLoggerShould>(TestException);
            sut.Object.Error<CustomLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Error<CustomLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Error<CustomLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Error<CustomLoggerShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Critical<CustomLoggerShould>(TestMessage);
            sut.Object.Critical<CustomLoggerShould>(TestException);
            sut.Object.Critical<CustomLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Critical<CustomLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Critical<CustomLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Critical<CustomLoggerShould>(TestMessage, TestException), Times.Once);
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