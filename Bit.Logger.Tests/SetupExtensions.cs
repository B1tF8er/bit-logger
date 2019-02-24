namespace Bit.Logger.Tests
{
    using Contract;
    using Moq;
    using static Constants;

    internal static class SetupExtensions
    {
        internal static Mock<ILogger> SetupCalls(this Mock<ILogger> sut)
        {
            sut.Setup(l => l.Trace(TestMessage, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(l => l.Trace(TestException, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(l => l.Trace(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()));

            sut.Setup(l => l.Debug(TestMessage, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(l => l.Debug(TestException, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(l => l.Debug(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()));

            sut.Setup(l => l.Verbose(TestMessage, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(l => l.Verbose(TestException, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(l => l.Verbose(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()));

            sut.Setup(l => l.Information(TestMessage, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(l => l.Information(TestException, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(l => l.Information(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()));

            sut.Setup(l => l.Warning(TestMessage, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(l => l.Warning(TestException, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(l => l.Warning(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()));

            sut.Setup(l => l.Error(TestMessage, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(l => l.Error(TestException, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(l => l.Error(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()));

            sut.Setup(l => l.Critical(TestMessage, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(l => l.Critical(TestException, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(l => l.Critical(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()));

            return sut;
        }
    }
}
