using ODD_Demo.Controls;

namespace ODD_Demo.Pages
{
    internal class CalculatorPage
    {
        #region Encapsulation

        protected Button AddButton { get; set; }

        protected Button ResetButton { get; set; }

        protected TextBox FirstNumberTextBox { get; set; }

        protected TextBox SecondNumberTextBox { get; set; }

        protected WebUIElement ResultTextBox { get; set; }

        #endregion

        public CalculatorPage()
        {
            ResultTextBox = new TextBox();
        }

        public void ClickOnAddButton()
        {
            AddButton.Click();
        }

        public void ClickOnResetButton()
        {
            ResetButton.Click();
        }

        public void SetFirstNumber(int value)
        {
            FirstNumberTextBox.Text = value.ToString();
        }

        public void SetSecondNumber(int value)
        {
            SecondNumberTextBox.Text = value.ToString();
        }

        public string GetResult()
        {
            return ResultTextBox.Text;
        }

        public bool IsResultVisible()
        {
            return ((TextBox)ResultTextBox).IsVisible();
        }
    }
}