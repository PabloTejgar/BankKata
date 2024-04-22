using System;
using System.Collections.Generic;
using System.Text;

namespace BankKata
{
    public class Account


    {
        public int Balance { get; private set; }
        private IConsole console;

        public Account(int initialBalance, IConsole consoleInstance)
        {
            Balance = initialBalance;
            console = consoleInstance;
        }

        public void Deposit(int amount)
        {
            Balance += amount;
        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
        }

        public void PrintStatement()
        {
            console.PrintLine("date       || credit   || debit    || balance");
        }
    }
}
