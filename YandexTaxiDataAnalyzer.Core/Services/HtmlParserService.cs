using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using YandexTaxiDataAnalyzer.Core.Exceptions;
using YandexTaxiDataAnalyzer.Core.Extensions;
using YandexTaxiDataAnalyzer.Core.Models;

namespace YandexTaxiDataAnalyzer.Core.Services
{
    public class HtmlParserService
    {
        private readonly Regex _numberRegex = new Regex(@"\d+", RegexOptions.Compiled);

        public int GetFirstNumber(string sourceString)
        {
            var match = _numberRegex.Match(sourceString);
            if (!match.Success)
            {
                throw new StringParseException($"{nameof(GetFirstNumber)} failed: no match found");
            }
            else
            {
                return int.Parse(match.Value);
            }
        }

        public (string color, string model) GetColorAndModel(string description)
        {
            description = description.Trim();
            var carColor = description.TakeWhile(c => char.IsWhiteSpace(c) || c == '-' || (char.IsLower(c) && (int)c >= (int)'Ё' && (int)c <= (int)'ё')).AsString().Trim();
            if (carColor.Length == 0)
            {
                throw new StringParseException($"{nameof(GetColorAndModel)} failed: {carColor} not found");
            }
            else
            {
                var carModel = description.Substring(carColor.Length).Trim();
                if (carModel.Length == 0)
                {
                    throw new StringParseException($"{nameof(GetColorAndModel)} failed: {carModel} not found");
                }
                else
                {
                    return (carColor, carModel);
                }
            }
        }

        private OrderInformation GetOrderInformation(IElement orderTable)
        {
            var rows = orderTable.QuerySelectorAll("tr");
            if (rows.Length == 2)
            {
                var cols = rows[1].QuerySelectorAll("td");
                if (cols.Length == 2)
                {
                    return new OrderInformation()
                    {
                        Tariff = cols[0].TrimmedText(),
                        Cost = GetFirstNumber(cols[1].TrimmedText()),
                    };
                }
                else if (cols.Length == 3)
                {
                    return new OrderInformation()
                    {
                        Tariff = cols[0].TrimmedText(),
                        Duration = TimeSpan.FromMinutes(GetFirstNumber(cols[1].TrimmedText())),
                        Cost = GetFirstNumber(cols[2].TrimmedText()),
                    };
                }
                else
                {
                    throw new DifferentLayoutException($"{nameof(GetOrderInformation)} can't process DOM due to different layout");
                }
            }
            else
            {
                throw new DifferentLayoutException($"{nameof(GetOrderInformation)} can't process DOM due to different layout");
            }
        }

        private ContractorInformation GetContractorInformation(IElement contractorTable)
        {
            var rows = contractorTable.QuerySelectorAll("tr");
            if (rows.Length == 3)
            {
                var cols1 = rows[1].QuerySelectorAll("td");
                var cols2 = rows[2].QuerySelectorAll("td");
                if (cols1.Length == 3 && cols2.Length == 3)
                {
                    var (color, model) = GetColorAndModel(cols1[2].TrimmedText());
                    return new ContractorInformation()
                    {
                        Company = cols1[0].TrimmedText(),
                        Driver = cols1[1].TrimmedText(),
                        CarColor = color,
                        CarModel = model,
                        CarNumber = cols2[2].TrimmedText(),
                    };
                }
                else
                {
                    throw new DifferentLayoutException($"{nameof(GetContractorInformation)} can't process DOM due to different layout");
                }
            }
            else
            {
                throw new DifferentLayoutException($"{nameof(GetContractorInformation)} can't process DOM due to different layout");
            }
        }

        private RouteInformation GetRouteInformation(IElement routeTable)
        {
            var rows = routeTable.QuerySelectorAll("tr");

            var russianCulture = CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat;

            var waypoints = new List<string>();
            var orderDateTime = DateTime.MinValue;

            foreach (var row in rows)
            {
                if (row == rows.Last()) continue;
                if (row == rows.First())
                {
                    var cols = row.QuerySelectorAll("td");
                    if (cols.Length == 2)
                    {
                        var orderDateTimeString = cols[1].TrimmedText().Replace("Вы заказали такси ", "");
                        var orderDateTimeStringParts = orderDateTimeString.Split(new []{ " в " },StringSplitOptions.None);
                        if (orderDateTimeStringParts.Length == 2)
                        {
                            var orderDateString = orderDateTimeStringParts[0];
                            var orderTimeString = orderDateTimeStringParts[1];
                            var orderDate = DateTime.ParseExact(orderDateString, "D", russianCulture, DateTimeStyles.None);
                            var orderTime = TimeSpan.ParseExact(orderTimeString, @"hh\:mm", russianCulture);
                            orderDateTime = orderDate + orderTime;
                        }
                        else
                        {
                            throw new DifferentLayoutException($"{nameof(GetRouteInformation)} can't process {nameof(orderDateTimeString)} due to different structure");
                        }
                    }
                    else
                    {
                        throw new DifferentLayoutException($"{nameof(GetRouteInformation)} can't process DOM due to different layout");
                    }
                }
                else
                {
                    var cols = row.QuerySelectorAll("td");
                    if (cols.Length == 1)
                    {
                        waypoints.Add(cols[0].TrimmedText());
                    }
                    else
                    {
                        throw new DifferentLayoutException($"{nameof(GetRouteInformation)} can't process DOM due to different layout");
                    }
                }
            }

            return new RouteInformation() { OrderDateTime = orderDateTime, Waypoints = waypoints };
        }

        public IList<DataItem> ParseHtmlMessages(ICollection<string> htmlMessages)
        {
            var result = new List<DataItem>();

            foreach (var htmlMessage in htmlMessages)
            {
                var parser = new HtmlParser();
                var document = parser.ParseDocument(htmlMessage);
                var tables = document.QuerySelectorAll("table");
                var contractorTable = tables.FirstOrDefault(x => !x.InnerHtml.Contains("<table") && (x.InnerHtml.Contains("Партнёр") || x.InnerHtml.Contains("Таксопарк")) && x.InnerHtml.Contains("Водитель") && x.InnerHtml.Contains("Автомобиль"));
                var orderTable = tables.FirstOrDefault(x => !x.InnerHtml.Contains("<table") && x.InnerHtml.Contains("Тариф") && x.InnerHtml.Contains("Стоимость"));
                var routeTable = tables.FirstOrDefault(x => !x.InnerHtml.Contains("<table") && x.InnerHtml.Contains("Вы заказали такси") && x.InnerHtml.Contains("Стоимость поездки"));
                result.Add(new DataItem()
                {
                    ContractorInformation = GetContractorInformation(contractorTable),
                    OrderInformation = GetOrderInformation(orderTable),
                    RouteInformation = GetRouteInformation(routeTable),
                });
            }

            return result;
        }
    }
}
