namespace Bit.Logger.Contract
{
    using System;
    using System.Runtime.CompilerServices;
    using static Helpers.Constants.Caller;
    
    public partial interface ISource
    {
        void Debug(string message, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName);

        void Debug(Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName);

        void Debug(string message, Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName);
    }    
}
