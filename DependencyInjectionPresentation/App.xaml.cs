
using Dna;
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
                .AddImageFetcher()
                .AddViewModels()
                .Build();
        }
    }
}
