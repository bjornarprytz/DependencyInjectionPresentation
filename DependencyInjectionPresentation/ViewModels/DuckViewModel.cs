using Contracts;
using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace DependencyInjectionPresentation.ViewModels
{
    public class DuckViewModel : BaseViewModel, IAnimalViewModel
    {
        public DuckViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public string Sound => "Quack";

        public string Picture { get; private set; }

        public override void OnShow()
        {
            Task.Run(LoadImageAsync);
        }


        private async Task LoadImageAsync()
        {
            await FlagActionAsync(
                () => IsLoading,
                async () =>
                {
                    Picture = await ServiceProvider.Get<IImageFetcher>().FetchAsync("duck");
                });

        }
    }
}
