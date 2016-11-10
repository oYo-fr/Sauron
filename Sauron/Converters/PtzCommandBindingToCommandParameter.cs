using Sauron.Commands;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Sauron.Converters
{
    public class PtzCommandBindingToCommandParameter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return new PtzCameraCommandParameter() {
                PtzCommandType = (PtzCommandTypeEnum) values[0],
                Channel = int.Parse(values[1].ToString()),
                Arg1 = int.Parse(values[2].ToString()),
                Arg2 = int.Parse(values[3].ToString()),
                Arg3 = int.Parse(values[4].ToString())
            };
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
