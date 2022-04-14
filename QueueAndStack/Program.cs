using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAndStack
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Task 18.5 (1)
            ////Create a c# console application that implements a queue:
            ////Create a new queue of type int, named primes.
            ////Add the first 5 primes to the queue.
            ////Loop through the queue using a while loop, and add the next item to the total variable.
            ////After the loop, please write the total to the console using Console.WriteLine.

            //Queue<int> primes = new Queue<int>();
            //primes.Enqueue(1);
            //primes.Enqueue(2);
            //primes.Enqueue(3);
            //primes.Enqueue(40);
            //primes.Enqueue(50);
            //foreach (var p in primes)
            //{
            //    Console.WriteLine(p);
            //}
            //primes.Enqueue(600);
            //Console.WriteLine(primes.Count);
            //Console.ReadKey();

            ////Task 18.5 (2)
            //// Create a C# program that uses a Queue to store a list of people. 
            //// First, prepare a class called Person.cs with two properties (name and age) and a ToString() method to print the result.
            //// Then define a Queue and request the information(name and age) of three people from the user, you will have to store the information in the queue. 
            //// Remember that you can find the Queue object in the System.Collections namespace of the .NET Framework.
            //// To end the program, print the data of the people walking the queue.
            
            //Queue<Person> personQueue = new Queue<Person>();
            //do
            //{
            //    Console.WriteLine("Enter name of the person:");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Enter age of the person:");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    Person personQ1 = new Person(name, age);
            //    personQueue.Enqueue(personQ1);
            //}
            //while (personQueue.Count < 3);

            //foreach (var r in personQueue)
            //{
            //    Console.WriteLine(r.ToString());
            //}
            //Console.ReadKey();

            ////Task 18.6(1)
            //// Create a c# console application that implements a stack:
            //// Create a new stack of type string, named films.
            //// Add the film names to the stack.
            //// Loop through the stack using a do -while loop, and remove each item from it.
            //// Write each item to the Console using WriteLine.

            //Stack<string> films = new Stack<string>();
            //films.Push("DUNE");
            //films.Push("CODA");
            //films.Push("LICORICE PIZZA");
            //films.Push("THE POWER OF THE DOG");
            //films.Push("NIGHTMARE ALLEY");
            //Console.WriteLine($"Films count: {films.Count}");

            //do
            //{
            //    string result = films.Pop();
            //    Console.WriteLine(result);
            //}
            //while (films.Count > 0);

            //Console.WriteLine($"Films count: {films.Count}");
            //Console.ReadKey();

            ////Task 18.6 (2)
            ////Create a C# program that uses a Stack to store a list of people. 
            ////First, prepare a class called Person.cs with two properties (name and age) and a ToString() method to print the result.
            ////Then define a Stack and request the information(name and age) of three people from the user, you will have to store the information on the stack.
            ////Remember that you can find the Stack object in the System.Collections namespace of the .NET Framework.
            ////To end the program it prints the data of the people going through the stack.

            //Stack<Person> personStack = new Stack<Person>();
            //do
            //{
            //    Console.WriteLine("Enter name of the person:");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Enter age of the person:");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    Person personS1 = new Person(name, age);
            //    personStack.Push(personS1);
            //}
            //while (personStack.Count < 3);

            //foreach (var r in personStack)
            //{
            //    Console.WriteLine(r.ToString());
            //}
            //Console.ReadKey();

            // Task18.4
            // Create two HashSet<int> objects that populates integer numbers. 
            // Implement the following operations:
            // Modify the first set to contain only elements that are present in that object and in the second set.
            // Remove all elements from the first HashSet object that are equal to elements from the second HashSet.
            // Merge two sets.

            HashSet<int> firstSet = new HashSet<int>();

            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i < 10; i++)
            {
                // Populate numbers with just even numbers.
                firstSet.Add(i * 1);

                // Populate oddNumbers with just odd numbers.
                secondSet.Add((i * 2) + 1);
            }
            Console.WriteLine($"Number of elements in the first set: {firstSet.Count}");
            foreach (int first in firstSet)
            {
                Console.WriteLine(first);
            }
            Console.WriteLine($"Number of elements in the first set: {secondSet.Count}");
            foreach (int second in secondSet)
            {
                Console.WriteLine(second);
            }
            Console.WriteLine("Intersect");
            firstSet.IntersectWith(secondSet);
            foreach (int nIntersect in firstSet)
            {
                Console.WriteLine(nIntersect);
            }

            Console.WriteLine("Except");
            firstSet.ExceptWith(secondSet);
            foreach (int nExceptWith in firstSet)
            {
                Console.WriteLine(nExceptWith);
            }

            Console.WriteLine("Union");
            firstSet.UnionWith(secondSet);
            foreach (int nUnion in firstSet)
            {
                Console.WriteLine(nUnion);
            }

            Console.ReadKey();
        }
    }
}
