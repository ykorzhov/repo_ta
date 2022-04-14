using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The first name is" + " Yana"); 
            
            //будь-яка маніпуляція зі стрінгом призводить до створення нового об'єкту і  виділення пам'яті під нього.
            //class StringBuilder - це класс, що дозволяє маніпулювати стрічкою без виділення додаткової пам'яті, тобто пам'ять виділяється 1 раз


            //task 11. Add console application and use StringBuilder to create and manipulate with string values
            string stringMy = "my";
            string stringName = "name";
            string stringIs = "is";
            string userName = "Yana";

            StringBuilder sb = new StringBuilder();
            Console.WriteLine($"Length: {sb.Length}");
            Console.WriteLine($"Capacity: {sb.Capacity}");

            sb.Append($"{stringMy} {stringName} {stringIs} {userName}");
            Console.WriteLine(sb);
            sb.Replace("Yana", "Ann");  //replace Yana with Ann
            Console.WriteLine(sb);
            sb.Insert(11, "not ");     //insert "not" starting with symbol with index [11]
            Console.WriteLine(sb);
            Console.WriteLine($"Length: {sb.Length}");
            Console.WriteLine($"Capacity: {sb.Capacity}");
            sb.Remove(0, 11);          //starting with symbol [0] we remove 11 symbols
            Console.WriteLine(sb);
            sb.AppendFormat("!");      //insert "!" at the end of the string
            Console.WriteLine(sb);

            Console.WriteLine($"Length: {sb.Length}");
            Console.WriteLine($"Capacity: {sb.Capacity}");

            Console.ReadKey();
        }
    }
}
