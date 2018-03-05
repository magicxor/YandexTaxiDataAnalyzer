# YandexTaxiDataAnalyzer
A simple tool for Yandex.Taxi report parsing and visualization

## Usage
1. Publish YandexTaxiDataAnalyzer.Cli.NetCore project
```
dotnet publish -r win10-x64 -c Release
```
or download binary files.
2. Create appsettings.json file with your data:
```
{
  "ApplicationCoreConfiguration": {
    "ImapHost": "imap.test.com",
    "ImapPort": 993,
    "ImapLogin": "test@test.com",
    "ImapPassword": "password",
    "LogDirectoryName": "logs"
  }
}
```
3. Run YandexTaxiDataAnalyzer.Cli.NetCore.exe
4. Copy yandex-taxi-stats.json to YandexTaxiDataAnalyzer.Visualization directory and open index.html