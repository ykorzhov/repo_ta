using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Person
    {
        public string name; //every public filed/method/property should start with capital letter 

        public House house;
        public void ShowData()
        {
            Console.WriteLine($"Person's name: {name}.");
            house.ShowData();
            house.door.ShowData();
        }
    }
}
