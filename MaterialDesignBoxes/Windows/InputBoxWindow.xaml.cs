using System;
using System.Windows;

namespace MaterialDesignBoxes
{
    /// <summary>
    /// Interaction logic for MessageBoxWindow.xaml
    /// </summary>
    public partial class InputBoxWindow : IDisposable
    {

        public string Input { get; set; }

        public string SelectedItem { get; set; }

        public InputBoxWindow()
        {
            InitializeComponent();
            Input = string.Empty;
            SelectedItem = string.Empty;
        }
        private void ButtonOk_OnClick(object sender, RoutedEventArgs e)
        {
            Input = InputBoxField.Text;
            SelectedItem = InputBoxCombobox.Text;
            Close();
        }
        private void ButtonCancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void Dispose()
        {
            Close();
            GC.SuppressFinalize(this);
        }

        private void ButtonPaste_OnClick(object sender, RoutedEventArgs e)
        {
            InputBoxField.Text = Clipboard.GetText();
            InputBoxField.Focus();
        }

        private void ButtonClear_OnClick(object sender, RoutedEventArgs e)
        {
            InputBoxField.Clear();
        }

        private void InputBoxHeader_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
