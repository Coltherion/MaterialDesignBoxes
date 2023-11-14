using System.Collections.Generic;

namespace MaterialDesignBoxes
{
    public class ResultSetter
    {
        private readonly IList<IButtonsResult> _resultRules;

        public ResultSetter()
        {
            _resultRules = new List<IButtonsResult>() { new OK(), new Cancel(), new Yes(), new No(), new Button1(), new Button2(), new Button3() };
        }

        public void SetResult(MessageBoxWindow messageBox, string buttonContent, string buttonName)
        {
            foreach (IButtonsResult resultRule in _resultRules)
            {
                if (resultRule.ButtonContent == buttonContent)
                {
                    resultRule.SetResult(messageBox);
                    return;
                }
            }

            foreach (IButtonsResult resultRule in _resultRules)
            {
                if (resultRule.ButtonName == buttonName)
                    resultRule.SetResult(messageBox);
            }
        }
    }

    public interface IButtonsResult
    {
        void SetResult(MessageBoxWindow messageBox);

        string ButtonContent { get; }
        string ButtonName { get; }
    }

    public class OK : IButtonsResult
    {
        public void SetResult(MessageBoxWindow messageBox)
        {
            messageBox.Outcome.Result = MessageBoxResult.OK;
        }

        public string ButtonContent => "OK";
        public string ButtonName => string.Empty;
    }

    public class Cancel : IButtonsResult
    {
        public void SetResult(MessageBoxWindow messageBox)
        {
            messageBox.Outcome.Result = MessageBoxResult.Cancel;
        }

        public string ButtonContent => "Cancel";
        public string ButtonName => string.Empty;
    }

    public class Yes : IButtonsResult
    {
        public void SetResult(MessageBoxWindow messageBox)
        {
            messageBox.Outcome.Result = MessageBoxResult.Yes;
        }

        public string ButtonContent => "Yes";
        public string ButtonName => string.Empty;
    }

    public class No : IButtonsResult
    {
        public void SetResult(MessageBoxWindow messageBox)
        {
            messageBox.Outcome.Result = MessageBoxResult.No;
        }

        public string ButtonContent => "No";
        public string ButtonName => string.Empty;
    }

    public class Button1 : IButtonsResult
    {
        public void SetResult(MessageBoxWindow messageBox)
        {
            messageBox.Outcome.Result = MessageBoxResult.Button1;
        }

        public string ButtonContent => string.Empty;
        public string ButtonName => "Button1";
    }

    public class Button2 : IButtonsResult
    {
        public void SetResult(MessageBoxWindow messageBox)
        {
            messageBox.Outcome.Result = MessageBoxResult.Button2;
        }

        public string ButtonContent => string.Empty;
        public string ButtonName => "Button2";
    }

    public class Button3 : IButtonsResult
    {
        public void SetResult(MessageBoxWindow messageBox)
        {
            messageBox.Outcome.Result = MessageBoxResult.Button3;
        }

        public string ButtonContent => string.Empty;
        public string ButtonName => "Button3";
    }
}
