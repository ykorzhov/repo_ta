using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task18.1
            //Create a C# program with the next conditions:
            //Create a new string list with no values.
            //Add the item "Luke Skywalker" to the list and write this item to the Console.
            //Add the items "Han Solo" and "Chewbacca" to the list and remove the item "Luke Skywalker" from the list using the value itself.
            //Remove any item from the list using its index.
            //Create a foreach loop after the list declaration, and loop through the values, writing each to the console.

            //List<string> starWars = new List<string>();
            //starWars.Add("Luke Skywalker");
            //Console.WriteLine(starWars[0]);

            //Console.WriteLine("...");

            //starWars.Add("Han Solo"); // we can add only 1 string here?
            //starWars.Add("Chewbacca");
            //starWars.Add("Princess Leia");
            //starWars.Remove("Luke Skywalker");
            //starWars.RemoveAt(0);

            //foreach (string starWarsCharacters in starWars)
            //{
            //    Console.WriteLine(starWarsCharacters);
            //}

            //Console.ReadKey();
            //Console.WriteLine("...");

            //task18.2
            //Create a C# program with the following conditions:
            //Create a new dictionary, where the key type is a string, and the value type is an int.This dictionary should contain no values.
            //Add a new value, the key of which is your name, and the value of which is your age. Do this using the Add method.
            //Add another value to the dictionary using the index notation.This time, use a different name and a different age.
            //Lastly, read the first item you added to the dictionary, and write it to the console.
            //Remove the second item from the dictionary.
            //Create a foreach loop after the dictionary declaration and loop through the items, writing the Value to the console using Console.WriteLine.

            //Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            //myDictionary.Add("Yana", 27);
            //myDictionary["John"] = 10;
            //myDictionary["Vasyl"] = 50;

            //Console.WriteLine($"Key: {myDictionary.First().Key}, value: {myDictionary["Yana"]}");

            //myDictionary.Remove("John");

            //foreach (KeyValuePair<string, int> kvp in myDictionary)
            //{
            //    Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            //}
            //Console.ReadKey();


            //Task18.3
            //Create a class "Point3D" to represent a point in 3-D space, with coordinates X, Y, and Z.
            //Create a program with a menu, in which the user can choose to:
            //- Add data for one point
            //- Display all the entered points
            //- Exit the program
            //You MUST use List to collect entered points.

            List<Point3D> points = new List<Point3D>();

            int choice;
            do
            {
                Console.WriteLine("Welcome!" +
                "\r\nPress 1 to enter coordinates for a point." +
                "\r\nPress 2 to display all entered points." +
                "\r\nPress anything else to quit the program.");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Enter coordinates of a point:");
                    double x = Convert.ToDouble(Console.ReadLine());
                    double y = Convert.ToDouble(Console.ReadLine());
                    double z = Convert.ToDouble(Console.ReadLine());
 
                    var point = new Point3D(x, y, z); // 1 line of code should only invoke 1 method
                    points.Add(point);
                }

                else if (choice == 2)
                {
                    if (points.Count > 0)
                    {
                        foreach (var p in points)
                        {
                            p.ShowPoints();
                        }
                    }
                    else
                    {
                        Console.WriteLine("At first enter at least 1 point");
                    }
                }
            }
            while (choice == 1 || choice == 2);

        }
    }
}
