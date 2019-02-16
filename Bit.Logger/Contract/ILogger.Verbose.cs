namespace Bit.Logger.Contract
{
    using System;
    using static Helpers.Constants.Caller;

    public partial interface ILogger
    {
        void Verbose(string message, string className = EmptyClassName, string methodName = EmptyMethodName);

        void Verbose(Exception exception, string className = EmptyClassName, string methodName = EmptyMethodName);

        void Verbose(string message, Exception exception, string className = EmptyClassName, string methodName = EmptyMethodName);
    }
}
