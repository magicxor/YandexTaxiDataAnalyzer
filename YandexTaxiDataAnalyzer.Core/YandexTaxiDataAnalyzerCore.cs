using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json;
using YandexTaxiDataAnalyzer.Core.Extensions;
using YandexTaxiDataAnalyzer.Core.Models;
using YandexTaxiDataAnalyzer.Core.Services;

namespace YandexTaxiDataAnalyzer.Core
{
    public class YandexTaxiDataAnalyzerCore
    {
        private readonly ImapService _imapService;
        private readonly HtmlParserService _htmlParserService;

        public YandexTaxiDataAnalyzerCore(ImapService imapService, HtmlParserService htmlParserService)
        {
            _imapService = imapService;
            _htmlParserService = htmlParserService;
        }

        private IList<DataItem> GetData()
        {
            var htmlMessages = _imapService.GetHtmlMessages();
            return _htmlParserService.ParseHtmlMessages(htmlMessages);
        }

        public string GetStatistics()
        {
            var data = GetData();
            var dataAnalyzer = new DataAnalyzer();
            var minutesByCompany = dataAnalyzer.GetStatistics(data, item => item.ContractorInformation.Company, item => item.OrderInformation.Duration.TotalMinutes);
            var minutesByCarColor = dataAnalyzer.GetStatistics(data, item => item.ContractorInformation.CarColor, item => item.OrderInformation.Duration.TotalMinutes);
            var minutesByCarModel = dataAnalyzer.GetStatistics(data, item => item.ContractorInformation.CarModel, item => item.OrderInformation.Duration.TotalMinutes);
            var minutesByCarAndDriver = dataAnalyzer.GetStatistics(data, item => item.ContractorInformation.CarColor + " " + item.ContractorInformation.CarModel + " " + item.ContractorInformation.CarNumber + " " + item.ContractorInformation.Driver, item => item.OrderInformation.Duration.TotalMinutes);
            var costByMinutes = dataAnalyzer.GetStatistics(data, item => item.OrderInformation.Duration.TotalMinutes, item => item.OrderInformation.Cost);
            var costByHourOfDay = dataAnalyzer.GetStatistics(data, item => item.RouteInformation.OrderDateTime.TimeOfDay.Hours, item => item.OrderInformation.Cost);
            var costByDayOfWeek = dataAnalyzer.GetStatistics(data, item => item.RouteInformation.OrderDateTime.DayOfWeek, item => item.OrderInformation.Cost);
            var costByWaypointCount = dataAnalyzer.GetStatistics(data, item => item.RouteInformation.Waypoints.Count, item => item.OrderInformation.Cost);

            var costByDate = dataAnalyzer.GetStatistics(data, item => item.RouteInformation.OrderDateTime.Date, item => item.OrderInformation.Cost);
            var costByMonth = dataAnalyzer.GetStatistics(data, item => new DateTime(item.RouteInformation.OrderDateTime.Date.Year, item.RouteInformation.OrderDateTime.Date.Month, 1), item => item.OrderInformation.Cost);
            var costByYear = dataAnalyzer.GetStatistics(data, item => item.RouteInformation.OrderDateTime.Year, item => item.OrderInformation.Cost);

            var lastNames = data
                .Select(item => item.ContractorInformation.Driver)
                .Distinct()
                .Select(item => item.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                .Where(arr => arr.Length > 0)
                .Select(arr => arr[0]);
            var firstNames = data
                .Select(item => item.ContractorInformation.Driver)
                .Distinct()
                .Select(item => item.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                .Where(arr => arr.Length > 1)
                .Select(arr => arr[1]);
            var patronymics = data
                .Select(item => item.ContractorInformation.Driver)
                .Distinct()
                .Select(item => item.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                .Where(arr => arr.Length > 2)
                .Select(arr => arr[2]);
            var lastNameFrequencyData = dataAnalyzer.GetStatistics(lastNames, item => item, item => 1);
            var firstNameFrequencyData = dataAnalyzer.GetStatistics(firstNames, item => item, item => 1);
            var patronymicFrequencyData = dataAnalyzer.GetStatistics(patronymics, item => item, item => 1);

            var rideCountByCompany = minutesByCompany.OrderByDescending(item => item.Count).Select(item => new { name = item.Key, y = item.Count }).ToList();
            var rideCountByCarColor = minutesByCarColor.OrderByDescending(item => item.Count).Select(item => new { name = item.Key, y = item.Count }).ToList();
            var rideCountByCarModel = minutesByCarModel.OrderByDescending(item => item.Count).Select(item => new { name = item.Key, y = item.Count }).ToList();
            var rideCountByCarAndDriver = minutesByCarAndDriver.Where(item => item.Count > 1).OrderByDescending(item => item.Count).Select(item => new { name = item.Key, y = item.Count }).ToList();

            var totalCostByMinutes = costByMinutes.OrderBy(item => item.Key).Select(item => new { name = item.Key, y = item.Sum }).ToList();
            var rideCountByMinutes = costByMinutes.OrderBy(item => item.Key).Select(item => new { name = item.Key, y = item.Count }).ToList();

            var totalCostByHourOfDay = costByHourOfDay.OrderBy(item => item.Key).Select(item => new { name = item.Key, y = item.Sum }).ToList();
            var rideCountByHourOfDay = costByHourOfDay.OrderBy(item => item.Key).Select(item => new { name = item.Key, y = item.Count }).ToList();

            var totalCostByDayOfWeek = costByDayOfWeek.OrderBy(item => item.Key).Select(item => new { name = item.Key.ToString(), y = item.Sum }).ToList();
            var rideCountByDayOfWeek = costByDayOfWeek.OrderBy(item => item.Key).Select(item => new { name = item.Key.ToString(), y = item.Count }).ToList();

            var medianCostByWaypointCount = costByWaypointCount.OrderBy(item => item.Key).Select(item => new { name = item.Key, y = item.Median }).ToList();
            var rideCountByWaypointCount = costByWaypointCount.OrderBy(item => item.Key).Select(item => new { name = item.Key, y = item.Count }).ToList();

            var totalCostByDate = costByDate.OrderBy(item => item.Key).Select(item => new { name = item.Key.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), y = item.Sum }).ToList();
            var rideCountByDate = costByDate.OrderBy(item => item.Key).Select(item => new { name = item.Key.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), y = item.Count }).ToList();

            var totalCostByMonth = costByMonth.OrderBy(item => item.Key).Select(item => new { name = item.Key.ToString("MMMM", CultureInfo.CreateSpecificCulture("en-US")), y = item.Sum }).ToList();
            var rideCountByMonth = costByMonth.OrderBy(item => item.Key).Select(item => new { name = item.Key.ToString("MMMM", CultureInfo.CreateSpecificCulture("en-US")), y = item.Count }).ToList();

            var totalCostByYear = costByYear.OrderBy(item => item.Key).Select(item => new { name = item.Key, y = item.Sum }).ToList();
            var rideCountByYear = costByYear.OrderBy(item => item.Key).Select(item => new { name = item.Key, y = item.Count }).ToList();
            
            var lastNameFrequency = lastNameFrequencyData.OrderByDescending(item => item.Count).Select(item => new { name = item.Key, y = item.Count }).ToList();
            var firstNameFrequency = firstNameFrequencyData.OrderByDescending(item => item.Count).Select(item => new { name = item.Key, y = item.Count }).ToList();
            var patronymicFrequency = patronymicFrequencyData.OrderByDescending(item => item.Count).Select(item => new { name = item.Key, y = item.Count }).ToList();

            var totalDuration = TimeSpan.FromMinutes(data.Sum(item => item.OrderInformation.Duration.TotalMinutes)).ToString();
            var medianDuration = TimeSpan.FromMinutes(data.Select(item => item.OrderInformation.Duration.TotalMinutes).Median()).ToString();
            var totalRideCount = data.Count;
            var totalCost = data.Sum(item => item.OrderInformation.Cost) + " ₽";
            var medianCost = data.Where(item => item.OrderInformation.Cost.HasValue).Select(item => item.OrderInformation.Cost ?? 0).Median() + " ₽";
            var totalUniqueWaypointCount = data.SelectMany(item => item.RouteInformation.Waypoints).Distinct().Count();

            var summary = new
            {
                rideCountByCompany,
                rideCountByCarColor,
                rideCountByCarModel,
                rideCountByCarAndDriver,
                totalCostByMinutes,
                rideCountByMinutes,
                totalCostByHourOfDay,
                rideCountByHourOfDay,
                totalCostByDayOfWeek,
                rideCountByDayOfWeek,
                medianCostByWaypointCount,
                rideCountByWaypointCount,
                totalCostByDate,
                rideCountByDate,
                totalCostByMonth,
                rideCountByMonth,
                totalCostByYear,
                rideCountByYear,
                lastNameFrequency,
                firstNameFrequency,
                patronymicFrequency,
                totalDuration,
                medianDuration,
                totalRideCount,
                totalCost,
                medianCost,
                totalUniqueWaypointCount
            };
            return JsonConvert.SerializeObject(summary);
        }
    }
}
