using Contracts;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace DependencyInjectionPresentation.ViewModels
{
    public class DuckViewModel : BaseViewModel, IAnimalViewModel
    {
        private readonly IImageFetcher Fetcher;

        public DuckViewModel(IImageFetcher fetcher) : base()
        {
            Fetcher = fetcher;
            LoadImageCommand = new CommandHandler(async () => await LoadImageAsync());

        }

        public string Sound => "Quack";

        public string Picture { get; private set; }
        public string Id { get; set; } = "Basic";

        public ICommand LoadImageCommand { get; private set; }

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
                    Picture = await Fetcher.FetchAsync(Id);
                });

        }
    }
}
