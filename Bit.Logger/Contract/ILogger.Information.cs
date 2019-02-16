namespace Bit.Logger.Contract
{
    using System;
    using static Helpers.Constants.Caller;

    public partial interface ILogger
    {
        void Information(string message, string className = EmptyClassName, string methodName = EmptyMethodName);

        void Information(Exception exception, string className = EmptyClassName, string methodName = EmptyMethodName);

        void Information(string message, Exception exception, string className = EmptyClassName, string methodName = EmptyMethodName);
    }
}
