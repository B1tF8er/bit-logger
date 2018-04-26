namespace Bit.Logger.Tests
{
    using Moq;
    using System;

    internal static class SetupExtensions
    {
        internal static Mock<ILoggerFactory> SetupCallsWithSource<TClass>(this Mock<ILoggerFactory> mockLoggerFactoty, string message, Exception exception) 
            where TClass : class
        {
            mockLoggerFactoty.Setup(l => l.Trace<TClass>(message));
            mockLoggerFactoty.Setup(l => l.Trace<TClass>(exception));
            mockLoggerFactoty.Setup(l => l.Trace<TClass>(message, exception));

            mockLoggerFactoty.Setup(l => l.Debug<TClass>(message));
            mockLoggerFactoty.Setup(l => l.Debug<TClass>(exception));
            mockLoggerFactoty.Setup(l => l.Debug<TClass>(message, exception));

            mockLoggerFactoty.Setup(l => l.Verbose<TClass>(message));
            mockLoggerFactoty.Setup(l => l.Verbose<TClass>(exception));
            mockLoggerFactoty.Setup(l => l.Verbose<TClass>(message, exception));

            mockLoggerFactoty.Setup(l => l.Information<TClass>(message));
            mockLoggerFactoty.Setup(l => l.Information<TClass>(exception));
            mockLoggerFactoty.Setup(l => l.Information<TClass>(message, exception));

            mockLoggerFactoty.Setup(l => l.Warning<TClass>(message));
            mockLoggerFactoty.Setup(l => l.Warning<TClass>(exception));
            mockLoggerFactoty.Setup(l => l.Warning<TClass>(message, exception));

            mockLoggerFactoty.Setup(l => l.Error<TClass>(message));
            mockLoggerFactoty.Setup(l => l.Error<TClass>(exception));
            mockLoggerFactoty.Setup(l => l.Error<TClass>(message, exception));

            mockLoggerFactoty.Setup(l => l.Critical<TClass>(message));
            mockLoggerFactoty.Setup(l => l.Critical<TClass>(exception));
            mockLoggerFactoty.Setup(l => l.Critical<TClass>(message, exception));

            return mockLoggerFactoty;
        }

        internal static Mock<ILoggerFactory> SetupCallsWithoutSource(this Mock<ILoggerFactory> mockLoggerFactoty, string message, Exception exception)
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