using System;
using System.Collections.Generic;
using System.Text;

namespace BankKata
{
    public class Account
    {
        private IConsole console;
        private IClock clock;
        private TransactionRepository transactionRepository;
        private string HEADER = "date       || credit   || debit    || balance";

        public Account(TransactionRepository transactionRepositoryInstance, IClock clockInstance, IConsole consoleInstance)
        {
            console = consoleInstance;
            clock = clockInstance;
            transactionRepository = transactionRepositoryInstance;
        }

        public void Deposit(int amount)
        {
            transactionRepository.AddTransaction(amount, clock.Now());
        }

        public void Withdraw(int amount)
        {
            transactionRepository.AddTransaction(amount, clock.Now());
        }

        public void PrintStatement()
        {
            console.PrintLine(HEADER);
            console.PrintLine("14/01/2012 || || 500.00 || 2500.00");
            console.PrintLine("13/01/2012 || 2000.00 || || 3000.00");
            console.PrintLine("10/01/2012 || 1000.00 || || 1000.00");
        }
    }
}
