using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration = initialization ;  ініціалізація об'єктів референс типу (класу) відбувається через ключове слово new; після new зазначаємо назву класу + дужки = виклик конструктора класу
            //конструктор класу - метод, який створює об'єкт і резервує пам'ять під нього
            //Person Yana = new Person();
            //Yana.SetAge(27);
            //Console.WriteLine(Yana.GetAge());
            //Console.ReadKey();


            //// variant 1
            //Car myCar = new Car();
            //myCar.SetAge(10);
            //myCar.SetBrand("Audi");
            //myCar.SetColor("silver");

            //Console.WriteLine($"My car is {myCar.GetColor()} {myCar.GetBrand()}, it is {myCar.GetAge()} years old");

            //Car yourCar = new Car();
            //yourCar.SetAge(3);
            //yourCar.SetBrand("KIA");
            //yourCar.SetColor("white");

            //Console.WriteLine($"Your car is {yourCar.GetColor()} {yourCar.GetBrand()}, it is {yourCar.GetAge()} years old");
            //Console.ReadKey();

            ////reading from console
            //Car ourCar = new Car();
            //Console.WriteLine("Type brand:");
            //ourCar.SetBrand(Console.ReadLine());
            //Console.WriteLine("Type color:");
            //ourCar.SetColor(Console.ReadLine());
            //Console.WriteLine("Type age of the car:");
            //ourCar.SetAge(Convert.ToInt32(Console.ReadLine()));

            //Console.WriteLine($"The car is {ourCar.GetColor()} {ourCar.GetBrand()}, it is {ourCar.GetAge()} years old");
            //Console.ReadKey();

            //// variant 2
            //Car firstCar = new Car();
            //firstCar.color = "black";
            //firstCar.age = 2;
            //firstCar.brand = "Tesla";

            //firstCar.Print();
            //Console.WriteLine();

            //Car secondCar = new Car();
            //firstCar.color = "silver";
            //firstCar.age = 5;
            //firstCar.brand = "Jeep";

            //firstCar.Print();
            //Console.ReadKey();

            //variant 3

            //Car carOne = new Car();
            //carOne.Age = 5;
            //carOne.Brand = "Audi";
            //carOne.Color = "yellow";
            //carOne.Driver = new Person();
            //carOne.Driver.FirstName = "John";
            //carOne.Driver.LastName = "Doe";

            //Console.WriteLine(carOne);
            //Console.WriteLine(carOne.Driver);
            //Console.WriteLine("The first name is" + " Yana"); //будь-яка маніпуляція зі стрінгом призводить до створення нового об'єкту і  виділення пам'яті під нього.
            //// class StringBuilder - це класс, що дозволяє маніпулювати стрічкою без виділення додаткової пам'яті, тобто пам'ять виділяється 1 раз
            //Console.ReadKey();

            //Task 12.  
            Animal dog = new Animal();
            dog.SetPetName("Doggo");
            dog.SetAge(2);

            Animal cat = new Animal();
            cat.SetPetName("Barsik");
            cat.SetAge(3);

            Animal parrot = new Animal();
            parrot.SetPetName("Kesha");
            parrot.SetAge(5);

            Console.WriteLine($"There are these animals: {cat}, {dog} and {parrot}");
            Console.WriteLine($"Info about cat: name is {cat.GetPetName()}, age is {cat.GetAge()}");
            Console.WriteLine($"Info about dog: name is {dog.GetPetName()}, age is {dog.GetAge()}");
            Console.WriteLine($"Info about parrot: name is {parrot.GetPetName()}, age is {parrot.GetAge()}");
            Console.ReadKey();



        }
    }

}
