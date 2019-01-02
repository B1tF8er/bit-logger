namespace Bit.Logger.Tests
{
    using Contract;
    using Moq;
    using System.Collections.Generic;
    using Xunit;
    using static Constants;

    public class CustomLoggersShould
    {
        private readonly Mock<ILoggerFactory> sut;

        public CustomLoggersShould()
        {
            sut = new Mock<ILoggerFactory>(MockBehavior.Strict);

            sut
                .SetupCallsWithSource<CustomLoggersShould>()
                .SetupCallsWithoutSource()
                .Setup(l => l.AddSources(It.IsAny<IEnumerable<ILogger>>()))
                .Returns(sut.Object);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Trace<CustomLoggersShould>(TestMessage);
            sut.Object.Trace<CustomLoggersShould>(TestException);
            sut.Object.Trace<CustomLoggersShould>(TestMessage, TestException);

            sut.Verify(l => l.Trace<CustomLoggersShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Trace<CustomLoggersShould>(TestException), Times.Once);
            sut.Verify(l => l.Trace<CustomLoggersShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Debug<CustomLoggersShould>(TestMessage);
            sut.Object.Debug<CustomLoggersShould>(TestException);
            sut.Object.Debug<CustomLoggersShould>(TestMessage, TestException);

            sut.Verify(l => l.Debug<CustomLoggersShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Debug<CustomLoggersShould>(TestException), Times.Once);
            sut.Verify(l => l.Debug<CustomLoggersShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Verbose<CustomLoggersShould>(TestMessage);
            sut.Object.Verbose<CustomLoggersShould>(TestException);
            sut.Object.Verbose<CustomLoggersShould>(TestMessage, TestException);

            sut.Verify(l => l.Verbose<CustomLoggersShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Verbose<CustomLoggersShould>(TestException), Times.Once);
            sut.Verify(l => l.Verbose<CustomLoggersShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Information<CustomLoggersShould>(TestMessage);
            sut.Object.Information<CustomLoggersShould>(TestException);
            sut.Object.Information<CustomLoggersShould>(TestMessage, TestException);

            sut.Verify(l => l.Information<CustomLoggersShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Information<CustomLoggersShould>(TestException), Times.Once);
            sut.Verify(l => l.Information<CustomLoggersShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Warning<CustomLoggersShould>(TestMessage);
            sut.Object.Warning<CustomLoggersShould>(TestException);
            sut.Object.Warning<CustomLoggersShould>(TestMessage, TestException);

            sut.Verify(l => l.Warning<CustomLoggersShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Warning<CustomLoggersShould>(TestException), Times.Once);
            sut.Verify(l => l.Warning<CustomLoggersShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Error<CustomLoggersShould>(TestMessage);
            sut.Object.Error<CustomLoggersShould>(TestException);
            sut.Object.Error<CustomLoggersShould>(TestMessage, TestException);

            sut.Verify(l => l.Error<CustomLoggersShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Error<CustomLoggersShould>(TestException), Times.Once);
            sut.Verify(l => l.Error<CustomLoggersShould>(TestMessage, TestException), Times.Once);
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
            sut.Object.Critical<CustomLoggersShould>(TestMessage);
            sut.Object.Critical<CustomLoggersShould>(TestException);
            sut.Object.Critical<CustomLoggersShould>(TestMessage, TestException);

            sut.Verify(l => l.Critical<CustomLoggersShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Critical<CustomLoggersShould>(TestException), Times.Once);
            sut.Verify(l => l.Critical<CustomLoggersShould>(TestMessage, TestException), Times.Once);
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