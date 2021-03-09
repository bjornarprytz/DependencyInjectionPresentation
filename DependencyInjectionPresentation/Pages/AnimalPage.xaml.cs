using Contracts;

namespace DependencyInjectionPresentation
{
    /// <summary>
    /// Interaction logic for AnimalPage.xaml
    /// </summary>
    public partial class AnimalPage : BasePage<IAnimalViewModel>
    {
        public AnimalPage()
        {
            InitializeComponent();
        }
    }
}
