namespace Bit.Logger
{
    using System;
    using System.Runtime.CompilerServices;
    using static Helpers.Constants.Caller;

    public partial class Logger
    {
        public void Debug(string message, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Sources.ForEach(source => source.Debug(message, className, methodName));

        public void Debug(Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Sources.ForEach(source => source.Debug(exception, className, methodName));

        public void Debug(string message, Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Sources.ForEach(source => source.Debug(message, exception, className, methodName));
    }
}
