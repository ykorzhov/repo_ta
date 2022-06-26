using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD2
{
    class Circle : Shape
    {
        public override void Show()
        {
            Console.WriteLine("Showing message from child (circle) class");
        }
    }
}
