using AutoClicker.Services.Clicker;
using AutoClicker.Services.ConfigController;
using AutoClicker.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AutoClicker
{

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            Application.Run(host.Services.GetService<MainWindow>());
        }

        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddTransient<MainWindow>();
                services.AddTransient<IClicker, Clicker>();
                services.AddTransient<IConfigController, ConfigController>();
            });
    }
}