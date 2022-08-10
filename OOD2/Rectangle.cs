using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD2
{
    class Rectangle : Shape
    {
        public override void Show()
        {
            Console.WriteLine("Showing message from child (rectangle) class");
        }
    }
}
