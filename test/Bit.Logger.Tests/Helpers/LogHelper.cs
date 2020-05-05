namespace Bit.Logger.Tests.Helpers
{
    using Bit.Logger.Models;
    using System.Text;

    internal static class LogHelper
    {
        internal static string BuildLogString(this Log log) =>
            new StringBuilder()
                .Append($"Level: {log.Level} ")
                .Append($"Message: {log.Message} ")
                .Append($"Date: {log.Date} ")
                .Append($"Class: {log.Class} ")
                .Append($"Method: {log.Method} ")
                .Append($"Exception: {log.Exception}")
                .ToString();
    }
}
