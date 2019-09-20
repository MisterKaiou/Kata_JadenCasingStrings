using System.Globalization;

namespace Jaden.CasingStrings
{
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase) => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
    }
}
