namespace Bit.Logger
{
    using System;
    using System.Runtime.CompilerServices;
    using static Helpers.Constants.Caller;

    public partial class Logger
    {
        public void Verbose(string message, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Sources.ForEach(source => source.Verbose(message, className, methodName));

        public void Verbose(Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Sources.ForEach(source => source.Verbose(exception, className, methodName));

        public void Verbose(string message, Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Sources.ForEach(source => source.Verbose(message, exception, className, methodName));
    }
}
