
using Contracts;
using Dna;
using System.Windows.Controls;

namespace DependencyInjectionPresentation
{
    public abstract class BasePage<T> : Page
        where T : IViewModel
    {
        public T VM { get => (T)DataContext; set { DataContext = value; } }

        protected BasePage()
        {
            VM = Framework.Service<T>();

            Loaded += BasePage_Loaded;
        }

        private void BasePage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            VM.OnShow();
        }
    }
}
