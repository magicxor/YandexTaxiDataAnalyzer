using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YandexTaxiDataAnalyzer.Core.Services;

namespace YandexTaxiDataAnalyzerTests
{
    [TestClass]
    public class HtmlParserServiceTests
    {
        private readonly HtmlParserService _htmlParserService;

        public HtmlParserServiceTests()
        {
            _htmlParserService = new HtmlParserService();
        }

        [DataTestMethod]
        [DataRow("Стоимость поездки — 134 руб.", 134)]
        [DataRow("Е212АХ138", 212)]
        [DataRow("8 мин", 8)]
        [DataRow("улица Ленина, 19/6", 19)]
        [DataRow("Вы заказали такси 20 февраля 2015 г. в 01:58", 20)]
        [DataRow("000000001", 1)]
        public void TestGetFirstNumber(string sourceString, int referenceNumber)
        {
            var number = _htmlParserService.GetFirstNumber(sourceString);
            Assert.AreEqual(referenceNumber, number);
        }

        [DataTestMethod]
        [DataRow(" тёмно-серый Hyundai Solaris ", "тёмно-серый", "Hyundai Solaris")]
        [DataRow(" белый ГАЗ 31105 «Волга» ", "белый", "ГАЗ 31105 «Волга»")]
        [DataRow("белый LADA (ВАЗ) Granta", "белый", "LADA (ВАЗ) Granta")]
        [DataRow(" серо-синий LADA (ВАЗ) Granta ", "серо-синий", "LADA (ВАЗ) Granta")]
        [DataRow(" чёрный Subaru Legacy ", "чёрный", "Subaru Legacy")]
        public void TestGetColorAndModel(string description, string referenceColor, string referenceModel)
        {
            var (color, model) = _htmlParserService.GetColorAndModel(description);
            Assert.AreEqual(referenceColor, color);
            Assert.AreEqual(referenceModel, model);
        }

        [DataTestMethod]
        [DataRow(TestDataConstants.HtmlMessage2018, "Стрела", "Сидоров Пётр Иванович", "белый", "Toyota Corolla", "Х228РТ38", "Эконом", 8, 71, new[]{ "Советская улица, 19В", "улица Ленина, 11/5" }, 1499618400)]
        [DataRow(TestDataConstants.HtmlMessage2020, "ИП Одарич Дмитрий Борисович", "Зайцев Нурсултан", "розовый", "Honda Fit", "А878АМ126", "Эконом", 4, 184, new[] { "улица Седова, 34Б", "улица Ленина, 11/3" }, 1601395200)]
        public void TestParseHtmlMessage(string htmlMessage, 
            string referenceCompany, 
            string referenceDriver, 
            string referenceCarColor, 
            string referenceCarModel, 
            string referenceCarNumber,
            string referenceTariff,
            int referenceTimeInMinutes,
            int referenceCost,
            string[] referenceWaypoints,
            int referenceOrderDateTimeUnix)
        {
            var htmlMessages = new List<string>(){ htmlMessage };
            var result = _htmlParserService.ParseHtmlMessages(htmlMessages);
            var firstResult = result.FirstOrDefault();

            Assert.IsNotNull(firstResult);
            Assert.IsNotNull(firstResult.ContractorInformation);
            Assert.IsNotNull(firstResult.OrderInformation);
            Assert.IsNotNull(firstResult.RouteInformation);

            Assert.AreEqual(referenceCompany, firstResult.ContractorInformation.Company);
            Assert.AreEqual(referenceDriver, firstResult.ContractorInformation.Driver);
            Assert.AreEqual(referenceCarColor, firstResult.ContractorInformation.CarColor);
            Assert.AreEqual(referenceCarModel, firstResult.ContractorInformation.CarModel);
            Assert.AreEqual(referenceCarNumber, firstResult.ContractorInformation.CarNumber);

            Assert.AreEqual(referenceTariff, firstResult.OrderInformation.Tariff);
            Assert.AreEqual(TimeSpan.FromMinutes(referenceTimeInMinutes), firstResult.OrderInformation.Duration);
            Assert.AreEqual(referenceCost, firstResult.OrderInformation.Cost);
            
            CollectionAssert.AreEqual(referenceWaypoints, firstResult.RouteInformation.Waypoints.ToArray());
            Assert.AreEqual(DateTimeOffset.FromUnixTimeSeconds(referenceOrderDateTimeUnix).DateTime, firstResult.RouteInformation.OrderDateTime);
        }
    }
}
