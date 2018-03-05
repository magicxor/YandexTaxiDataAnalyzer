using System;

namespace YandexTaxiDataAnalyzer.Core.Exceptions
{
    public class StringParseException: Exception
    {
        public StringParseException(string message) : base(message)
        {
        }
    }
}
