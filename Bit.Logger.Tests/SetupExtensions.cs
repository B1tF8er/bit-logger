namespace Bit.Logger.Tests
{
    using Moq;
    using System;

    internal static class SetupExtensions
    {
        internal static Mock<ILoggerFactoty> SetupCallsWithSource<TCLass>(this Mock<ILoggerFactoty> mockLoggerFactoty, string message, Exception exception) where TCLass : class
        {
            mockLoggerFactoty.Setup(l => l.Trace<TCLass>(message));
            mockLoggerFactoty.Setup(l => l.Trace<TCLass>(exception));
            mockLoggerFactoty.Setup(l => l.Trace<TCLass>(message, exception));

            mockLoggerFactoty.Setup(l => l.Debug<TCLass>(message));
            mockLoggerFactoty.Setup(l => l.Debug<TCLass>(exception));
            mockLoggerFactoty.Setup(l => l.Debug<TCLass>(message, exception));

            mockLoggerFactoty.Setup(l => l.Verbose<TCLass>(message));
            mockLoggerFactoty.Setup(l => l.Verbose<TCLass>(exception));
            mockLoggerFactoty.Setup(l => l.Verbose<TCLass>(message, exception));

            mockLoggerFactoty.Setup(l => l.Information<TCLass>(message));
            mockLoggerFactoty.Setup(l => l.Information<TCLass>(exception));
            mockLoggerFactoty.Setup(l => l.Information<TCLass>(message, exception));

            mockLoggerFactoty.Setup(l => l.Warning<TCLass>(message));
            mockLoggerFactoty.Setup(l => l.Warning<TCLass>(exception));
            mockLoggerFactoty.Setup(l => l.Warning<TCLass>(message, exception));

            mockLoggerFactoty.Setup(l => l.Error<TCLass>(message));
            mockLoggerFactoty.Setup(l => l.Error<TCLass>(exception));
            mockLoggerFactoty.Setup(l => l.Error<TCLass>(message, exception));

            mockLoggerFactoty.Setup(l => l.Critical<TCLass>(message));
            mockLoggerFactoty.Setup(l => l.Critical<TCLass>(exception));
            mockLoggerFactoty.Setup(l => l.Critical<TCLass>(message, exception));

            return mockLoggerFactoty;
        }

        internal static Mock<ILoggerFactoty> SetupCallsWithoutSource(this Mock<ILoggerFactoty> mockLoggerFactoty, string message, Exception exception)
        {
            mockLoggerFactoty.Setup(l => l.Trace(message));
            mockLoggerFactoty.Setup(l => l.Trace(exception));
            mockLoggerFactoty.Setup(l => l.Trace(message, exception));

            mockLoggerFactoty.Setup(l => l.Debug(message));
            mockLoggerFactoty.Setup(l => l.Debug(exception));
            mockLoggerFactoty.Setup(l => l.Debug(message, exception));

            mockLoggerFactoty.Setup(l => l.Verbose(message));
            mockLoggerFactoty.Setup(l => l.Verbose(exception));
            mockLoggerFactoty.Setup(l => l.Verbose(message, exception));

            mockLoggerFactoty.Setup(l => l.Information(message));
            mockLoggerFactoty.Setup(l => l.Information(exception));
            mockLoggerFactoty.Setup(l => l.Information(message, exception));

            mockLoggerFactoty.Setup(l => l.Warning(message));
            mockLoggerFactoty.Setup(l => l.Warning(exception));
            mockLoggerFactoty.Setup(l => l.Warning(message, exception));

            mockLoggerFactoty.Setup(l => l.Error(message));
            mockLoggerFactoty.Setup(l => l.Error(exception));
            mockLoggerFactoty.Setup(l => l.Error(message, exception));

            mockLoggerFactoty.Setup(l => l.Critical(message));
            mockLoggerFactoty.Setup(l => l.Critical(exception));
            mockLoggerFactoty.Setup(l => l.Critical(message, exception));

            return mockLoggerFactoty;
        }
    }
}