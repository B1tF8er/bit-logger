namespace Bit.Logger.Loggers.Arguments
{
    using Enums;
    using System;

    internal partial struct LogArguments
    {
        internal Level Level { get; private set; }
        internal string ClassName { get; private set; }
        internal string MethodName { get; private set; }
        internal string Message { get; private set; }
        internal Exception Exception { get; private set; }

        internal LogArguments(Level level, string className, string methodName, string message)
        {
            Level = level;
            ClassName = className;
            MethodName = methodName;
            Message = message;
            Exception = null;
        }

        internal LogArguments(Level level, string className, string methodName, Exception exception)
        {
            Level = level;
            ClassName = className;
            MethodName = methodName;
            Message = null;
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