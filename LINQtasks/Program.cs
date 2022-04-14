using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 3.1
            //Write a program in C# to find the positive numbers from a list of numbers using:
            //'where' conditions in LINQ Query
            //use extension methods from System.Linq namespace
            Console.WriteLine("Task 3.1");

            List<int> numbers = new List<int>() { 1, -1, 2, 3, -3, 100, 101, -10, 0, -11, -2022, 33 };

            //option1
            var positiveNumbers1 = from p in numbers
                                  where p > 0
                                  //orderby p
                                  select p;
            foreach (int pn1 in positiveNumbers1)
            {
                Console.WriteLine(pn1);
            }
            Console.WriteLine();

            //option2
            IEnumerable<int> positiveNumbers2 = numbers.Where(p2 => p2 > 0);

            foreach (int pn2 in positiveNumbers2)
            {
                Console.WriteLine(pn2);
            }
            Console.ReadKey();

            ////task 3.2
            ////Write a program in C# to display the name of the days of a week from the list using: 
            ////Linq query and extension methods from System.Linq namespace
            Console.WriteLine("\r\nTask 3.2");

            List<string> daysOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //option1
            var showDaysOfWeek = from d in daysOfWeek
                                 select d;
            foreach (string dayNames in showDaysOfWeek)
            {
                Console.WriteLine(dayNames);
            }
            Console.WriteLine();

            //option2
            IEnumerable<string> showDaysOfWeek2 = daysOfWeek.Select(day => day); //day - because it loops through each element (1)
            foreach (string showDays in showDaysOfWeek2)
            {
                Console.WriteLine(showDays);
            }

            Console.ReadKey();

            //task 3.3
            //Write a program in C# to create a list of numbers and display the numbers greater than 20 using:
            //LINQ query
            //Extension methods from System.Linq namespace

            //option1
            Console.WriteLine("\r\nTask 3.3");

            var numbersGreaterThan20 = from g in numbers
                                       where g > 20
                                       select g;
            foreach (int g20 in numbersGreaterThan20)
            {
                Console.WriteLine(g20);
            }
            Console.WriteLine();

            //option2
            IEnumerable<int> greaterThan20 = numbers.Where(g2 => g2 > 20);

            foreach (int grt20 in greaterThan20)
            {
                Console.WriteLine(grt20);
            }
            Console.ReadKey();

            //task 3.4
            //Write a program in C# to arrange the distinct elements in the list in ascending order using:
            //LINQ query
            //Extension methods from System.Linq namespace
            Console.WriteLine("\r\nTask 3.4");

            List<int> numbers2 = new List<int>() { 1, -1, 1, -1, 100, 100, 2022, 2022, -2022 };
            IEnumerable<int> distinctElements = numbers2.Distinct();
          
            //option1
            var sortedNumbers = from n in distinctElements
                                orderby n
                                select n;

            foreach (int number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //option2
            IEnumerable<int> sortedNumbers2 = distinctElements.OrderBy(n => n);

            foreach (int number2 in sortedNumbers2)
            {
                Console.WriteLine(number2);
            }
            Console.ReadKey();

        }
    }
}
