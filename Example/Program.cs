
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle()
            { Name = "Circle" };
            Console.WriteLine($"What is the color of {circle.Name}?");
            circle.Color = Console.ReadLine();
            Console.WriteLine($"What is the radius of {circle.Name}?");
            circle.Radius = Convert.ToDouble(Console.ReadLine());

            Square square = new Square()
            { Name = "Square" };
            Console.WriteLine($"What is the color of {square.Name}?");
            square.Color = Console.ReadLine();
            Console.WriteLine($"What is the side of {square.Name}?");
            square.Side = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle()
            { Name = "Rectangle" };
            Console.WriteLine($"What is the color of {rectangle.Name}?");
            rectangle.Color = Console.ReadLine();
            Console.WriteLine($"What is the lenght of {rectangle.Name}?");
            rectangle.Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"What is the width of {rectangle.Name}?");
            rectangle.Width = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"{circle.Name} is {circle.Color}, its area is {circle.Area()}");
            Console.WriteLine($"{square.Name} is {square.Color}, its area is {square.Area()}");
            Console.WriteLine($"{rectangle.Name} is {rectangle.Color}, its area is {rectangle.Area()}");
            Console.ReadLine();

            Figure figure = new Circle();
            (figure as Circle).Radius = 10; //безпечне приведення до типу (якщо не можна привести, то результат приведення буде null) -- 
            ((Circle)figure).Radius = 10; //якщо не можна привести, ми отримаємо ексепшн, тому небезпечне :) -- explicit casting


        }
    }
}
