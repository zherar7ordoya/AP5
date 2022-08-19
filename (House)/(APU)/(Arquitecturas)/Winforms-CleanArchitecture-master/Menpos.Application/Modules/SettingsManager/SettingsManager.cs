using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Menpos.Application.Modules.SettingsManager
{
    public static class SettingsManager
    {
        public static void UpdateAppConfig(string key, string value, string fileName = null)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(fileName);
            configFile.AppSettings.Settings[key].Value = value;

            configFile.Save();
        }

        public static string GetConnectionString(string key = null, string fileName = null)
        {
            return ConfigurationManager.ConnectionStrings[key ?? "cn"].ConnectionString;
        }
    }
}
