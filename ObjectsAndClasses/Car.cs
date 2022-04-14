using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClasses
{
    class Car
    {
        // variant 1
        //private string color;
        //private string brand;
        private int age;

        //public void SetAge(int age)
        //{
        //    this.age = age;
        //}
        //public int GetAge()
        //{
        //    return age;
        //}

        //public void SetColor(string color)
        //{
        //    this.color = color;
        //}
        //public string GetColor()
        //{
        //    return color;
        //}
        //public void SetBrand(string brand)
        //{
        //    this.brand = brand;
        //}
        //public string GetBrand()
        //{
        //    return brand;
        //}

        //// variant 2
        //internal string color;
        //internal string brand;
        //internal int age;

        //public void Print()
        //{
        //    Console.WriteLine($"{color} {brand} is {age} years old");
        //}

        // variant 3 with default properties
        public string Color { get; set; }
        public string Brand { get; set; }
        // not default property 
        public int Age { get { return age; } set { age = value; } }

        //override - перевизначити метод з базового класу (System.Object)
        //ToString по дефолту вертає повну назву типу - це Namespace + ім'я класу, наприклад, ObjectsAndClasses.Car
        public override string ToString()
        {
            return $"{Color} {Brand} is {Age} years old";
        }

        //сигнатура проперті(властивості):
        //[access modifier] [return type] [propery name] {get;set;}
        public Person Driver { get; set; }

    }
}
