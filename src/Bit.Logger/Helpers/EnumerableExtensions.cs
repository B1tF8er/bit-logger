namespace Bit.Logger.Helpers
{
    using System.Collections.Generic;
    using System.Text;

    internal static class EnumerableExtensions
    {
        internal static string ToAppendedString(this IEnumerable<string> logs)
        {
            var builderLogs = new StringBuilder();

            foreach (var log in logs)
                builderLogs.Append(log);

            return builderLogs.ToString();
        }
    }
}
