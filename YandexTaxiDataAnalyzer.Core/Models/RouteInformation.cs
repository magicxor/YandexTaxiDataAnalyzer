using System;
using System.Collections.Generic;

namespace YandexTaxiDataAnalyzer.Core.Models
{
    public class RouteInformation
    {
        public IList<string> Waypoints { get; set; }
        public DateTime OrderDateTime { get; set; }
    }
}
