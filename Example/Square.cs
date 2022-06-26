using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    class Square : Figure
    {
        public Square()
        { }
        public double Side { get; set; }
        public Square(string name, string color, double side) : base(name, color)
        {
            this.Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }
}
