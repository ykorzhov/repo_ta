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
        public BankAccount()
        {
        }
        public BankAccount(int accNumber, string ownName, decimal accBalance)
        {
            this.accountNumber = accNumber;
            this.ownerName = ownName;
            this.accountBalance = accBalance;
        }

        public decimal Display()
        { 
            return accountBalance;
        }
    }
}
