namespace Bit.Logger.Tests
{
    using Factory;
    using Moq;
    using static Constants;

    internal static class LoggerFactoryExtensions
    {
        internal static void LogAllLevelsWithoutClass(this Mock<LoggerFactory> sut)
        {
            sut.Object.Trace(TestMessage);
            sut.Object.Trace(TestException);
            sut.Object.Trace(TestMessage, TestException);

            sut.Object.Debug(TestMessage);
            sut.Object.Debug(TestException);
            sut.Object.Debug(TestMessage, TestException);

            sut.Object.Verbose(TestMessage);
            sut.Object.Verbose(TestException);
            sut.Object.Verbose(TestMessage, TestException);

            sut.Object.Information(TestMessage);
            sut.Object.Information(TestException);
            sut.Object.Information(TestMessage, TestException);
            
            sut.Object.Warning(TestMessage);
            sut.Object.Warning(TestException);
            sut.Object.Warning(TestMessage, TestException);

            sut.Object.Error(TestMessage);
            sut.Object.Error(TestException);
            sut.Object.Error(TestMessage, TestException);
            
            sut.Object.Critical(TestMessage);
            sut.Object.Critical(TestException);
            sut.Object.Critical(TestMessage, TestException);
        }

        internal static void LogAllLevelsWithClass<TClass>(this IMock<LoggerFactory> sut)
            where TClass : class
        {
            sut.Object.Trace<TClass>(TestMessage);
            sut.Object.Trace<TClass>(TestException);
            sut.Object.Trace<TClass>(TestMessage, TestException);

            sut.Object.Debug<TClass>(TestMessage);
            sut.Object.Debug<TClass>(TestException);
            sut.Object.Debug<TClass>(TestMessage, TestException);

            sut.Object.Verbose<TClass>(TestMessage);
            sut.Object.Verbose<TClass>(TestException);
            sut.Object.Verbose<TClass>(TestMessage, TestException);

            sut.Object.Information<TClass>(TestMessage);
            sut.Object.Information<TClass>(TestException);
            sut.Object.Information<TClass>(TestMessage, TestException);
            
            sut.Object.Warning<TClass>(TestMessage);
            sut.Object.Warning<TClass>(TestException);
            sut.Object.Warning<TClass>(TestMessage, TestException);

            sut.Object.Error<TClass>(TestMessage);
            sut.Object.Error<TClass>(TestException);
            sut.Object.Error<TClass>(TestMessage, TestException);
            
            sut.Object.Critical<TClass>(TestMessage);
            sut.Object.Critical<TClass>(TestException);
            sut.Object.Critical<TClass>(TestMessage, TestException);
        }
    }
}
