using AutoClicker.Models.Config;

namespace AutoClicker.Services.ConfigController
{
    public interface IConfigController
    {
        ConfigApp GetConfig();
        ConfigApp SetConfig(ConfigApp config);
    }
}
