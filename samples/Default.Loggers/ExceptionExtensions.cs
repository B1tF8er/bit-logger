namespace Default.Loggers
{
    using System;

    internal static class ExceptionExtensions
    {
        internal static Exception CreateException(this string message) =>
            new Exception(message);
    }
}
