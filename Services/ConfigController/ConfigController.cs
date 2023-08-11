using AutoClicker.Models.Config;
using System.Text.Json;

namespace AutoClicker.Services.ConfigController
{
    public class ConfigController : IConfigController
    {
        private const string _nameConfig = "App.json";
        public ConfigApp GetConfig()
        {
            if (File.Exists(_nameConfig))
            {
                using var stream = File.OpenRead(_nameConfig);
                return JsonSerializer.Deserialize<ConfigApp>(stream);
            }
            else
                return SetConfig(new ConfigApp());
        }

        public ConfigApp SetConfig(ConfigApp config)
        {
            if (File.Exists(_nameConfig))
            {
                var stream = File.OpenWrite(_nameConfig);
                JsonSerializer.Serialize<ConfigApp>(stream, config);
                stream.Dispose();
            }
            else
            {
                var file = new FileInfo(_nameConfig);
                var stream = file.OpenWrite();
                JsonSerializer.Serialize<ConfigApp>(stream, config);
                stream.Dispose();
            }

            return config;
        }
    }
}
