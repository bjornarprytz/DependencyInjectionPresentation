using Contracts;
using DependencyInjectionPresentation.ViewModels;
using Dna;
using ImageServices;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionPresentation
{
    public static class ConstructionExtensions
    {
        // Lifetimes:
        // Transient: new instance of T each call to GetService<T>()
        // Scoped: new instance per scope (e.g. function)
        // Singleton: one instance throughout Application runtime


        public static FrameworkConstruction AddImageFetcher(this FrameworkConstruction construction)
        {
            construction.Services.AddSingleton<IImageFetcher, DuckmageFetcher>();

            return construction;
        }

        public static FrameworkConstruction AddViewModels(this FrameworkConstruction construction)
        {
            
            construction.Services.AddTransient<IAnimalViewModel, DuckViewModel>();

            return construction;
        }
    }
}
