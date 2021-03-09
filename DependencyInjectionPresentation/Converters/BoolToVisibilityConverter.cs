using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DependencyInjectionPresentation
{
    internal class BoolToVisibilityConverter : BaseValueConverter<bool, Visibility>
    {
        private static BoolToVisibilityConverter Instance { get; } = new BoolToVisibilityConverter();

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Instance;
        }

        protected override Visibility ConvertInternal(bool from)
        {
            return from ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
