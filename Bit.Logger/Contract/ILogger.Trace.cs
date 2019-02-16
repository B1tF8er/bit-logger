namespace Bit.Logger.Contract
{
    using System;
    using static Helpers.Constants.Caller;
    
    public partial interface ILogger
    {
        void Trace(string message, string className = EmptyClassName, string methodName = EmptyMethodName);

        void Trace(Exception exception, string className = EmptyClassName, string methodName = EmptyMethodName);

        void Trace(string message, Exception exception, string className = EmptyClassName, string methodName = EmptyMethodName);
    }    
}
