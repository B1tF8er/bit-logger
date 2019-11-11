namespace Bit.Logger.Tests
{
    using Config;
    using Contract;
    using Moq;
    using Xunit;
    using static Constants;
    using static Expressions;

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

            sut.Verify(TraceMessage, Times.Once);
            sut.Verify(TraceException, Times.Once);
            sut.Verify(TraceMessageAndException, Times.Once);
        }

        [Fact]
        public void LogMessage_AsDebug_OncePerMethodOverload()
        {
            sut.Object.Debug(TestMessage);
            sut.Object.Debug(TestException);
            sut.Object.Debug(TestMessage, TestException);

            sut.Verify(DebugMessage, Times.Once);
            sut.Verify(DebugException, Times.Once);
            sut.Verify(DebugMessageAndException, Times.Once);
        }

        [Fact]
        public void LogMessage_AsVerbose_OncePerMethodOverload()
        {
            sut.Object.Verbose(TestMessage);
            sut.Object.Verbose(TestException);
            sut.Object.Verbose(TestMessage, TestException);

            sut.Verify(VerboseMessage, Times.Once);
            sut.Verify(VerboseException, Times.Once);
            sut.Verify(VerboseMessageAndException, Times.Once);
        }

        [Fact]
        public void LogMessage_AsInformation_OncePerMethodOverload()
        {
            sut.Object.Information(TestMessage);
            sut.Object.Information(TestException);
            sut.Object.Information(TestMessage, TestException);

            sut.Verify(InformationMessage, Times.Once);
            sut.Verify(InformationException, Times.Once);
            sut.Verify(InformationMessageAndException, Times.Once);
        }

        [Fact]
        public void LogMessage_AsWarning_OncePerMethodOverload()
        {
            sut.Object.Warning(TestMessage);
            sut.Object.Warning(TestException);
            sut.Object.Warning(TestMessage, TestException);

            sut.Verify(WarningMessage, Times.Once);
            sut.Verify(WarningException, Times.Once);
            sut.Verify(WarningMessageAndException, Times.Once);
        }

        [Fact]
        public void LogMessage_AsError_OncePerMethodOverload()
        {
            sut.Object.Error(TestMessage);
            sut.Object.Error(TestException);
            sut.Object.Error(TestMessage, TestException);

            sut.Verify(ErrorMessage, Times.Once);
            sut.Verify(ErrorException, Times.Once);
            sut.Verify(ErrorMessageAndException, Times.Once);
        }

        [Fact]
        public void LogMessage_AsCritical_OncePerMethodOverload()
        {
            sut.Object.Critical(TestMessage);
            sut.Object.Critical(TestException);
            sut.Object.Critical(TestMessage, TestException);

            sut.Verify(CriticalMessage, Times.Once);
            sut.Verify(CriticalException, Times.Once);
            sut.Verify(CriticalMessageAndException, Times.Once);
        }
    }
}
