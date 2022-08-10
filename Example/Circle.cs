using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    class Circle : Figure
    {
        public Circle()
        { }
        public double Radius { get; set; }
        public Circle(string name, string color, double radius) : base(name, color)
        { 
            this.Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
