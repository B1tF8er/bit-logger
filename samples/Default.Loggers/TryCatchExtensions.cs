namespace Default.Loggers
{
    using System;

    internal static class TryCatchExtensions
    {
        internal static void TryCatch(this Action @try, Action<Exception> @catch)
        {
            try { @try(); } catch (Exception ex) { @catch(ex); }
        }

        internal static void TryOrFailFast(this Action @try) =>
            @try.TryCatch((ex) => Environment.FailFast(ex.Message, ex));
    }
}
