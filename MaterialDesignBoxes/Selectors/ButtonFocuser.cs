using System.Collections.Generic;
using System.Windows.Controls;

namespace MaterialDesignBoxes
{
    public class ButtonsFocuser
    {
        private readonly IList<IButtonsFocus> _focusRules;

        public ButtonsFocuser()
        {
            _focusRules = new List<IButtonsFocus>() { new NoneFocus(), new Button1Focus(), new Button2Focus(), new Button3Focus() };
        }

        public void Focus(MessageBoxFocus button, MessageBoxWindow messageBox)
        {
            foreach (IButtonsFocus focusRule in _focusRules)
            {
                if (focusRule.Button == button)
                    focusRule.Focus(messageBox);
            }
        }
    }

    public class Focuser
    {
        public void Set(Button button1, Button button2, Button button3)
        {
            button1.Background = BrushColor.FromHex("#969696");
            button2.Background = BrushColor.FromHex("#969696");
            button3.Focus();
        }
    }

    public interface IButtonsFocus
    {
        void Focus(MessageBoxWindow messageBox);

        MessageBoxFocus Button { get; }
    }

    public class NoneFocus : IButtonsFocus
    {
        public void Focus(MessageBoxWindow messageBox) { }

        public MessageBoxFocus Button => MessageBoxFocus.None;
    }

    public class Button1Focus : IButtonsFocus
    {
        private Focuser _focuser = new Focuser();

        public void Focus(MessageBoxWindow messageBox)
        {
            _focuser.Set(messageBox.Button2, messageBox.Button3, messageBox.Button1);
        }

        public MessageBoxFocus Button => MessageBoxFocus.Button1;
    }

    public class Button2Focus : IButtonsFocus
    {
        private Focuser _focuser = new Focuser();

        public void Focus(MessageBoxWindow messageBox)
        {
            _focuser.Set(messageBox.Button1, messageBox.Button3, messageBox.Button2);
        }

        public MessageBoxFocus Button => MessageBoxFocus.Button2;

        public Focuser Focuser { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }

    public class Button3Focus : IButtonsFocus
    {
        private Focuser _focuser = new Focuser();

        public void Focus(MessageBoxWindow messageBox)
        {
            _focuser.Set(messageBox.Button1, messageBox.Button2, messageBox.Button3);
        }

        public MessageBoxFocus Button => MessageBoxFocus.Button3;
    }
}
