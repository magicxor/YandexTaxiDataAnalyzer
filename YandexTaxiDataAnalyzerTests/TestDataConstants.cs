namespace YandexTaxiDataAnalyzerTests
{
    public static class TestDataConstants
    {
        public const string HtmlMessage2020 =
@"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=""http://www.w3.org/1999/xhtml"" lang=""ru"" xml:lang=""ru"">
    <head>
        <meta http-equiv=""Content-Type"" content=""text/html;charset=UTF-8"" />
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
        <meta name=""format-detection"" content=""telephone=no"" />
        <meta name=""format-detection"" content=""date=no"" />
        <meta name=""format-detection"" content=""address=no"" />
        <meta name=""format-detection"" content=""email=no"" />
        <style>
a[x-apple-data-detectors] {
    color: inherit !important;
    text-decoration: none !important;
    font-size: inherit !important;
    font-family: inherit !important;
    font-weight: inherit !important;
    line-height: inherit !important;
}
</style>
        <title>Яндекс Go – Отчёт о поездке</title>
        <script type=""application/ld+json"">
            {""taxi"": [{""arr"": ""Россия, Казань, улица Ленина, 11/3"", ""cost"": 184.0, ""dep"": ""Россия, Казань, улица Седова, 34Б"", ""car"": ""Honda Fit"", ""time_dep"": ""0.0.0 19:58:39"", ""city_dep"": ""Казань"", ""trip_class"": ""econom"", ""duration"": ""0:4:10"", ""order_date"": ""30.9.2020 19:55:10"", ""time_arr"": ""0.0.0 20:2:49"", ""city_dep_geoid"": 63, ""dist"": 2.528}]}
        </script>
        <!--[if mso]>
            <style type=""text/css"">
                body,
                table,
                td {
                    font-family: -apple-system, Roboto, Arial, -apple-system, Roboto, Helvetica, sans-serif !important;
                }
            </style>
        <![endif]-->
    </head>
    <body>
        <!--[if mso]>
            <center>
        <![endif]-->
        <table align=""center"" border=""0"" cellspacing=""0"" cellpadding=""0"" width=""500"" class=""mail"" style=""width: 100%; max-width: 500px; margin: auto;"">
            <tr>
                <td align=""center"" class=""mail__header"" style=""padding: 56px 0 32px;"">
                    <a href=""https://go.yandex"" class=""logo"" style=""display: inline-block; border: 0;"">
                        <img src=""https://avatars.mds.yandex.net/get-bunker/994123/982ad9476c8d8d017cf37cf0f639ccc10745b2ec/orig"" alt=""Яндекс Go"" width=""98"" height=""33"" class=""logo"" style=""display: inline-block; border: 0;"" />
                    </a>
                </td>
            </tr>
            <tr>
                <td align=""center"" class=""mail__map"" style=""padding-bottom: 16px;"">
                    <span class=""map-link-fallback"" style=""text-decoration: none; display: block; border: 0; width: 100%; border-radius: 4px; background-color: #FDFAF1; box-shadow: 0 8px 20px rgba(117,115,111,.2); overflow: hidden;"">
                        <img src=""https://tc.mobile.yandex.net/get-map/1.x/?lang=ru&amp;lg=0&amp;scale=1&amp;pt=103.49229,51.87373"" alt=""Маршрут"" class=""map-fallback"" style=""display: block; width: 100%; max-width: 100%; height: auto; border-radius: 4px; border: 0; padding: 0;"" />
                    </span>
                </td>
            </tr>
            <tr>
                <td class=""mail__separator"" style=""font-size: 16px; font-family: -apple-system, Roboto, Helvetica, Arial, sans-serif;"">
                    <table class=""separator"" style=""width: 100%; height: 24px; background-color: #f5f4f2; border-radius: 4px;"">
                        <tr class=""separator__row"">
                            <td valign=""middle"" class=""separator__cell"" style=""font-size: 13px; height: 24px; vertical-align: middle; color: #75736f; padding: 0 16px;"">Маршрут</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td align=""center"" class=""mail__section"" style=""font-size: 16px; font-family: -apple-system, Roboto, Helvetica, Arial, sans-serif; padding: 0 16px;"">
                    <table border=""0"" cellspacing=""0"" cellpadding=""0"" class=""route"" style=""width: 100%;"">
                        <tr class=""route__point"" style=""height: 60px;"">
                            <td class=""route__point-icon"" style=""padding: 0 20px 0 5px; width: 14px; vertical-align: middle; border-bottom: 1px solid #E7E5E1;"">
                                <img alt="""" width=""14"" height=""14"" src=""https://avatars.mds.yandex.net/get-bunker/120922/fd0ecc350e00ad5adb00b318de087453e0b37a6c/orig"" />
                            </td>
                            <td class=""route__point-details"" style=""padding: 12px 0; color: #21201F; vertical-align: middle; border-bottom: 1px solid #E7E5E1;"">
                                <p class=""route__point-name"" style=""margin: 0;"">улица Седова, 34Б</p>
                                <p class=""hint"" style=""margin: 0; color: #9E9B98; font-size: 13px; line-height: 16px;"">19:58</p>
                            </td>
                        </tr>
                        <tr class=""route__point"" style=""height: 60px;"">
                            <td class=""route__point-icon"" style=""padding: 0 20px 0 5px; width: 14px; vertical-align: middle; border-bottom: 0;"">
                                <img alt="""" width=""14"" height=""14"" src=""https://avatars.mds.yandex.net/get-bunker/49769/7a3910ead45a9c5754bea26ea0f94a3bedd65fde/orig"" />
                            </td>
                            <td class=""route__point-details"" style=""padding: 12px 0; color: #21201F; vertical-align: middle; border-bottom: 0;"">
                                <p class=""route__point-name"" style=""margin: 0;"">улица Ленина, 11/3</p>
                                <p class=""hint"" style=""margin: 0; color: #9E9B98; font-size: 13px; line-height: 16px;"">
                                    20:02
                                </p>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class=""mail__separator"" style=""font-size: 16px; font-family: -apple-system, Roboto, Helvetica, Arial, sans-serif;"">
                    <table class=""separator"" style=""width: 100%; height: 24px; background-color: #f5f4f2; border-radius: 4px;"">
                        <tr class=""separator__row"">
                            <td valign=""middle"" class=""separator__cell"" style=""font-size: 13px; height: 24px; vertical-align: middle; color: #75736f; padding: 0 16px;"">Оплата</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class=""mail__section"" style=""font-size: 16px; font-family: -apple-system, Roboto, Helvetica, Arial, sans-serif; padding: 0 16px;"">
                    <table border=""0"" cellspacing=""0"" cellpadding=""0"" class=""report"" style=""width: 100%;"">
                        <tr class=""report__row"" style=""height: 60px;"">
                            <td align=""left"" valign=""middle"" class=""report__label"" style=""padding: 12px 0; border-bottom: 1px solid #E7E5E1; text-align: left;"">
                                Общая стоимость</td>
                            <td align=""right"" class=""report__value report__value_main"" style=""padding: 12px 0; border-bottom: 1px solid #E7E5E1; color: #21201F; text-align: right; font-size: 16px; font-weight: bold;"">184 ₽</td>
                        </tr>
                        <tr class=""report__row"" style=""height: 60px;"">
                            <td align=""left"" class=""report__label"" style=""padding: 12px 0; border-bottom: 1px solid #E7E5E1; text-align: left;"">Поездка</td>
                            <td align=""right"" class=""report__value"" style=""padding: 12px 0; border-bottom: 1px solid #E7E5E1; color: #9E9B98; text-align: right;"">184 ₽</td>
                        </tr>
                        <tr class=""report__row"" style=""height: 60px;"">
                            <td align=""left"" valign=""middle"" class=""report__label"" style=""padding: 12px 0; text-align: left; border-bottom: 0;"">Способ оплаты</td>
                            <td align=""right"" class=""report__value"" style=""padding: 12px 0; color: #9E9B98; text-align: right; border-bottom: 0;"">
                                <table align=""right"" border=""0"" cellspacing=""0"" cellpadding=""0"" class=""card"" style=""float: right;"">
                                    <tr>
                                        <td valign=""middle"" class=""card__name"" style=""padding-right: 8px;"">
                                            Google Pay
                                        </td>
                                        <td valign=""middle"" class=""card__icon"">
                                            <img class=""card__vendor-icon"" width=""36"" height=""24"" src=""https://avatars.mds.yandex.net/get-bunker/61205/16c72f19adf4c587d5b2a1b0154a854266adbdf9/orig"" alt=""google"" style=""display: block;"" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class=""mail__separator"" style=""font-size: 16px; font-family: -apple-system, Roboto, Helvetica, Arial, sans-serif;"">
                    <table class=""separator"" style=""width: 100%; height: 24px; background-color: #f5f4f2; border-radius: 4px;"">
                        <tr class=""separator__row"">
                            <td valign=""middle"" class=""separator__cell"" style=""font-size: 13px; height: 24px; vertical-align: middle; color: #75736f; padding: 0 16px;"">Детали</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class=""mail__section"" style=""font-size: 16px; font-family: -apple-system, Roboto, Helvetica, Arial, sans-serif; padding: 0 16px;"">
                    <table border=""0"" cellspacing=""0"" cellpadding=""0"" class=""report"" style=""width: 100%;"">
                        <tr class=""report__row"" style=""height: 60px;"">
                            <td align=""left"" class=""report__label"" style=""padding: 12px 0; border-bottom: 1px solid #E7E5E1; text-align: left;"">Автомобиль</td>
                            <td align=""right"" class=""report__value"" style=""padding: 12px 0; border-bottom: 1px solid #E7E5E1; color: #9E9B98; text-align: right;"">
                                <p class=""car-model"" style=""margin: 0; font-weight: 600; color: #21201F;"">розовый Honda Fit</p>
                                <p class=""car-number"" style=""margin: 0; font-size: 13px; text-transform: uppercase; color: #21201F;"">А878АМ126</p>
                            </td>
                        </tr>
                        <tr class=""report__row"" style=""height: 60px;"">
                            <td align=""left"" class=""report__label"" style=""padding: 12px 0; border-bottom: 1px solid #E7E5E1; text-align: left;"">Тариф</td>
                            <td class=""report__value"" style=""padding: 12px 0; border-bottom: 1px solid #E7E5E1; color: #9E9B98; text-align: right;"">Эконом</td>
                        </tr>
                        <tr class=""report__row"" style=""height: 60px;"">
                            <td align=""left"" class=""report__label"" style=""padding: 12px 0; border-bottom: 1px solid #E7E5E1; text-align: left;"">Дата</td>
                            <td class=""report__value"" style=""padding: 12px 0; border-bottom: 1px solid #E7E5E1; color: #9E9B98; text-align: right;"">30 сентября 2020 г.</td>
                        </tr>
                        <tr class=""report__row"" style=""height: 60px;"">
                            <td align=""left"" class=""report__label"" style=""padding: 12px 0; border-bottom: 1px solid #E7E5E1; text-align: left;"">Время в пути</td>
                            <td class=""report__value"" style=""padding: 12px 0; border-bottom: 1px solid #E7E5E1; color: #9E9B98; text-align: right;"">
                                <p class=""ride-time"" style=""margin: 0;"">4 мин 10 сек</p>
                                <p class=""hint"" style=""margin: 0; color: #9E9B98; font-size: 13px; line-height: 16px;"">2,6 км</p>
                            </td>
                        </tr>
                        <tr class=""report__row"" style=""height: 60px;"">
                            <td align=""left"" class=""report__label"" colspan=""2"" style=""padding: 12px 0; text-align: left; border-bottom: 0;"">
                                <table border=""0"" cellspacing=""0"" cellpadding=""0"" class=""links"" style=""width: 100%;"">
                                    <tr>
                                        <td valign=""middle"" class=""links__cell"" style=""border-right: 1px solid #E7E5E1; width: 50%; padding: 0 16px; line-height: 36px; text-align: center; border-left: 0; padding-left: 0;"">
                                            <a class=""report-link"" href=""https://trust.yandex.ru/receipts/134-45376622a1de261f88c232341ceb0861/"" style=""color: #5C5CDA; text-decoration: none; display: block;"">
                                                Чек поездки
                                            </a>
                                        </td>
                                        <td valign=""middle"" class=""links__cell"" style=""width: 50%; padding: 0 16px; line-height: 36px; text-align: center;"">
                                            <a class=""report-link"" href=""https://yandex.ru/support/taxi/"" style=""color: #5C5CDA; text-decoration: none; display: block;"">Поддержка</a>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class=""mail__separator"" style=""font-size: 16px; font-family: -apple-system, Roboto, Helvetica, Arial, sans-serif;"">
                    <table class=""separator"" style=""width: 100%; height: 24px; background-color: #f5f4f2; border-radius: 4px;"">
                        <tr class=""separator__row"">
                            <td valign=""middle"" class=""separator__cell"" style=""font-size: 13px; height: 24px; vertical-align: middle; color: #75736f; padding: 0 16px;"">Перевозчик</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class=""mail__section"" style=""font-size: 16px; font-family: -apple-system, Roboto, Helvetica, Arial, sans-serif; padding: 0 16px;"">
                    <table border=""0"" cellspacing=""0"" cellpadding=""0"" class=""details"" style=""width: 100%;"">
                        <tr class=""details__row"" style=""height: 60px;"">
                            <td class=""details__cell"" valign=""middle"" style=""padding: 12px 0 15px; border-bottom: 1px solid #E7E5E1;"">
                                <p class=""hint"" style=""margin: 0; color: #9E9B98; font-size: 13px; line-height: 16px;"">Водитель</p>
                                <p class=""details__value"" style=""margin: 1px 0 0;"">Зайцев Нурсултан</p>
                            </td>
                        </tr>
                        <tr class=""details__row"" style=""height: 60px;"">
                            <td class=""details__cell"" valign=""middle"" style=""padding: 12px 0 15px; border-bottom: 1px solid #E7E5E1;"">
                                <p class=""hint"" style=""margin: 0; color: #9E9B98; font-size: 13px; line-height: 16px;"">Партнёр</p>
                                <p class=""details__value"" style=""margin: 1px 0 0;"">ИП Одарич Дмитрий Борисович</p>
                            </td>
                        </tr>
                        <tr class=""details__row"" style=""height: 60px;"">
                            <td class=""details__cell"" valign=""middle"" style=""padding: 12px 0 15px; border-bottom: 0;"">
                                <p class=""hint"" style=""margin: 0; color: #9E9B98; font-size: 13px; line-height: 16px;"">Юр. адрес</p>
                                <p class=""details__value"" style=""margin: 1px 0 0;"">664023,Казань,ул Трилиссера,128,19</p>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class=""mail__footer"" style=""font-size: 16px; font-family: -apple-system, Roboto, Helvetica, Arial, sans-serif;"">
                    <table border=""0"" cellspacing=""0"" cellpadding=""0"" class=""footer"" width=""100%"" style=""height: 60px; width: 100%; border-top: 1px solid #E7E5E1;"">
                        <tr>
                            <td align=""center"" class=""footer__unsubscribe"" style=""text-align: center;"">
                                <a class=""unsubscribe"" href=""https://taxi.yandex.ru/email/unsubscribe/?confirmation_code=XXXXXXXXXXX&amp;lang=ru"" style=""color: #5C5CDA; font-size: 13px; text-decoration: none;"">Отписаться от отчётов</a>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <!--[if mso]>
            </center>
        <![endif]-->
    </body>
</html>";

        public const string HtmlMessage2018 =
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
