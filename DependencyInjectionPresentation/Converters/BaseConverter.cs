using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace DependencyInjectionPresentation
{

    public abstract class BaseValueConverter<TFrom, TTo> : BaseValueConverter
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is TFrom))
            {
                throw new ArgumentException($"Convert expected {typeof(TFrom)}, got {value?.GetType()}");
            }

            return ConvertInternal((TFrom)value);
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is TTo))
            {
                throw new ArgumentException($"ConvertBack expected {typeof(TTo)}, got {value?.GetType()}");
            }

            return ConvertBackInternal((TTo)value);
        }

        protected abstract TTo ConvertInternal(TFrom from);
        protected virtual TFrom ConvertBackInternal(TTo from)
        {
            throw new NotImplementedException();
        }
    }

    public abstract class BaseValueConverter : MarkupExtension, IValueConverter
    {
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);
        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
