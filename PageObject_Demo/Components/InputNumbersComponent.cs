using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject_Demo.Components
{
    internal class InputNumbersComponent
    {
        private IWebDriver Driver { get; }

        private IWebElement FirstNumberTextBox => Driver.FindElement(By.Id("first-number"));

        private IWebElement SecondNumberTextBox => Driver.FindElement(By.Id("second-number"));

        public InputNumbersComponent(IWebDriver driver)
        {
            Driver = driver;
        }

        public void SetFirstNumber(string number)
        {
            FirstNumberTextBox.Clear();
            FirstNumberTextBox.SendKeys(number);
        }

        public void SetSecondNumber(string number)
        {
            SecondNumberTextBox.Clear();
            SecondNumberTextBox.SendKeys(number);
        }

        public bool FirstNumberTextBoxIsEmpty()
        {
            var elem = FirstNumberTextBox;
            var first = elem.Text;
            return FirstNumberTextBox.Text.Length == 0;
        }
    }
}
