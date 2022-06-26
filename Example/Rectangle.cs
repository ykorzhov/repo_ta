using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD

{
    class Rectangle : Figure
    {
        public Rectangle()
        { }
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(string name, string color, double lenght, double width) : base(name, color)
        {
            this.Width = width;
            this.Length = lenght;
        }

        public override double Area()
        {
            return Width * Length;
        }
    }
}
