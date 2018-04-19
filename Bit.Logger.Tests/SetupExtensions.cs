namespace Bit.Logger.Tests
{
    using Moq;
    using System;

    internal static class SetupExtensions
    {
        internal static Mock<ILogger> SetupCallsWithSource<TCLass>(this Mock<ILogger> mockLogger, string message, Exception exception) where TCLass : class
        {
            mockLogger.Setup(l => l.Trace<TCLass>(message));
            mockLogger.Setup(l => l.Trace<TCLass>(exception));
            mockLogger.Setup(l => l.Trace<TCLass>(message, exception));

            mockLogger.Setup(l => l.Debug<TCLass>(message));
            mockLogger.Setup(l => l.Debug<TCLass>(exception));
            mockLogger.Setup(l => l.Debug<TCLass>(message, exception));

            mockLogger.Setup(l => l.Verbose<TCLass>(message));
            mockLogger.Setup(l => l.Verbose<TCLass>(exception));
            mockLogger.Setup(l => l.Verbose<TCLass>(message, exception));

            mockLogger.Setup(l => l.Information<TCLass>(message));
            mockLogger.Setup(l => l.Information<TCLass>(exception));
            mockLogger.Setup(l => l.Information<TCLass>(message, exception));

            mockLogger.Setup(l => l.Warning<TCLass>(message));
            mockLogger.Setup(l => l.Warning<TCLass>(exception));
            mockLogger.Setup(l => l.Warning<TCLass>(message, exception));

            mockLogger.Setup(l => l.Error<TCLass>(message));
            mockLogger.Setup(l => l.Error<TCLass>(exception));
            mockLogger.Setup(l => l.Error<TCLass>(message, exception));

            mockLogger.Setup(l => l.Critical<TCLass>(message));
            mockLogger.Setup(l => l.Critical<TCLass>(exception));
            mockLogger.Setup(l => l.Critical<TCLass>(message, exception));

            return mockLogger;
        }

        internal static Mock<ILogger> SetupCallsWithoutSource(this Mock<ILogger> mockLogger, string message, Exception exception)
        {
            mockLogger.Setup(l => l.Trace(message));
            mockLogger.Setup(l => l.Trace(exception));
            mockLogger.Setup(l => l.Trace(message, exception));

            mockLogger.Setup(l => l.Debug(message));
            mockLogger.Setup(l => l.Debug(exception));
            mockLogger.Setup(l => l.Debug(message, exception));

            mockLogger.Setup(l => l.Verbose(message));
            mockLogger.Setup(l => l.Verbose(exception));
            mockLogger.Setup(l => l.Verbose(message, exception));

            mockLogger.Setup(l => l.Information(message));
            mockLogger.Setup(l => l.Information(exception));
            mockLogger.Setup(l => l.Information(message, exception));

            mockLogger.Setup(l => l.Warning(message));
            mockLogger.Setup(l => l.Warning(exception));
            mockLogger.Setup(l => l.Warning(message, exception));

            mockLogger.Setup(l => l.Error(message));
            mockLogger.Setup(l => l.Error(exception));
            mockLogger.Setup(l => l.Error(message, exception));

            mockLogger.Setup(l => l.Critical(message));
            mockLogger.Setup(l => l.Critical(exception));
            mockLogger.Setup(l => l.Critical(message, exception));

            return mockLogger;
        }
    }
}