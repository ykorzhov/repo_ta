using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 3


            ////4. Enter a sequense of posistive integers (to the first negative). Calculate the arithmetic average of the entered numbers
            //int n;
            //int[] enteredIntegers = new int[n];
            //Console.WriteLine("Enter your integers:");
            //while ()
            //{
            //    enteredIntegers[i] = Convert.ToInt32(Console.ReadLine());

            //}

            //5 Check whether the entered year is a leap. 
            Console.WriteLine("Enter a year");
            int year = Convert.ToInt32(Console.ReadLine());
            if( year % 4 == 0)
            {
                    Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
            Console.ReadKey();

            ////6 Find the sum of the digits of the entered integer number;
            Console.WriteLine("Enter an integer:");
            int enteredInt = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (enteredInt !=0)
            {
                sum += enteredInt[i];
            }
            Console.WriteLine($"{sum}");
            Console.ReadLine();

            ////7 Check whether the entered integer numbers contains only odd numbers
            //Console.WriteLine("Enter an integer");




            //Console.WriteLine("How many numbers do you want to enter?");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Enter {n} numbers, press Return after each number:");
            //int[] arrayOfNumbers = new int[n];
            //double sum = 0;
            //for (int i = 0; i < arrayOfNumbers.Length; i++)
            //{
            //    arrayOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += arrayOfNumbers[i];
            //}
            //Console.WriteLine($"Sum is {sum}");
            //double avg = sum / n;
            //Console.WriteLine($"Average number is {avg}");
            //Console.ReadKey();


        }
    }
}
