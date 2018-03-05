using System.Collections.Generic;
using System.Text;

namespace YandexTaxiDataAnalyzer.Core.Extensions
{
    public static class CharExtensions
    {
        public static string AsString(this IEnumerable<char> chars)
        {
            var sb = new StringBuilder();
            foreach (var c in chars)
            {
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
