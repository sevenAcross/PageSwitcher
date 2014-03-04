using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Scratchpad
{
    class Converters
    {
    }

    public class PageHolderWidthAdjustment : IValueConverter
    {
        public object Convert ( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture )
        {
            if ( value != null )
            {
                double number = (double) value;
                Thickness margin = (Thickness) parameter;
                return number - margin.Left * 2;
            }
            return value;
        }

        public object ConvertBack ( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture )
        {
            throw new NotImplementedException ();
        }
    }
}
