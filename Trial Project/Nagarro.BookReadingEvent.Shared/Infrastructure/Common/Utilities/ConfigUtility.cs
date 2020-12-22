using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nagarro.BookReadingEvent.Shared.Infrastructure.Common.Utilities
{
   
    public class ConfigUtility
    {
        private static ConfigUtility _appSettings;

        public string appSettingValue { get; set; }

        public static string AppSetting(string Key)
        {
            _appSettings = GetCurrentSettings(Key);
            return _appSettings.appSettingValue;
        }

        public ConfigUtility(IConfiguration config, string Key)
        {
            this.appSettingValue = config[Key];
        }

        // Get a valued stored in the appsettings.
        // Pass in a key like TestArea:TestKey to get TestValue
        public static ConfigUtility GetCurrentSettings(string Key)
        {
            var builder = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                            .AddEnvironmentVariables();

            IConfigurationRoot configuration = builder.Build();

            var settings = new ConfigUtility(configuration.GetSection("ApplicationSettings"), Key);

            return settings;
        }
    }
}
