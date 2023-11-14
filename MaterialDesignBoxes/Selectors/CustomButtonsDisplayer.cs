using System.Windows;

namespace MaterialDesignBoxes
{
    internal class CustomButtonsDisplayer
    {
        private readonly MessageBoxWindow _messageBox;

        private readonly string _button1Name;

        private readonly string _button2Name;

        private readonly string _button3Name;

        public CustomButtonsDisplayer(MessageBoxWindow messageBox, string button1Name, string button2Name = "", string button3Name = "")
        {
            _messageBox = messageBox;
            _button1Name = button1Name;
            _button2Name = button2Name;
            _button3Name = button3Name;
        }

        public void Display()
        {
            if (!string.IsNullOrEmpty(_button1Name) && string.IsNullOrEmpty(_button2Name) && string.IsNullOrEmpty(_button3Name))
            {
                _messageBox.Button1.Content = _button1Name;
                _messageBox.Button2.Visibility = Visibility.Collapsed;
                _messageBox.Button3.Visibility = Visibility.Collapsed;
                return;
            }

            if (!string.IsNullOrEmpty(_button1Name) && !string.IsNullOrEmpty(_button2Name) && string.IsNullOrEmpty(_button3Name))
            {
                _messageBox.Button1.Content = _button1Name;
                _messageBox.Button2.Content = _button2Name;
                _messageBox.Button3.Visibility = Visibility.Collapsed;
                return;
            }

            if (!string.IsNullOrEmpty(_button1Name) && !string.IsNullOrEmpty(_button2Name) && !string.IsNullOrEmpty(_button3Name))
            {
                _messageBox.Button1.Content = _button1Name;
                _messageBox.Button2.Content = _button2Name;
                _messageBox.Button3.Content = _button3Name;
                return;
            }
        }
    }
}
