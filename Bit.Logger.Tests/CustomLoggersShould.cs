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

            sut.SetupCalls()
                .Setup(l => l.AddSources(It.IsAny<IEnumerable<ILogger>>()))
                .Returns(sut.Object);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload()
        {
            sut.Object.Trace(TestMessage);
            sut.Object.Trace(TestException);
            sut.Object.Trace(TestMessage, TestException);

            sut.Verify(l => l.Trace(TestMessage, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(l => l.Trace(TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(l => l.Trace(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void LogMessage_AsDebug_OncePerMethodOverload()
        {
            sut.Object.Debug(TestMessage);
            sut.Object.Debug(TestException);
            sut.Object.Debug(TestMessage, TestException);

            sut.Verify(l => l.Debug(TestMessage, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(l => l.Debug(TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(l => l.Debug(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void LogMessage_AsVerbose_OncePerMethodOverload()
        {
            sut.Object.Verbose(TestMessage);
            sut.Object.Verbose(TestException);
            sut.Object.Verbose(TestMessage, TestException);

            sut.Verify(l => l.Verbose(TestMessage, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(l => l.Verbose(TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(l => l.Verbose(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void LogMessage_AsInformation_OncePerMethodOverload()
        {
            sut.Object.Information(TestMessage);
            sut.Object.Information(TestException);
            sut.Object.Information(TestMessage, TestException);

            sut.Verify(l => l.Information(TestMessage, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(l => l.Information(TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(l => l.Information(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void LogMessage_AsWarning_OncePerMethodOverload()
        {
            sut.Object.Warning(TestMessage);
            sut.Object.Warning(TestException);
            sut.Object.Warning(TestMessage, TestException);

            sut.Verify(l => l.Warning(TestMessage, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(l => l.Warning(TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(l => l.Warning(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void LogMessage_AsError_OncePerMethodOverload()
        {
            sut.Object.Error(TestMessage);
            sut.Object.Error(TestException);
            sut.Object.Error(TestMessage, TestException);

            sut.Verify(l => l.Error(TestMessage, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(l => l.Error(TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(l => l.Error(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void LogMessage_AsCritical_OncePerMethodOverload()
        {
            sut.Object.Critical(TestMessage);
            sut.Object.Critical(TestException);
            sut.Object.Critical(TestMessage, TestException);

            sut.Verify(l => l.Critical(TestMessage, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(l => l.Critical(TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(l => l.Critical(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }
    }
}
