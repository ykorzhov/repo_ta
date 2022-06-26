using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
                        //locator                                       //selector

        private IWebElement SecondNumberTextBox => Driver.FindElement(By.Id("second-number"));

        private IWebElement ResultTextBox => Driver.FindElement(By.Id("result"));
        private IWebElement AddButton => Driver.FindElement(By.Id("add-button"));

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

        public void ClickAddButton()
        { 
            AddButton.Click();
        }

        public string GetResultTextBox()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(e => e.FindElement(By.Id("result")).GetAttribute("value") != string.Empty);

            return ResultTextBox.GetAttribute("value");
        }


        public bool FirstNumberTextBoxIsEmpty()
        {
            var firstNumberTextBox = Driver.FindElement(By.Id("first-number"));
            return firstNumberTextBox.GetAttribute("value").Length == 0;
        }
    }
}
