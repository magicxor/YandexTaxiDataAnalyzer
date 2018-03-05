namespace YandexTaxiDataAnalyzer.Core.Models
{
    public class ApplicationSettings
    {
        public string ImapHost { get; set; }
        public int ImapPort { get; set; }
        public string ImapLogin { get; set; }
        public string ImapPassword { get; set; }
        public string LogDirectoryName { get; set; } = "logs";
        public string OutputFileName { get; set; } = "yandex-taxi-stats.json";
    }
}
