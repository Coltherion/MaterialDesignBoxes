using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace MaterialDesignBoxes
{
    public sealed partial class InputBox
    {
        private static readonly ThemeColorSelector _colorSelector = new ThemeColorSelector();

        public static string Show(
            string query,
            string title = "Input Box",
            string defaultInput = "",
            BoxesThemeColor color = BoxesThemeColor.Default)
        {
            string input = string.Empty;

            using (InputBoxWindow inputBox = new InputBoxWindow())
            {
                inputBox.InputBoxCombobox.Visibility = System.Windows.Visibility.Collapsed;
                inputBox.InputBoxQuery.Text = query;
                inputBox.InputBoxTitle.Text = title;
                inputBox.InputBoxField.Text = defaultInput;
                _colorSelector.Select(color, inputBox);
                inputBox.ShowDialog();
                input = inputBox.Input;
            }

            return input;
        }

        public static string Show(
            string query,
            string title = "Input Box",
            string defaultInput = "",
            Color color = default)
        {
            string input = string.Empty;

            using (InputBoxWindow inputBox = new InputBoxWindow())
            {
                inputBox.InputBoxCombobox.Visibility = System.Windows.Visibility.Collapsed;
                inputBox.InputBoxQuery.Text = query;
                inputBox.InputBoxTitle.Text = title;
                inputBox.InputBoxField.Text = defaultInput;
                _colorSelector.ChangeThemeColor(color, inputBox);
                inputBox.ShowDialog();
                input = inputBox.Input;
            }

            return input;
        }

        public static string Show(
           string query,
           string[] items,
           string title = "Input Box",
           BoxesThemeColor color = BoxesThemeColor.Default)
        {
            string input = string.Empty;

            using (InputBoxWindow inputBox = new InputBoxWindow())
            {
                inputBox.InputBoxField.Visibility = System.Windows.Visibility.Collapsed;
                inputBox.ButtonPaste.Visibility = System.Windows.Visibility.Collapsed;
                inputBox.ButtonClear.Visibility = System.Windows.Visibility.Collapsed;
                inputBox.InputBoxButtons.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
                inputBox.InputBoxQuery.Text = query;
                inputBox.InputBoxTitle.Text = title;
                PopulateCombobox(items, inputBox.InputBoxCombobox);
                _colorSelector.Select(color, inputBox);
                inputBox.ShowDialog();
                input = inputBox.SelectedItem;
            }

            return input;
        }
        private static void PopulateCombobox(string[] items, ComboBox comboBox)
        {
            foreach (var item in items)
            {
                comboBox.Items.Add(item);
            }
        }
    }
}
