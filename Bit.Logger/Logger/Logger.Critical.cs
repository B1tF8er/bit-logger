namespace Bit.Logger
{
    using System;
    using System.Runtime.CompilerServices;
    using static Helpers.Constants.Caller;

    public partial class Logger
    {
        public void Critical(string message, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Sources.ForEach(source => source.Critical(message, className, methodName));

        public void Critical(Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Sources.ForEach(source => source.Critical(exception, className, methodName));

        public void Critical(string message, Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Sources.ForEach(source => source.Critical(message, exception, className, methodName));
    }
}
