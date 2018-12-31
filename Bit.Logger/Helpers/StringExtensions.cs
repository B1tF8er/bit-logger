namespace Bit.Logger.Helpers
{
    using Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    internal static class StringExtensions
    {
        internal static bool IsNullOrEmptyOrWhiteSpace(this string value) =>
            string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);

        internal static Level GetLevel(this string log)
        {
            string CreatePatternForLevels(IEnumerable<Level> levels)
            {
                var patternBuilder = new StringBuilder();

                foreach (var l in levels)
                    patternBuilder.Append($@"\b{l}\b|");

                return patternBuilder.ToString().Substring(0, patternBuilder.Length - 1);
            }

            var pattern = CreatePatternForLevels(Enum.GetValues(typeof(Level)).OfType<Level>());
            var match = Regex.Match(log, pattern, RegexOptions.IgnoreCase);

            var level = Level.None;

            if (match.Success)
                level = (Level)Enum.Parse(typeof(Level), match.Value, ignoreCase: true);

            return level;
        }
    }
}