namespace Bit.Logger.Contract
{
    using System;
    using System.Runtime.CompilerServices;
    using static Helpers.Constants.Caller;

    public partial interface ISource
    {
        void Warning(string message, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName);

        void Warning(Exception exception, string className = EmptyClassName, string methodName = EmptyMethodName);

        void Warning(string message, Exception exception, string className = EmptyClassName, string methodName = EmptyMethodName);
    }
}
