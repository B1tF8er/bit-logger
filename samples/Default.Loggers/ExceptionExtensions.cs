using System;

namespace Default.Loggers
{
    internal static class ExceptionExtensions
    {
        internal static Exception CreateException(string message) =>
            new Exception(message);
    }
}