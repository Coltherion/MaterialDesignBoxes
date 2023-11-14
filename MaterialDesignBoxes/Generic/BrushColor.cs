using System.Windows.Media;

namespace MaterialDesignBoxes
{
    public class BrushColor
    {
        public static SolidColorBrush FromHex(string hexColorString)
        {
            return (SolidColorBrush)(new BrushConverter().ConvertFrom(hexColorString));
        }

        public static SolidColorBrush FromRgb(byte r, byte g, byte b)
        {
            return new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        public static SolidColorBrush GetContrastColor(Brush backgroundColor)
        {
            Color color = ((SolidColorBrush)backgroundColor).Color;

            // Calculate the luminance of the background color
            double luminance = 0.299 * color.R + 0.587 * color.G + 0.114 * color.B;

            // Choose white or black based on the luminance
            return luminance > 128 ? Brushes.Black : Brushes.White;
        }
    }
}
