using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndLists
{
    class Point3D
    {
        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void ShowPoints()
        {
            Console.WriteLine($"x = {x}, y = {y}, z = {z}.");
        }
    }
}
