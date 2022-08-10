using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD2
{
    class Shape
    {
        public virtual void Show()
        {
            Console.WriteLine("Showing message from parent (shape) class");
        }

        public void GetInfo()
        {
            Console.WriteLine("Returning the name of the class: Shape");
        }

        public void GetInfo2()
        { 
            Shape obj = new Shape();
            Console.WriteLine(obj.ToString());
        }
    }
}
