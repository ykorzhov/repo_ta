using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class House
    {
        public int area { get; set; }
        public House()
        { }
        public House(int area)
        {
            this.area = area;
        }
        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {area} m2");
        }
        public Door door;
        public Door GetDoor()
        {
            return door;
        }

    }
}
