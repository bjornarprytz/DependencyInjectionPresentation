
using Dna;
using Microsoft.Extensions.Configuration;
using System.Windows;

namespace DependencyInjectionPresentation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Framework.Construct<DefaultFrameworkConstruction>()
                .AddConfiguration(
                    new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .Build())
                .AddImageFetcher()
                .AddViewModels()
                .Build();
        }
    }
}
