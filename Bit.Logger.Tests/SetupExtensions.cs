namespace Bit.Logger.Tests
{
    using Factory;
    using Moq;
    using static Constants;

    internal static class SetupExtensions
    {
        internal static Mock<ILoggerFactory> SetupCallsWithSource<TClass>(this Mock<ILoggerFactory> sut) 
            where TClass : class
        {
            sut.Setup(l => l.Trace<TClass>(TestMessage));
            sut.Setup(l => l.Trace<TClass>(TestException));
            sut.Setup(l => l.Trace<TClass>(TestMessage, TestException));

            sut.Setup(l => l.Debug<TClass>(TestMessage));
            sut.Setup(l => l.Debug<TClass>(TestException));
            sut.Setup(l => l.Debug<TClass>(TestMessage, TestException));

            sut.Setup(l => l.Verbose<TClass>(TestMessage));
            sut.Setup(l => l.Verbose<TClass>(TestException));
            sut.Setup(l => l.Verbose<TClass>(TestMessage, TestException));

            sut.Setup(l => l.Information<TClass>(TestMessage));
            sut.Setup(l => l.Information<TClass>(TestException));
            sut.Setup(l => l.Information<TClass>(TestMessage, TestException));

            sut.Setup(l => l.Warning<TClass>(TestMessage));
            sut.Setup(l => l.Warning<TClass>(TestException));
            sut.Setup(l => l.Warning<TClass>(TestMessage, TestException));

            sut.Setup(l => l.Error<TClass>(TestMessage));
            sut.Setup(l => l.Error<TClass>(TestException));
            sut.Setup(l => l.Error<TClass>(TestMessage, TestException));

            sut.Setup(l => l.Critical<TClass>(TestMessage));
            sut.Setup(l => l.Critical<TClass>(TestException));
            sut.Setup(l => l.Critical<TClass>(TestMessage, TestException));

            return sut;
        }

        internal static Mock<ILoggerFactory> SetupCallsWithoutSource(this Mock<ILoggerFactory> sut)
        {
            sut.Setup(l => l.Trace(TestMessage));
            sut.Setup(l => l.Trace(TestException));
            sut.Setup(l => l.Trace(TestMessage, TestException));

            sut.Setup(l => l.Debug(TestMessage));
            sut.Setup(l => l.Debug(TestException));
            sut.Setup(l => l.Debug(TestMessage, TestException));

            sut.Setup(l => l.Verbose(TestMessage));
            sut.Setup(l => l.Verbose(TestException));
            sut.Setup(l => l.Verbose(TestMessage, TestException));

            sut.Setup(l => l.Information(TestMessage));
            sut.Setup(l => l.Information(TestException));
            sut.Setup(l => l.Information(TestMessage, TestException));

            sut.Setup(l => l.Warning(TestMessage));
            sut.Setup(l => l.Warning(TestException));
            sut.Setup(l => l.Warning(TestMessage, TestException));

            sut.Setup(l => l.Error(TestMessage));
            sut.Setup(l => l.Error(TestException));
            sut.Setup(l => l.Error(TestMessage, TestException));

            sut.Setup(l => l.Critical(TestMessage));
            sut.Setup(l => l.Critical(TestException));
            sut.Setup(l => l.Critical(TestMessage, TestException));

            return sut;
        }
    }
}