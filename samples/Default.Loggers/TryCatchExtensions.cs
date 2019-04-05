using System;

namespace Default.Loggers
{
    internal static class TryCatchExtensions
    {
        internal static void TryCatch(Action tryAction, Action<Exception> catchAction)
        {
            try
            {
                tryAction();
            }
            catch (Exception ex)
            {
                catchAction(ex);
            }
        }

        internal static void FailFast(Action tryAction) =>
            TryCatch(tryAction, (ex) => Environment.FailFast(ex.Message, ex));
    }
}
