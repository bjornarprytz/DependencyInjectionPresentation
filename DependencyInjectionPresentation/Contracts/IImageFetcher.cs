using System.Threading.Tasks;

namespace Contracts
{
    public interface IImageFetcher
    {
        Task<string> FetchAsync(string id);
    }
}
