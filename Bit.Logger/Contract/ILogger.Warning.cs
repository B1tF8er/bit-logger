namespace Bit.Logger.Contract
{
    using System;
    using static Helpers.Constants.Caller;

    public partial interface ILogger
    {
        void Warning(string message, string className = EmptyClassName, string methodName = EmptyMethodName);

        void Warning(Exception exception, string className = EmptyClassName, string methodName = EmptyMethodName);

        void Warning(string message, Exception exception, string className = EmptyClassName, string methodName = EmptyMethodName);
    }
}
