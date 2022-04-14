using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Door
    {
        public string color { get; set; }
        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {color}");
        }

    }
}
