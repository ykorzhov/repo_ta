using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            var doorGreen = new Door();
            doorGreen.color = "green";
            var apartment = new SmallApartment { door = doorGreen };
            var person = new Person 
            { 
                name = "Yana",
                house = apartment 
            };


            person.ShowData();
            Console.ReadKey();
        }
    }
}
