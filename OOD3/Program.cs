using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Enter your name to create a bank account:");
            var ownName = Console.ReadLine();

            BankAccount account0001 = new BankAccount(1, ownName, 0);
            Console.WriteLine("Your account has been created");
            account0001.Display();
            Console.WriteLine("_____");

            int choice = 0;
            bool exit = false;
            do
            {
                //Console.Clear();
                Console.WriteLine("Choose your action:");
                Console.WriteLine("1. Deposit money;");
                Console.WriteLine("2. Withdraw money;");
                Console.WriteLine("3. View balance;");
                Console.WriteLine("4. Exit bank account");

                switch (choice = Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Enter amount to deposit:");
                        decimal amount = Convert.ToDecimal(Console.ReadLine());
                        account0001.Deposit(amount);
                        exit = false;
                        break;

                    case 2:
                        Console.WriteLine("Enter amount to withdraw:");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        account0001.Withdraw(amount);
                        //account0001.BankFees();
                        exit = false;
                        break;

                    case 3:
                        account0001.Display();
                        exit = false;
                        break;

                    case 4:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("You need to choose one of the options specified in menu");
                        break;

                }
            }
            while (exit != true);

            Console.ReadKey();

            //public BankAccount(int accNumber, string ownName, decimal accBalance)
        }
    }
}