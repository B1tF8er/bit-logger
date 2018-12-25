namespace Bit.Logger.Helpers
{
    internal static class StringExtensions
    {
        internal static bool IsNullOrEmptyOrWhiteSpace(this string value) =>
            string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);
    }
}