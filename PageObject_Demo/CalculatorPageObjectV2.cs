using OpenQA.Selenium;
using PageObject_Demo.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject_Demo
{
    internal class CalculatorPageObjectV2
    {
        private IWebDriver Driver { get; }

        public InputNumbersComponent Numbers { get; }

        public CalculatorPageObjectV2(IWebDriver driver)
        {
            Driver = driver;

            Numbers = new InputNumbersComponent(Driver);
        }

    }
}
