using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using YandexTaxiDataAnalyzer.Cli.NetCore.DependencyInjection;
using YandexTaxiDataAnalyzer.Core;
using YandexTaxiDataAnalyzer.Core.Constants;
using YandexTaxiDataAnalyzer.Core.Models;

namespace YandexTaxiDataAnalyzer.Cli.NetCore
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var currentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                var configurationBuilder = new ConfigurationBuilder()
                    .SetBasePath(currentDirectory)
                    .AddJsonFile(Defaults.ConfigurationFileName);
                var configurationRoot = configurationBuilder.Build();
                var applicationSettings = configurationRoot.GetSection(Defaults.ConfigurationSectionName).Get<ApplicationSettings>();

                var serviceCollection = new ServiceCollection();
                ContainerConfiguration.ConfigureServices(serviceCollection, configurationRoot, applicationSettings);
                var serviceProvider = serviceCollection.BuildServiceProvider();

                var yandexTaxiDataAnalyzerCore = serviceProvider.GetService<YandexTaxiDataAnalyzerCore>();
                var logger = serviceProvider.GetService<ILogger<YandexTaxiDataAnalyzerCore>>();

                logger.LogInformation("Start analysis...");
                var result = yandexTaxiDataAnalyzerCore.GetStatistics();
                logger.LogInformation(result);

                File.WriteAllText(Path.Combine(currentDirectory, applicationSettings.OutputFileName), result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
