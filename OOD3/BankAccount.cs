using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD3
{
    internal class BankAccount
    {
        private int accountNumber;
        private string ownerName;
        private decimal accountBalance;
        public int AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
        public string OwnerName { get { return ownerName; } set { ownerName = value; } }
        public decimal AccountBalance { get { return accountBalance; } set { accountBalance = value; } }

        public BankAccount(int accNumber, string ownName, decimal accBalance)
        {
            this.accountNumber = accNumber;
            this.ownerName = ownName;
            this.accountBalance = accBalance;
        }
        public decimal Deposit(decimal amount)
        {
            return accountBalance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            if (amount <= 0 || this.accountBalance - amount < 0)
            {
                Console.WriteLine("You can't withdraw more than you have in your account:");
                return accountBalance;
            }
            else
            {
                Console.WriteLine("Bank fees are 5% after each withdrawal");
                return accountBalance -= amount + amount * 0.05m;
            }
            
        }

        public void Display()
        {
            Console.WriteLine($"Account number: {AccountNumber}, owner's name: {OwnerName}, balance: {AccountBalance}");
        }
        //public decimal BankFees()
        //{
        //    return accountBalance = (decimal)((double)accountBalance * 0.95);
        //}
    }
}
