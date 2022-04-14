using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //task 7. Write a program in C# to display odd and even integers in the given array.
            //int[] nums = new int[10] { 10, 22, 2, 4, 9, 6, 70, 80, 99, 0 };
            //for (int i = 0; i < 10; i++)
            //{
            //    if (nums[i] % 2 == 0 && nums[i] != 0)
            //    {
            //        Console.WriteLine($"The number {nums[i]} is even");
            //    }
            //    else if ((nums[i] == 0))
            //    {
            //        Console.WriteLine($"The number {nums[i]} is neither even, nor odd");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"The number {nums[i]} is odd");
            //    }
            //}
            //Console.ReadLine();


            //task 8. Write a program in C# to display all positive numbers (> 0) in the given array
            int[] myNums = new int[10] { -10, -9, -1, 0, 1, 6, 10, 80, 99, -100 };
            Console.WriteLine("Positive numbers: ");
            for (int i = 0; i < 10; i++)
            {
                if (myNums[i] > 0 && myNums[i] != 0)
                {
                    Console.Write($"{myNums[i]} ");
                }
            }
            Console.ReadKey();
        }
    }
}
