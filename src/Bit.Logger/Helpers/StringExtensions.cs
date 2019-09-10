namespace Bit.Logger.Helpers
{
    using Enums;
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal static class StringExtensions
    {
        internal static bool IsNullOrEmptyOrWhiteSpace(this string value) =>
            string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);

        internal static Level GetLevel(this string log)
        {
            var pattern = Enum.GetValues(typeof(Level))
                .OfType<Level>()
                .Select(lvl => $@"\b{lvl}\b")
                .Aggregate((a, b) => $"{a}|{b}");
            var match = Regex.Match(log, pattern, RegexOptions.IgnoreCase);

            var level = Level.None;

            if (match.Success)
                level = (Level)Enum.Parse(typeof(Level), match.Value, ignoreCase: true);

            return level;
        }
    }
}
