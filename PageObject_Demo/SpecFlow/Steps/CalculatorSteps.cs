using NUnit.Framework;
using PageObject_Demo.SpecFlow.TestDataModels;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Linq;
using System;

namespace PageObject_Demo.SpecFlow.Steps
{
    [Binding]
    internal class CalculatorSteps
    {
        public Number Numbers { get; set; }

        public dynamic DynamicEntity { get; set; }

        public int sum;

        public CalculatorSteps()
        {
            Numbers = new Number();
        }

        [Given(@"the table with numbers")]
        public void GivenTheTableWithNumbers(Table table)
        {
            //var set = table.CreateSet<Number>().ToList();
            //var count = set.Count;
            //Numbers = set.ElementAt(new Random().Next(0, count - 1));

            Numbers = table.CreateInstance<Number>();

            DynamicEntity = table.CreateDynamicInstance();

            var first = DynamicEntity.firstNumber;
            var second = DynamicEntity.secondNumber;
        }

        [When(@"the two numbers from the table are added")]
        public void WhenTheTwoNumbersFromTheTableAreAdded()
        {
            sum = Numbers.FirstNumber + Numbers.SecondNumber;
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(string expectedSum)
        {
            //var expectedSum = Numbers.FirstNumber + Numbers.SecondNumber;
            Assert.AreEqual(expectedSum, sum);
        }

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
        }

    }
}
