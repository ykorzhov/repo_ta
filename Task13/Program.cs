using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Person NewPerson = new Person();
            Console.WriteLine("New person says:");
            NewPerson.Greet();
            Console.ReadLine();

            Student Yana = new Student();
            Console.WriteLine("Yana says:");
            Yana.SetAge(22);
            Yana.Greet();
            Yana.ShowAge();
            Yana.Study();
            Console.ReadLine();

            Teacher MrDmytro = new Teacher();
            MrDmytro.SetAge(18);
            Console.WriteLine("Mr Dmytro says:");
            MrDmytro.Greet();
            MrDmytro.Explain();
            
            Console.ReadKey();


        }
    }
}
