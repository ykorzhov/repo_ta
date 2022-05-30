using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////task 2. Multiplication table for numbers 2 and 3 using loops
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine($"2 * {i} = {2 * i}");
            //}
            //Console.ReadKey();

            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine($"3 * {i} = {3 * i}");
            //}
            //Console.ReadKey();

            ////task 3 
            //Console.WriteLine("Enter number 1: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter integer 2: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Results:");
            //Console.WriteLine("Sum: {0} + {1} = {2}", a, b, a + b);
            //int c = a - b;
            //Console.WriteLine($"Subtraction: {a} - {b} = {c}");
            //Console.WriteLine("Multiplication: {0} * {1} = {2}", a, b, a * b);
            //Console.WriteLine("Division: {0} / {1} = {2}", a, b, a / b);
            //Console.ReadKey();

            ////task 4. Write a program in C# to read N numbers from the keyboard and find their sum and average.

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

            ////task 5.Write a program to display in the console every second element of the array with length = 12.

            //int[] newArray = new int[12] { 1, 11, 3, 11, 5, 11, 7, 8, 9, 10, 11, 12 };
            //for (int i = 1; i < 12; i += 2)
            //{
            //    Console.WriteLine($"{newArray[i]}");
            //}
            //Console.ReadKey();

            //string[] newStr = new string[12] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l" };
            //for (int i = 1; i < 12; i += 2)
            //{
            //    Console.WriteLine($"{newStr[i]}");
            //}
            //Console.ReadKey();

            ////task  6. Write a program in C# to print individual characters of the string in reverse order (use loop for, do-while).

            //Console.WriteLine("Enter a string:");
            //string enteredString = Console.ReadLine();
            //for (int i = enteredString.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(enteredString[i]);
            //}
            //Console.ReadLine();

            //Console.WriteLine("Enter another string:");
            //string enteredString2 = Console.ReadLine();
            //int j = enteredString2.Length - 1;
            //do
            //{
            //    Console.Write(enteredString2[j]);
            //    j--;
            //}
            //while (j >= 0);

            //Console.ReadLine();

            //9.Task 9: Write a program to display a multiplication table(for numbers 2 and 3) using nested loops
            for (int j = 2; j < 4; j++)
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine($"{j} * {i} = {j * i}");
                }
            }
            Console.ReadLine();

        }

    }
}
