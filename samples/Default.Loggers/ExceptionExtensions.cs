namespace Default.Loggers
{
    using System;

    internal static class ExceptionExtensions
    {
        internal static Exception CreateException(string message) =>
            new Exception(message);
    }
}