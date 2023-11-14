using System.Collections.Generic;

namespace MaterialDesignBoxes
{
    public class IconDisplayer
    {
        private readonly IList<IIconDisplay> _displayRules;

        public IconDisplayer()
        {
            _displayRules = new List<IIconDisplay>() { new Default(), new Information(), new Question(), new Warning(), new Error() };
        }

        public void Display(MessageBoxIcon icon, MessageBoxWindow messageBox)
        {
            foreach (IIconDisplay displayRule in _displayRules)
            {
                if (displayRule.Icon == icon)
                    displayRule.Display(messageBox);
            }
        }
    }

    public interface IIconDisplay
    {
        void Display(MessageBoxWindow messageBox);

        MessageBoxIcon Icon { get; }
    }

    public class Default : IIconDisplay
    {
        public void Display(MessageBoxWindow messageBox)
        {
            messageBox.MessageBoxIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.MessageText;
        }

        public MessageBoxIcon Icon => MessageBoxIcon.Default;
    }

    public class Information : IIconDisplay
    {
        public void Display(MessageBoxWindow messageBox)
        {
            messageBox.MessageBoxIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Information;
        }

        public MessageBoxIcon Icon => MessageBoxIcon.Information;
    }

    public class Question : IIconDisplay
    {
        public void Display(MessageBoxWindow messageBox)
        {
            messageBox.MessageBoxIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.HelpCircle;
        }

        public MessageBoxIcon Icon => MessageBoxIcon.Question;
    }

    public class Warning : IIconDisplay
    {
        public void Display(MessageBoxWindow messageBox)
        {
            messageBox.MessageBoxIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Warning;
        }

        public MessageBoxIcon Icon => MessageBoxIcon.Warning;
    }

    public class Error : IIconDisplay
    {
        public void Display(MessageBoxWindow messageBox)
        {
            messageBox.MessageBoxIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.CloseCircle;
        }

        public MessageBoxIcon Icon => MessageBoxIcon.Error;
    }
}
