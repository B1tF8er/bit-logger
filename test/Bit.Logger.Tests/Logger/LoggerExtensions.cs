namespace Bit.Logger.Tests
{
    using Contract;
    using Moq;
    using static Constants;

    internal static class LoggerExtensions
    {
        internal static Mock<ILogger> SetupCalls(this Mock<ILogger> sut)
        {
            sut.Setup(logger => logger.Trace(TestMessage, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(logger => logger.Trace(TestException, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(logger => logger.Trace(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()));

            sut.Setup(logger => logger.Debug(TestMessage, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(logger => logger.Debug(TestException, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(logger => logger.Debug(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()));

            sut.Setup(logger => logger.Verbose(TestMessage, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(logger => logger.Verbose(TestException, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(logger => logger.Verbose(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()));

            sut.Setup(logger => logger.Information(TestMessage, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(logger => logger.Information(TestException, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(logger => logger.Information(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()));

            sut.Setup(logger => logger.Warning(TestMessage, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(logger => logger.Warning(TestException, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(logger => logger.Warning(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()));

            sut.Setup(logger => logger.Error(TestMessage, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(logger => logger.Error(TestException, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(logger => logger.Error(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()));

            sut.Setup(logger => logger.Critical(TestMessage, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(logger => logger.Critical(TestException, It.IsAny<string>(), It.IsAny<string>()));
            sut.Setup(logger => logger.Critical(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>()));

            return sut;
        }

        internal static void LogAllLevels(this Mock<Logger> sut)
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
    }
}
