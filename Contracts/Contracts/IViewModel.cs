using System.ComponentModel;

namespace Contracts
{
    public  interface IViewModel : INotifyPropertyChanged
    {
        bool IsLoading { get; }
        void OnShow();
    }
}
