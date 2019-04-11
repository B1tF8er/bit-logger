namespace Default.Loggers
{
    using System;

    internal static class TryCatchExtensions
    {
        internal static void TryCatch(Action @try, Action<Exception> @catch)
        {
            try { @try(); } catch (Exception ex) { @catch(ex); }
        }

        internal static void FailFast(Action @try) =>
            TryCatch(@try, (ex) => Environment.FailFast(ex.Message, ex));
    }
}
