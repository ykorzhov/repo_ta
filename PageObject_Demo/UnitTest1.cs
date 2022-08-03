using NUnit.Framework;
using OpenQA.Selenium.Chrome;

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

        [Test]
        public void Test_Page_Object_pattern()
        {
            pageObject.SetFirstNumber("3");

            // Note: it was a sample of breaking encapsulation principle.
            //pageObject.FirstNumberTextBox.Click();
            //pageObject.FirstNumberTextBox.SendKeys("10");

            //

            Assert.False(pageObject.FirstNumberTextBoxIsEmpty());
        }

        [Test]
        public void Test_PageComponent_class()
        {
            pageObjectV2.Numbers.SetFirstNumber("3");

            System.Threading.Thread.Sleep(1000);

            Assert.False(pageObjectV2.Numbers.FirstNumberTextBoxIsEmpty());
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}