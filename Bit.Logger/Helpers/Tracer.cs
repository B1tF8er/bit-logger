namespace Bit.Logger.Helpers
{
    using System;
    using System.Diagnostics;

    internal static class Tracer
    {
        internal static Type GetClass() =>
            GetStackFrame().GetType();

        internal static string GetMethodName() =>
            GetStackFrame().GetMethod().Name;

        private static StackFrame GetStackFrame()
        {
            var stackTrace = new StackTrace();
            var stackFrame = stackTrace.GetFrame(7);
            return stackFrame;
        }
    }
}
