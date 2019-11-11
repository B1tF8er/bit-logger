namespace Bit.Logger.Tests
{
    using Config;
    using Contract;
    using Moq;
    using Xunit;
    using static Constants;

    public class ConsoleSourceShould
    {
        private readonly Mock<ILogger> sut;

        public ConsoleSourceShould()
        {
            sut = new Mock<ILogger>(MockBehavior.Strict);

            sut.SetupCalls()
                .Setup(logger => logger.AddConsoleSource(It.IsAny<Configuration>()));
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload()
        {
            sut.Object.Trace(TestMessage);
            sut.Object.Trace(TestException);
            sut.Object.Trace(TestMessage, TestException);

            sut.Verify(logger => logger.Trace(TestMessage, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(logger => logger.Trace(TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(logger => logger.Trace(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void LogMessage_AsDebug_OncePerMethodOverload()
        {
            sut.Object.Debug(TestMessage);
            sut.Object.Debug(TestException);
            sut.Object.Debug(TestMessage, TestException);

            sut.Verify(logger => logger.Debug(TestMessage, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(logger => logger.Debug(TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(logger => logger.Debug(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void LogMessage_AsVerbose_OncePerMethodOverload()
        {
            sut.Object.Verbose(TestMessage);
            sut.Object.Verbose(TestException);
            sut.Object.Verbose(TestMessage, TestException);

            sut.Verify(logger => logger.Verbose(TestMessage, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(logger => logger.Verbose(TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(logger => logger.Verbose(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void LogMessage_AsInformation_OncePerMethodOverload()
        {
            sut.Object.Information(TestMessage);
            sut.Object.Information(TestException);
            sut.Object.Information(TestMessage, TestException);

            sut.Verify(logger => logger.Information(TestMessage, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(logger => logger.Information(TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(logger => logger.Information(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void LogMessage_AsWarning_OncePerMethodOverload()
        {
            sut.Object.Warning(TestMessage);
            sut.Object.Warning(TestException);
            sut.Object.Warning(TestMessage, TestException);

            sut.Verify(logger => logger.Warning(TestMessage, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(logger => logger.Warning(TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(logger => logger.Warning(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void LogMessage_AsError_OncePerMethodOverload()
        {
            sut.Object.Error(TestMessage);
            sut.Object.Error(TestException);
            sut.Object.Error(TestMessage, TestException);

            sut.Verify(logger => logger.Error(TestMessage, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(logger => logger.Error(TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(logger => logger.Error(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void LogMessage_AsCritical_OncePerMethodOverload()
        {
            sut.Object.Critical(TestMessage);
            sut.Object.Critical(TestException);
            sut.Object.Critical(TestMessage, TestException);

            sut.Verify(logger => logger.Critical(TestMessage, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(logger => logger.Critical(TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            sut.Verify(logger => logger.Critical(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }
    }
}
