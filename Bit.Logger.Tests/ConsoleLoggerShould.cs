namespace Bit.Logger.Tests
{
    using Config;
    using Factory;
    using Moq;
    using Xunit;
    using static Constants;

    public class ConsoleLoggerShould
    {
        private readonly Mock<ILoggerFactory> sut;

        public ConsoleLoggerShould()
        {
            sut = new Mock<ILoggerFactory>(MockBehavior.Strict);

            sut
                .SetupCallsWithSource<ConsoleLoggerShould>()
                .SetupCallsWithoutSource()
                .Setup(l => l.AddConsoleSource(It.IsAny<Configuration>()))
                .Returns(sut.Object);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Trace<ConsoleLoggerShould>(TestMessage);
            sut.Object.Trace<ConsoleLoggerShould>(TestException);
            sut.Object.Trace<ConsoleLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Trace<ConsoleLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Trace<ConsoleLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Trace<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Debug<ConsoleLoggerShould>(TestMessage);
            sut.Object.Debug<ConsoleLoggerShould>(TestException);
            sut.Object.Debug<ConsoleLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Debug<ConsoleLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Debug<ConsoleLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Debug<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Verbose<ConsoleLoggerShould>(TestMessage);
            sut.Object.Verbose<ConsoleLoggerShould>(TestException);
            sut.Object.Verbose<ConsoleLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Verbose<ConsoleLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Verbose<ConsoleLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Verbose<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Information<ConsoleLoggerShould>(TestMessage);
            sut.Object.Information<ConsoleLoggerShould>(TestException);
            sut.Object.Information<ConsoleLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Information<ConsoleLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Information<ConsoleLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Information<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Warning<ConsoleLoggerShould>(TestMessage);
            sut.Object.Warning<ConsoleLoggerShould>(TestException);
            sut.Object.Warning<ConsoleLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Warning<ConsoleLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Warning<ConsoleLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Warning<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Error<ConsoleLoggerShould>(TestMessage);
            sut.Object.Error<ConsoleLoggerShould>(TestException);
            sut.Object.Error<ConsoleLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Error<ConsoleLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Error<ConsoleLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Error<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Critical<ConsoleLoggerShould>(TestMessage);
            sut.Object.Critical<ConsoleLoggerShould>(TestException);
            sut.Object.Critical<ConsoleLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Critical<ConsoleLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Critical<ConsoleLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Critical<ConsoleLoggerShould>(TestMessage, TestException), Times.Once);
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
