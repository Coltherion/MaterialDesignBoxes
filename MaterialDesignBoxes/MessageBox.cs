using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MaterialDesignBoxes
{
    public sealed partial class MessageBox
    {
        private static readonly ButtonsFocuser _buttonsFocuser = new ButtonsFocuser();
        private static readonly IconDisplayer _iconDisplayer = new IconDisplayer();
        private static readonly ThemeColorSelector _colorSelector = new ThemeColorSelector();

        public static MessageBoxOutcome Show(
            string messageText,
            string title = "Message Box",
            MessageBoxButton buttons = MessageBoxButton.OkOnly,
            MessageBoxIcon icon = MessageBoxIcon.Default,
            BoxesThemeColor color = BoxesThemeColor.Default,
            MessageBoxFocus focus = MessageBoxFocus.None,
            string checkBox = "")
        {
            MessageBoxOutcome outcome = new MessageBoxOutcome();

            using (MessageBoxWindow messageBox = new MessageBoxWindow())
            {
                messageBox.Title = title;
                messageBox.MessageBoxTitle.Text = title;
                messageBox.MessageBoxText.Text = messageText;
                SetDefaultControls(messageBox);
                outcome = messageBox.Outcome;
                messageBox.ShowDialog();
            }

            return outcome;

            void SetDefaultControls(MessageBoxWindow messageBox)
            {
                var buttonDisplayer = new ButtonsDisplayer();
                buttonDisplayer.Display(buttons, messageBox);
                _iconDisplayer.Display(icon, messageBox);
                _colorSelector.Select(color, messageBox);
                _buttonsFocuser.Focus(focus, messageBox);
                CheckBoxHandler(checkBox, messageBox);
            }
        }

        public static MessageBoxOutcome Show(
            string messageText,
            string title = "Message Box",
            MessageBoxButton buttons = MessageBoxButton.OkOnly,
            MessageBoxIcon icon = MessageBoxIcon.Default,
            Color color = default,
            MessageBoxFocus focus = MessageBoxFocus.None,
            string checkBox = "")
        {
            MessageBoxOutcome outcome = new MessageBoxOutcome();

            using (MessageBoxWindow messageBox = new MessageBoxWindow())
            {
                messageBox.Title = title;
                messageBox.MessageBoxTitle.Text = title;
                messageBox.MessageBoxText.Text = messageText;
                SetDefaultControls(messageBox);
                outcome = messageBox.Outcome;
                messageBox.ShowDialog();
            }

            return outcome;

            void SetDefaultControls(MessageBoxWindow messageBox)
            {
                var buttonDisplayer = new ButtonsDisplayer();
                buttonDisplayer.Display(buttons, messageBox);
                _iconDisplayer.Display(icon, messageBox);
                _colorSelector.ChangeThemeColor(color, messageBox);
                _buttonsFocuser.Focus(focus, messageBox);
                CheckBoxHandler(checkBox, messageBox);
            }
        }

        public static MessageBoxOutcome Show(
            string messageText,
            string title,
            string button1,
            MessageBoxIcon icon = MessageBoxIcon.Default,
            BoxesThemeColor color = BoxesThemeColor.Default,
            MessageBoxFocus focus = MessageBoxFocus.None,
            string checkBox = "")
        {
            MessageBoxOutcome outcome = new MessageBoxOutcome();

            using (MessageBoxWindow messageBox = new MessageBoxWindow())
            {
                messageBox.Title = title;
                messageBox.MessageBoxTitle.Text = title;
                messageBox.MessageBoxText.Text = messageText;
                SetCustomControls(messageBox, icon, checkBox, color, focus, button1);
                outcome = messageBox.Outcome;
                messageBox.ShowDialog();
            }

            return outcome;
        }

        public static MessageBoxOutcome Show(
            string messageText,
            string title,
            string button1,
            string button2,
            MessageBoxIcon icon = MessageBoxIcon.Default,
            BoxesThemeColor color = BoxesThemeColor.Default,
            MessageBoxFocus focus = MessageBoxFocus.None,
            string checkBox = "")
        {
            MessageBoxOutcome outcome = new MessageBoxOutcome();

            using (MessageBoxWindow messageBox = new MessageBoxWindow())
            {
                messageBox.Title = title;
                messageBox.MessageBoxTitle.Text = title;
                messageBox.MessageBoxText.Text = messageText;
                SetCustomControls(messageBox, icon, checkBox, color, focus, button1, button2);
                outcome = messageBox.Outcome;
                messageBox.ShowDialog();
            }

            return outcome;
        }

        public static MessageBoxOutcome Show(
            string messageText,
            string title,
            string button1,
            string button2,
            string button3,
            MessageBoxIcon icon = MessageBoxIcon.Default,
            BoxesThemeColor color = BoxesThemeColor.Default,
            MessageBoxFocus focus = MessageBoxFocus.None,
            string checkBox = "")
        {
            MessageBoxOutcome outcome = new MessageBoxOutcome();

            using (MessageBoxWindow messageBox = new MessageBoxWindow())
            {
                messageBox.Title = title;
                messageBox.MessageBoxTitle.Text = title;
                messageBox.MessageBoxText.Text = messageText;
                SetCustomControls(messageBox, icon, checkBox, color, focus, button1, button2, button3);
                outcome = messageBox.Outcome;
                messageBox.ShowDialog();
            }

            return outcome;
        }

        private static void SetCustomControls(MessageBoxWindow messageBox, MessageBoxIcon icon, string checkBox,
            BoxesThemeColor color, MessageBoxFocus focus, string button1, string button2 = "", string button3 = "")
        {
            var buttonsDisplayer = new CustomButtonsDisplayer(messageBox, button1, button2, button3);
            buttonsDisplayer.Display();
            _iconDisplayer.Display(icon, messageBox);
            _colorSelector.Select(color, messageBox);
            _buttonsFocuser.Focus(focus, messageBox);
            CheckBoxHandler(checkBox, messageBox);
        }

        private static void CheckBoxHandler(string checkBox, MessageBoxWindow messageBox)
        {
            if (string.IsNullOrEmpty(checkBox))
            {
                messageBox.MessageCheckBox.Visibility = Visibility.Collapsed;
                Grid.SetRowSpan(messageBox.MessageBoxScrollViewer, 2);
            }
            else
                messageBox.MessageCheckBox.Content = checkBox;
        }
    }
}
