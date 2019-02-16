namespace Bit.Logger.Contract
{
    using System;
    using static Helpers.Constants.Caller;
    
    public partial interface ILogger
    {
        void Debug(string message, string className = EmptyClassName, string methodName = EmptyMethodName);

        void Debug(Exception exception, string className = EmptyClassName, string methodName = EmptyMethodName);

        void Debug(string message, Exception exception, string className = EmptyClassName, string methodName = EmptyMethodName);
    }    
}
