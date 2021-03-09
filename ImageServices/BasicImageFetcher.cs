using DependencyInjectionPresentation.Contracts;
using System;
using System.Threading.Tasks;

namespace ImageServices
{
    public class BasicImageFetcher : IImageFetcher
    {
        public async Task<string> FetchAsync(string id)
        {
            await Task.Delay(3000);

            return @"C:\Users\Public\Pictures\simpleduck.png";
            
        }
    }
}
