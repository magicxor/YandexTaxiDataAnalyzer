using System.Collections.Generic;
using System.Linq;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using YandexTaxiDataAnalyzer.Core.Models;

namespace YandexTaxiDataAnalyzer.Core.Services
{
    public class ImapService
    {
        private readonly ApplicationSettings _applicationSettings;

        public ImapService(ApplicationSettings applicationSettings)
        {
            _applicationSettings = applicationSettings;
        }

        public ICollection<string> GetHtmlMessages()
        {
            using (var client = new ImapClient())
            {
                client.Connect(_applicationSettings.ImapHost, _applicationSettings.ImapPort, true);
                client.Authenticate(_applicationSettings.ImapLogin, _applicationSettings.ImapPassword);
                
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                var searchResult = inbox.Search(SearchOptions.All, SearchQuery.BodyContains("Вы заказали такси").And(SearchQuery.BodyContains("Отчёт о поездке")).And(SearchQuery.FromContains("no-reply@taxi.yandex.ru")));
                var messages = searchResult.UniqueIds.Select(uid => inbox.GetMessage(uid).HtmlBody).ToList();
                client.Disconnect(true);

                return messages;
            }
        }
    }
}
