using System.Collections.Generic;
using System.Windows;

namespace MaterialDesignBoxes
{
    public class ButtonsDisplayer
    {
        private readonly IList<IButtonsDisplay> _displayRules;

        public ButtonsDisplayer()
        {
            _displayRules = new List<IButtonsDisplay>() { new OkOnly(), new OkCancel(), new YesNo(), new YesNoCancel() };
        }

        public void Display(MessageBoxButton buttons, MessageBoxWindow messageBox)
        {
            foreach (IButtonsDisplay displayRule in _displayRules)
            {
                if (displayRule.Buttons == buttons)
                    displayRule.Display(messageBox);
            }
        }
    }

    public interface IButtonsDisplay
    {
        void Display(MessageBoxWindow messageBox);

        MessageBoxButton Buttons { get; }
    }

    public class OkOnly : IButtonsDisplay
    {
        public void Display(MessageBoxWindow messageBox)
        {
            messageBox.Button1.Content = "OK";
            messageBox.Button2.Visibility = Visibility.Collapsed;
            messageBox.Button3.Visibility = Visibility.Collapsed;
            messageBox.Button1.Focus();
        }

        public MessageBoxButton Buttons => MessageBoxButton.OkOnly;
    }

    public class OkCancel : IButtonsDisplay
    {
        public void Display(MessageBoxWindow messageBox)
        {
            messageBox.Button1.Content = "OK";
            messageBox.Button2.Content = "Cancel";
            messageBox.Button3.Visibility = Visibility.Collapsed;
            messageBox.Button1.Focus();
        }

        public MessageBoxButton Buttons => MessageBoxButton.OkCancel;
    }

    public class YesNo : IButtonsDisplay
    {
        public void Display(MessageBoxWindow messageBox)
        {
            messageBox.Button1.Content = "Yes";
            messageBox.Button2.Content = "No";
            messageBox.Button3.Visibility = Visibility.Collapsed;
            messageBox.Button1.Focus();
        }

        public MessageBoxButton Buttons => MessageBoxButton.YesNo;
    }

    public class YesNoCancel : IButtonsDisplay
    {
        public void Display(MessageBoxWindow messageBox)
        {
            messageBox.Button1.Content = "Yes";
            messageBox.Button2.Content = "No";
            messageBox.Button3.Content = "Cancel";
            messageBox.Button1.Focus();
        }

        public MessageBoxButton Buttons => MessageBoxButton.YesNoCancel;
    }
}
