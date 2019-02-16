namespace Bit.Logger.Contract
{
    using System;
    using static Helpers.Constants.Caller;

    public partial interface ILogger
    {
        void Critical(string message, string className = EmptyClassName, string methodName = EmptyMethodName);

        void Critical(Exception exception, string className = EmptyClassName, string methodName = EmptyMethodName);

        void Critical(string message, Exception exception, string className = EmptyClassName, string methodName = EmptyMethodName);
    }    
}
