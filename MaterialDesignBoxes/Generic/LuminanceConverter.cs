using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace MaterialDesignBoxes
{
    public class LuminanceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is SolidColorBrush brush)
            {
                double luminance = 0.299 * brush.Color.R + 0.587 * brush.Color.G + 0.114 * brush.Color.B;
                return luminance > 128 ? Brushes.Black : Brushes.White;
            }

            return Brushes.Black; // Default color
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
