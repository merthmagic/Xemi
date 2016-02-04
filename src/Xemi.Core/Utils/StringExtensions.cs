namespace Xemi.Core.Utils
{
    public static class StringExtensions
    {
        public static string GetValueOrDefault(this string input, string defaultValue)
        {
            return string.IsNullOrEmpty(input) ? defaultValue : input;
        }
    }
}