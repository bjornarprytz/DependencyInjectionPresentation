using Contracts;
using System;
using System.Threading.Tasks;

namespace ImageServices
{
    public class CityImageFetcher : IImageFetcher
    {
        public async Task<string> FetchAsync(string id)
        {
            await Task.Delay(8000);

            return @"C:\Users\Public\Pictures\cityduck.jpg";
        }
    }
}
