using System;

namespace YandexTaxiDataAnalyzer.Core.Exceptions
{
    public class DifferentLayoutException: Exception
    {
        public DifferentLayoutException(string message): base(message)
        {
        }
    }
}
