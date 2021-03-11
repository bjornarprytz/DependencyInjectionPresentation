
using System.Windows.Input;

namespace Contracts
{
    public interface IAnimalViewModel : IViewModel
    {
        string Id { get; set; }
        string Sound { get; }
        string Picture { get; }

        ICommand LoadImageCommand { get; }
    }
}
