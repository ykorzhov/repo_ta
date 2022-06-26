using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace PageObject_Demo
{
    public class Tests
    {
        private ChromeDriver driver;
        private CalculatorPageObject pageObject;
        private CalculatorPageObjectV2 pageObjectV2;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            pageObject = new CalculatorPageObject(driver);
            pageObjectV2 = new CalculatorPageObjectV2(driver);

            driver.Url = "https://specflowoss.github.io/Calculator-Demo/Calculator.html";
        }

        //[Test]
        //public void Test_Page_Object_pattern()
        //{
        //    pageObject.SetFirstNumber("3");

        //    // Note: it was a sample of breaking encapsulation principle.
        //    //pageObject.FirstNumberTextBox.Click();
        //    //pageObject.FirstNumberTextBox.SendKeys("10");

        //    //

        //    Assert.False(pageObject.FirstNumberTextBoxIsEmpty());
        //}

        [Test]
        [TestCase("1", "1", "2")]
        [TestCase("-1", "0", "-2")]
        public void TestAddingNumbers(string a, string b, string c)
        {
            pageObjectV2.Numbers.SetFirstNumber(a);
            pageObjectV2.Numbers.SetSecondNumber(b);
            pageObjectV2.Numbers.ClickAddButton();
            
            var result = pageObjectV2.Numbers.GetResultTextBox();

            Assert.AreEqual(c, result, "Sum is not correct");
            // expected result should go first, before actual result
        }
        [TestCase("1", "2", ExpectedResult = "4")]
        public string TestAddingNumbers_2(string a, string b)
        {
            pageObjectV2.Numbers.SetFirstNumber(a);
            pageObjectV2.Numbers.SetSecondNumber(b);
            pageObjectV2.Numbers.ClickAddButton();

            var result = pageObjectV2.Numbers.GetResultTextBox();

            return result;

        }

        //public void Test_PageComponent_class()
        //{
        //    pageObjectV2.Numbers.SetFirstNumber("3");

        //    Assert.False(pageObjectV2.Numbers.FirstNumberTextBoxIsEmpty());
        //}

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}