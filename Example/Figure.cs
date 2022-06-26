using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    abstract class Figure
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public abstract double Area();

        public Figure()
        { }

        public Figure(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }
}
