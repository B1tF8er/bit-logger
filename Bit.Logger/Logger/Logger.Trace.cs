namespace Bit.Logger
{
    using System;
    using System.Runtime.CompilerServices;
    using static Helpers.Constants.Caller;

    public partial class Logger
    {
        public void Trace(string message, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Sources.ForEach(source => source.Trace(message, className, methodName));

        public void Trace(Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Sources.ForEach(source => source.Trace(exception, className, methodName));

        public void Trace(string message, Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Sources.ForEach(source => source.Trace(message, exception, className, methodName));
    }
}
