namespace Bit.Logger.Contract
{
    using System;
    using static Helpers.Constants.Caller;

    public partial interface ILogger
    {
        void Error(string message, string className = EmptyClassName, string methodName = EmptyMethodName);

        void Error(Exception exception, string className = EmptyClassName, string methodName = EmptyMethodName);

        void Error(string message, Exception exception, string className = EmptyClassName, string methodName = EmptyMethodName);
    }
}
