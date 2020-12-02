namespace Bit.Logger.Tests.Helpers
{
    using Bit.Logger.Models;
    using System.Text;

    internal static class LogHelper
    {
        internal static string BuildLogString(this Log log) =>
            new StringBuilder()
                .Append("Level: ").Append(log.Level).Append(' ')
                .Append("Message: ").Append(log.Message).Append(' ')
                .Append("Date: ").Append(log.Date).Append(' ')
                .Append("Class: ").Append(log.Class).Append(' ')
                .Append("Method: ").Append(log.Method).Append(' ')
                .Append("Exception: ").Append(log.Exception)
                .ToString();
    }
}
