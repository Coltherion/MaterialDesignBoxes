using MaterialDesignThemes.Wpf;
using System.Collections.Generic;
using Color = System.Windows.Media.Color;

namespace MaterialDesignBoxes
{
    public class ThemeColorSelector : ThemeColor
    {
        private readonly IList<IColorSelect> _selectRules;

        public ThemeColorSelector()
        {
            _selectRules = new List<IColorSelect>() { new DefaultThemeColor(), new BlueThemeColor(), new RedThemeColor(), new OrangeThemeColor(), new GreenThemeColor() };
        }

        public void Select(BoxesThemeColor color, MessageBoxWindow messageBox)
        {
            foreach (IColorSelect selectRule in _selectRules)
            {
                if (selectRule.Color == color)
                    selectRule.Select(messageBox);
            }
        }

        public void Select(BoxesThemeColor color, InputBoxWindow inputBox)
        {
            foreach (IColorSelect selectRule in _selectRules)
            {
                if (selectRule.Color == color)
                    selectRule.Select(inputBox);
            }
        }
    }

    public interface IColorSelect
    {
        void Select(MessageBoxWindow messageBox);

        void Select(InputBoxWindow inputBox);

        BoxesThemeColor Color { get; }
    }

    public abstract class ThemeColor
    {
        public void ChangeThemeColor(Color color, MessageBoxWindow messageBox)
        {
            messageBox.ThemeDictionary.MergedDictionaries.RemoveAt(0);
            messageBox.Resources.MergedDictionaries.Insert(0,
                new CustomColorTheme()
                {
                    BaseTheme = BaseTheme.Light,
                    PrimaryColor = color,
                    SecondaryColor = Color.FromRgb(255, 255, 255)
                });
        }

        public void ChangeThemeColor(Color color, InputBoxWindow inputBox)
        {
            inputBox.ThemeDictionary.MergedDictionaries.RemoveAt(0);
            inputBox.Resources.MergedDictionaries.Insert(0,
                new CustomColorTheme()
                {
                    BaseTheme = BaseTheme.Light,
                    PrimaryColor = color,
                    SecondaryColor = Color.FromRgb(255, 255, 255)
                });
        }
    }

    public class DefaultThemeColor : ThemeColor, IColorSelect
    {
        public void Select(MessageBoxWindow messageBox)
        {
            ChangeThemeColor(System.Windows.Media.Color.FromRgb(128, 128, 128), messageBox);
        }

        public void Select(InputBoxWindow inputBox)
        {
            ChangeThemeColor(System.Windows.Media.Color.FromRgb(128, 128, 128), inputBox);
        }

        public BoxesThemeColor Color => BoxesThemeColor.Default;
    }

    public class BlueThemeColor : ThemeColor, IColorSelect
    {
        public void Select(MessageBoxWindow messageBox)
        {
            ChangeThemeColor(System.Windows.Media.Color.FromRgb(0, 95, 190), messageBox);
        }

        public void Select(InputBoxWindow inputBox)
        {
            ChangeThemeColor(System.Windows.Media.Color.FromRgb(0, 95, 190), inputBox);
        }

        public BoxesThemeColor Color => BoxesThemeColor.Blue;
    }

    public class RedThemeColor : ThemeColor, IColorSelect
    {
        public void Select(MessageBoxWindow messageBox)
        {
            ChangeThemeColor(System.Windows.Media.Color.FromRgb(225, 0, 15), messageBox);
        }

        public void Select(InputBoxWindow inputBox)
        {
            ChangeThemeColor(System.Windows.Media.Color.FromRgb(225, 0, 15), inputBox);
        }

        public BoxesThemeColor Color => BoxesThemeColor.Red;
    }

    public class OrangeThemeColor : ThemeColor, IColorSelect
    {
        public void Select(MessageBoxWindow messageBox)
        {
            ChangeThemeColor(System.Windows.Media.Color.FromRgb(251, 167, 0), messageBox);
        }

        public void Select(InputBoxWindow inputBox)
        {
            ChangeThemeColor(System.Windows.Media.Color.FromRgb(251, 167, 0), inputBox);
        }

        public BoxesThemeColor Color => BoxesThemeColor.Orange;
    }

    public class GreenThemeColor : ThemeColor, IColorSelect
    {
        public void Select(MessageBoxWindow messageBox)
        {
            ChangeThemeColor(System.Windows.Media.Color.FromRgb(83, 132, 106), messageBox);
        }

        public void Select(InputBoxWindow inputBox)
        {
            ChangeThemeColor(System.Windows.Media.Color.FromRgb(83, 132, 106), inputBox);
        }

        public BoxesThemeColor Color => BoxesThemeColor.Green;
    }
}
