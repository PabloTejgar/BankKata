using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKata
{
    public class Transaction
    {
        private DateTime transactionTime;

        public int Amount { get; private set; }

        public Transaction(int amount, DateTime clockTime)
        {
            Amount = amount;
            transactionTime = clockTime;
        }

        public string Format()
        {
            return Amount > 0 ?
               $"{transactionTime.ToShortDateString()} || {Amount}.00 ||" :
               $"{transactionTime.ToShortDateString()} || || {-Amount}.00";
        }
    }
}
