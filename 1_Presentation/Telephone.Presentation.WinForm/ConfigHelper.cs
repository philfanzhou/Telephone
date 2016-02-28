using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone.Presentation.WinForm
{
    public static class ConfigHelper
    {
        public static Dictionary<string, string> GetAllAppSettings()
        {
            ConfigurationManager.RefreshSection("appSettings");
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (string key in ConfigurationManager.AppSettings.AllKeys)
                dict.Add(key, ConfigurationManager.AppSettings[key]);
            return dict;
        }

        public static string GetAppSettingsValue(string key)
        {
            ConfigurationManager.RefreshSection("appSettings");
            return ConfigurationManager.AppSettings[key] ?? string.Empty;
        }
        
        public static void UpdateAppSettings(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (!config.HasFile)
            {
                throw new ArgumentException("程序配置文件缺失！");
            }
            KeyValueConfigurationElement kvce = config.AppSettings.Settings[key];
            if (kvce == null)
                config.AppSettings.Settings.Add(key, value);
            else
                config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static string GetConnectionStrings(string name)
        {
            var conn = ConfigurationManager.ConnectionStrings[name];
            if (conn != null)
                return conn.ConnectionString;
            return string.Empty;
        }

        public static void UpdateConnectionStrings(string name, string connectionString)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (!config.HasFile)
            {
                throw new ArgumentException("程序配置文件缺失！");
            }

            var conn = config.ConnectionStrings.ConnectionStrings[name];
            if (conn == null)
            {
                config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings(name, connectionString));
            }
            else
                conn.ConnectionString = connectionString;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
