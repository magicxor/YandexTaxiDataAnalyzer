namespace YandexTaxiDataAnalyzerTests
{
    public static class TestDataConstants
    {
        public const string HtmlMessage =
@"<html xmlns=""http://www.w3.org/1999/xhtml"" lang=""ru"">
<head>
	<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
	<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <!--https://developer.apple.com/library/safari/featuredarticles/iPhoneURLScheme_Reference/PhoneLinks/PhoneLinks.html#//apple_ref/doc/uid/TP40007899-CH6-SW1-->
    <meta name=""format-detection"" content=""telephone=no"" />
    <meta name=""format-detection"" content=""date=no"" />
	<title>Яндекс.Такси – Отчёт о поездке</title>
<style type=""text/css"">
#outlook a
{
    padding: 0;
}
.ExternalClass
{
    width: 100%;
}
.ExternalClass,
.ExternalClass p,
.ExternalClass span,
.ExternalClass font,
.ExternalClass td,
.ExternalClass div
{
    line-height: 100%;
}
@media only screen and (max-width: 640px)
{
    .wrapper
    {
        width: 100% !important;
        min-width: 450px;
        margin-top: 0;
    }
    .content
    {
        padding-left: 15px;
        padding-right: 15px;
    }
    .inner
    {
        overflow: hidden;
    }
}
</style>
<script type=""application/ld+json"">
    {""taxi"": [{""arr"": ""Россия, Красноярск, улица Ленина, 11/5"", ""cost"": 71.0, ""dep"": ""Россия, Красноярск, Советская улица, 19В"", ""car"": ""Toyota Corolla"", ""time_dep"": ""0.0.0 16:39:59"", ""city_dep"": ""Красноярск"", ""trip_class"": ""econom"", ""duration"": ""0:8:57"", ""order_date"": ""9.7.2017 16:34:22"", ""time_arr"": ""0.0.0 16:48:56"", ""city_dep_geoid"": 63, ""dist"": 2.712}]}
</script>
</head>
<body style=""-ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; background: #f6f5f3; margin: 0; padding: 0; width: 100%;"">
<div class=""taxi-mail"" style=""background-color: #f6f5f3; color: #000; padding: 40px 10px 10px;"">
    <table class=""wrapper"" cellpadding=""0"" cellspacing=""0"" style=""border-collapse: collapse; color: #000; font-family: 'Arial', 'sans-serif'; font-size: 13px; margin: 0 auto; mso-table-lspace: 0; mso-table-rspace: 0; padding: 0; table-layout: fixed; width: 580px;"">
        <tr>
            <td class=""inner"" style=""border-collapse: collapse;"">
                <div class=""header"" style=""background-color: #fff; margin-bottom: 1px; width: 100%;"">
                    <div class=""logo"" style=""padding: 30px 0 30px 23px;"">
                        <a href=""https://taxi.yandex.ru"" style=""color: #669; text-decoration: none;"">
                            <img class=""image_fix"" src=""https://avatars.mds.yandex.net/get-bunker/56833/b75e7dd2f0cccd0b099e71839e5fd0ce755abac5/orig"" width=""178"" height=""42"" title=""Яндекс.Такси"" alt=""Яндекс.Такси"" style=""-ms-interpolation-mode: bicubic; border: none; outline: none; text-decoration: none;"" />
                        </a>
                    </div>
                </div>
                <div class=""content"" style=""background: #fcfcfc; padding: 18px 30px 20px;"">
                    <h1 style=""color: #000; font-size: 26px; font-weight: 400; line-height: 1; margin: 0 0 10px 0;"">Отчёт о поездке</h1>
                    <!--disable iPhone date autodetection-->
                    <div class=""date gray"" style=""color: #8f8f8f; margin-bottom: 23px;"">9 июля 2017 г.</div>
                            <p style=""color: #000; line-height: 20px; margin: 0 0 14px;"">
                            </p>
                    <table class=""line"" cellpadding=""0"" cellspacing=""0"" style=""border-collapse: collapse; margin-bottom: 39px; margin-top: 35px; mso-table-lspace: 0; mso-table-rspace: 0; width: 100%;"">
                        <tr>
                            <td class=""line__img"" rowspan=""4"" style=""border-collapse: collapse; padding-right: 30px; padding-top: 3px; vertical-align: top; width: 20px;"">
                                <img class=""image_fix"" src=""https://avatars.yandex.net/get-bunker/31664ffe4afcef6bc9996bbe1dea633bd73fc656/normal/31664f.png"" width=""20"" height=""169"" title=""Схема"" alt=""Схема"" style=""-ms-interpolation-mode: bicubic; outline: none; text-decoration: none;"" />
                            </td>
                                    <td class=""line__text line__1"" style=""border-collapse: collapse; color: #000; height: 53px; vertical-align: top;"">Вы заказали такси 9 июля 2017 г. в 16:40</td>
                        </tr>
                        <tr>
                            <td class=""line__text line__2"" style=""border-collapse: collapse; height: 55px; vertical-align: top;"">Советская улица, 19В</td>
                        </tr>
                        <tr>
                            <td class=""line__text line__3"" style=""border-collapse: collapse; vertical-align: top;"">улица Ленина, 11/5</td>
                        </tr>
                        <tr>
                            <td class=""line__text line__4"" style=""border-collapse: collapse; vertical-align: bottom;"">Стоимость поездки — 71 руб.</td>
                        </tr>
                    </table>
                    <table class=""summary"" cellpadding=""0"" cellspacing=""0"" style=""border-collapse: collapse; mso-table-lspace: 0; mso-table-rspace: 0;"">
                        <tr>
                            <td class=""gray"" style=""border-collapse: collapse; color: #8f8f8f; padding-right: 30px;"">Тариф</td>
                            <td class=""gray"" style=""border-collapse: collapse; color: #8f8f8f; padding-right: 30px;"">Время в пути</td>
                            <td class=""gray"" style=""border-collapse: collapse; color: #8f8f8f; padding-right: 30px;"">Стоимость</td>
                        </tr>
                        <tr>
                            <td class=""value"" style=""border-collapse: collapse; color: #000; font-size: 14px; line-height: 20px; padding-right: 30px; padding-top: 4px;"">Эконом</td>
                            <td class=""value"" style=""border-collapse: collapse; color: #000; font-size: 14px; line-height: 20px; padding-right: 30px; padding-top: 4px;"">8 мин</td>
                            <td class=""value value-last"" style=""border-collapse: collapse; color: #000; font-size: 14px; line-height: 20px; padding-right: 30px; padding-top: 4px;"">71 руб.</td>
                        </tr>
                    </table>
                </div>
                <div class=""map"" style=""background: url('http://static-maps.yandex.ru/1.x/?l=map&amp;size=640,200&amp;pt=101.71384,54.87841,pm2rdl~103.20501,58.66324,pm2dbl') no-repeat center center; height: 200px; -webkit-background-size: contain; background-size: contain;""></div>
                <div class=""content"" style=""background: #fcfcfc; padding: 18px 30px 20px;"">
                    <table class=""info"" cellpadding=""0"" cellspacing=""0"" style=""border-collapse: collapse; mso-table-lspace: 0; mso-table-rspace: 0; width: 100%;"">
                        <tr>
                            <td class=""gray"" style=""border-collapse: collapse; color: #8f8f8f;"">Таксопарк</td>
                            <td class=""gray"" style=""border-collapse: collapse; color: #8f8f8f;"">Водитель</td>
                            <td class=""gray"" style=""border-collapse: collapse; color: #8f8f8f;"">Автомобиль</td>
                        </tr>
                        <tr>
                            <td class=""value"" style=""border-collapse: collapse; color: #000; font-size: 14px; line-height: 20px; padding-right: 20px; padding-top: 4px;"">
                                Стрела
                            </td>
                            <td class=""value"" style=""border-collapse: collapse; color: #000; font-size: 14px; line-height: 20px; padding-right: 20px; padding-top: 4px;"">
                                Сидоров Пётр Иванович
                            </td>
                            <td class=""value value-last"" style=""border-collapse: collapse; color: #000; font-size: 14px; line-height: 20px; padding-right: 0; padding-top: 4px;"">
                                белый Toyota Corolla
                            </td>
                        </tr>
                        <tr>
                            <td class=""value nowrap"" style=""border-collapse: collapse; color: #000; font-size: 14px; line-height: 20px; padding-right: 20px; padding-top: 4px; white-space: nowrap;"">89838058271</td>
                            <td class=""value nowrap"" style=""border-collapse: collapse; color: #000; font-size: 14px; line-height: 20px; padding-right: 20px; padding-top: 4px; white-space: nowrap;"">+79647127711</td>
                            <td class=""value value-last nowrap"" style=""border-collapse: collapse; color: #000; font-size: 14px; line-height: 20px; padding-right: 0; padding-top: 4px; white-space: nowrap;"">Х228РТ38</td>
                        </tr>
                    </table>
                </div>
                <div class=""footer"" style=""padding: 30px;"">
                    <p style=""color: #000; line-height: 20px; margin: 0 0 14px;"">Любые вопросы вы можете задать на странице <a href=""https://yandex.ru/support/taxi/troubleshooting/review.xml"" style=""color: #669; text-decoration: none;"">службы поддержки</a>.</p>
                    <table class=""footer-table"" cellpadding=""0"" cellspacing=""0"" style=""border-collapse: collapse; mso-table-lspace: 0; mso-table-rspace: 0; width: 100%;"">
                        <tr>
                            <td style=""border-collapse: collapse;"">
                                <p style=""color: #000; line-height: 20px; margin: 0 0 14px;"">
                                    <a href=""https://taxi.yandex.ru"" style=""color: #669; text-decoration: none;"">Команда Яндекс.Такси</a>
                                </p>
                            </td>
                            <td align=""right"" class=""footer-table__unset"" style=""border-collapse: collapse; text-align: right;"">
                                <p style=""color: #000; line-height: 20px; margin: 0 0 14px;"">
                                    <a href=""https://taxi.yandex.ru/email/unsubscribe/?confirmation_code=XXXXXXXXXXX"" style=""color: #669; text-decoration: none;"">Больше не получать отчёты о поездках</a>
                                </p>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>
</div>
<!--<img src=""http://clck.yandex.ru/click/dtype=stred/pid=2/cid=70026/*"" alt="""" width=""1""/>-->
</body>
</html>";
    }
}
