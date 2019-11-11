namespace Bit.Logger.Tests
{
    using Contract;
    using Moq;
    using System;
    using System.Linq.Expressions;
    using static Constants;

    internal static class Expressions
    {
        internal static Expression<Action<ILogger>> TraceMessage =>
            logger => logger.Trace(TestMessage, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> TraceException =>
            logger => logger.Trace(TestException, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> TraceMessageAndException =>
            logger => logger.Trace(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> DebugMessage =>
            logger => logger.Debug(TestMessage, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> DebugException =>
            logger => logger.Debug(TestException, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> DebugMessageAndException =>
            logger => logger.Debug(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> VerboseMessage =>
            logger => logger.Verbose(TestMessage, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> VerboseException =>
            logger => logger.Verbose(TestException, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> VerboseMessageAndException =>
            logger => logger.Verbose(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> InformationMessage =>
            logger => logger.Information(TestMessage, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> InformationException =>
            logger => logger.Information(TestException, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> InformationMessageAndException =>
            logger => logger.Information(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> WarningMessage =>
            logger => logger.Warning(TestMessage, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> WarningException =>
            logger => logger.Warning(TestException, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> WarningMessageAndException =>
            logger => logger.Warning(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> ErrorMessage =>
            logger => logger.Error(TestMessage, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> ErrorException =>
            logger => logger.Error(TestException, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> ErrorMessageAndException =>
            logger => logger.Error(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> CriticalMessage =>
            logger => logger.Critical(TestMessage, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> CriticalException =>
            logger => logger.Critical(TestException, It.IsAny<string>(), It.IsAny<string>());

        internal static Expression<Action<ILogger>> CriticalMessageAndException =>
            logger => logger.Critical(TestMessage, TestException, It.IsAny<string>(), It.IsAny<string>());
    }
}
