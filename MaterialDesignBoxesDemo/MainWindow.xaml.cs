using MaterialDesignBoxes;
using System.Windows;
using System.Windows.Media;
using MessageBox = MaterialDesignBoxes.MessageBox;
using MessageBoxButton = MaterialDesignBoxes.MessageBoxButton;
using MessageBoxResult = MaterialDesignBoxes.MessageBoxResult;

namespace MaterialMessageBoxDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowSimpleMessageBox_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"This is a message.", "Custom Title", MessageBoxButton.OkOnly, MessageBoxIcon.Information, Color.FromRgb(128, 0, 128), MessageBoxFocus.Button1);
            MessageBox.Show($"This is a message.", "Custom Title", MessageBoxButton.OkOnly, MessageBoxIcon.Information, BoxesThemeColor.Blue, MessageBoxFocus.Button1);
            var outcome = MessageBox.Show($"This is a message.", "Custom Title", MessageBoxButton.YesNo, MessageBoxIcon.Question, BoxesThemeColor.Red, MessageBoxFocus.Button1);
            if (outcome.Result == MessageBoxResult.Yes) ;
        }

        private void ShowSimpleRTLMessageBox_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is a message.", "Title", button1: "Done");
            MessageBox.Show("This is a message.", "Title", button1: "Apply", button2: "Exit");
            var outcome = MessageBox.Show("This is a message.", "Title", button1: "Help", button2: "Submit", button3: "Quit", MessageBoxIcon.Default, BoxesThemeColor.Green);
            if (outcome.Result == MessageBoxResult.Button1) ;
        }

        private void ShowWarningMessageBox_OnClick(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show($"This is a simple message.", "Custom Title", MessageBoxButton.YesNoCancel, MessageBoxIcon.Warning, BoxesThemeColor.Red, MessageBoxFocus.Button1, checkBox: "Custom Checkbox");
            if (result.Checkbox == MessageBoxCheckbox.Checked) ;
        }

        private void ShowErrorMessageBox_OnClick(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show($"This is a simple message\n\nIs'nt it cool !!\n.\n.\nYou could even scroll!!!\nd\no\no\no\no\no\nw\nn", "Custom Title",
                MaterialDesignBoxes.MessageBoxButton.OkCancel, MessageBoxIcon.Error, BoxesThemeColor.Green);
        }

        private void ShowMessageBoxWithCancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            string result = InputBox.Show("Please choose item:", new string[] { "Item1", "Item2", "Item3" }, color: BoxesThemeColor.Green);
        }

        private void ShowCustomMessageBox_OnClick(object sender, RoutedEventArgs e)
        {
            var result = InputBox.Show("Please enter your name:", color: Color.FromRgb(200, 150, 150));
        }
    }
}
