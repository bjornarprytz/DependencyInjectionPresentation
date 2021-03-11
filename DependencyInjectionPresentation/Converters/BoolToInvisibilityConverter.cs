using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DependencyInjectionPresentation
{
    internal class BoolToInvisibilityConverter : BaseValueConverter<bool, Visibility>
    {
        private static BoolToInvisibilityConverter Instance { get; } = new BoolToInvisibilityConverter();

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Instance;
        }

        protected override Visibility ConvertInternal(bool from)
        {
            return from ? Visibility.Collapsed : Visibility.Visible;
        }
    }
}
