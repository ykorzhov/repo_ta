using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Person
    {
        //The Person class must have two public methods Greet() and SetAge(int age) that will assign the age of the person.

        protected int age;
        public void SetAge(int age)
        {
            this.age = age; // 
        }

        public void Greet()
        {
            Console.WriteLine("Greetings!");
        }

    }
}
