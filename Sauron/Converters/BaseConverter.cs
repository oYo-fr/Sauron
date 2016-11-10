using System;
using System.Globalization;
using System.Windows.Data;

namespace Sauron.Converters
{
    public abstract class BaseConverter : IValueConverter
    {

        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
    }
}
