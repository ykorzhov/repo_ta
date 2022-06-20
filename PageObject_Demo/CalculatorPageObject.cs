using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject_Demo
{
    internal class CalculatorPageObject
    {
        private readonly IWebDriver driver;

        // By.Id("first-number") - locator
        // "first-number" - selector
        // FirstNumberTextBox - UI element represented as property in Page Object class. Should be private.
        private IWebElement FirstNumberTextBox => driver.FindElement(By.Id("first-number"));

        private IWebElement SecondNumberTextBox => driver.FindElement(By.Id("second-number"));

        public CalculatorPageObject(IWebDriver driver)
        {
            this.driver = driver;
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
            return FirstNumberTextBox.Text.Length == 0;
        }
    }
}
