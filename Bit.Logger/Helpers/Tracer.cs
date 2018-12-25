namespace Bit.Logger.Helpers
{
    using System.Diagnostics;
    using System.Reflection;

    internal static class Tracer
    {
        internal static string GetClassName() =>
            GetMethodBase().DeclaringType.FullName;

        internal static string GetMethodName() =>
            GetMethodBase().Name;

        private static MethodBase GetMethodBase() =>
            GetStackFrame().GetMethod();

        private static StackFrame GetStackFrame()
        {
            var stackTrace = new StackTrace();
            var stackFrame = stackTrace.GetFrame(8);
            return stackFrame;
        }
    }
}
