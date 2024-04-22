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
            var transactions = transactionRepository.GetTransactions();
            foreach(Transaction transaction in transactions)
            {
                console.PrintLine(transaction.Format());
            }
        }
    }
}
