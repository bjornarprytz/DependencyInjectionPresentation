using Contracts;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Threading.Tasks;

namespace ImageServices
{
    public class DuckmageFetcher : IImageFetcher
    {
        private IConfiguration _config;

        private IConfigurationSection Ducks => _config.GetSection("Ducks");

        private string Denied => _config["Denied"];

        public DuckmageFetcher(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task<string> FetchAsync(string id)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(Ducks[id]))
            {
                return Denied;
            }

            await Task.Delay(3000);

            var filePath = Ducks[id];

            return File.Exists(filePath) 
                ? filePath
                : Denied;
        }
    }
}
