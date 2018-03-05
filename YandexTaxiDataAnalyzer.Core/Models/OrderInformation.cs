using System;

namespace YandexTaxiDataAnalyzer.Core.Models
{
    public class OrderInformation
    {
        public string Tariff { get; set; }
        public TimeSpan Duration { get; set; }
        public int? Cost { get; set; }
    }
}
