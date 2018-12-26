namespace Bit.Logger.Helpers
{
    using Enums;
    using System;
    using System.Text.RegularExpressions;

    internal static class StringExtensions
    {
        internal static bool IsNullOrEmptyOrWhiteSpace(this string value) =>
            string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);

        internal static Level GetLevel(this string log)
        {
            var pattern = @"\btrace\b|\bdebug\b|\bverbose\b|\binformation\b|\bwarning\b|\berror\b";
            var match = Regex.Match(log, pattern, RegexOptions.IgnoreCase);

            if (match.Success)
                return (Level)Enum.Parse(typeof(Level), match.Value, ignoreCase: true);
            else
                return Level.None;
        }
    }
}