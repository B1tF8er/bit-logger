namespace Bit.Logger.Loggers.Arguments
{
    using Enums;
    using System;

    internal partial class LogArguments
    {
        internal Level Level { get; private set; }

        internal string ClassName { get; private set; }

        internal string MethodName { get; private set; }

        internal string Message { get; private set; } = default(string);

        internal Exception Exception { get; private set; } = default(Exception);

        internal LogArguments(Level level, string className, string methodName, string message)
        {
            Level = level;
            ClassName = className;
            MethodName = methodName;
            Message = message;
        }

        internal LogArguments(Level level, string className, string methodName, Exception exception)
        {
            Level = level;
            ClassName = className;
            MethodName = methodName;
            Exception = exception;
        }

        internal LogArguments(Level level, string className, string methodName, string message, Exception exception)
        {
            Level = level;
            ClassName = className;
            MethodName = methodName;
            Message = message;
            Exception = exception;
        }
    }
}