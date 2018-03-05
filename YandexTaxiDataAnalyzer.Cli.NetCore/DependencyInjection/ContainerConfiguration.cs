using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using YandexTaxiDataAnalyzer.Core;
using YandexTaxiDataAnalyzer.Core.Models;
using YandexTaxiDataAnalyzer.Core.Services;

namespace YandexTaxiDataAnalyzer.Cli.NetCore.DependencyInjection
{
    public static class ContainerConfiguration
    {
        public static void ConfigureServices(IServiceCollection services, IConfigurationRoot configurationRoot, ApplicationSettings applicationSettings)
        {
            services
                .AddLogging(builder => 
                    builder
                    .SetMinimumLevel(LogLevel.Trace)
                    .AddConsole()
                    .AddNLog(new NLogProviderOptions {CaptureMessageTemplates = true, CaptureMessageProperties = true}))
                .AddSingleton(applicationSettings)
                .AddScoped<ImapService>()
                .AddScoped<HtmlParserService>()
                .AddScoped<DataAnalyzer>()
                .AddScoped<YandexTaxiDataAnalyzerCore>();
        }
    }
}
