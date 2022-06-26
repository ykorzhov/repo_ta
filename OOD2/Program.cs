using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD2
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape shape = new Shape();
            shape.Show();

            Circle circle = new Circle();
            circle.Show();

            Rectangle rectangle = new Rectangle();
            rectangle.Show();

            shape.GetInfo();
            circle.GetInfo();
            rectangle.GetInfo();

            shape.GetInfo2();
            rectangle.GetInfo2();

            Console.ReadKey();



        }
    }
}