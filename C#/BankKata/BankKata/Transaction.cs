using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKata
{
    public class Transaction
    {
        private int transactionAmount;
        private DateTime transactionTime;

        public Transaction(int amount, DateTime clockTime)
        {
            transactionAmount = amount;
            transactionTime = clockTime;
        }

        public string Format()
        {
            return transactionAmount > 0 ?
               $"{transactionTime.ToShortDateString()} || {transactionAmount}.00 || " :
               $"{transactionTime.ToShortDateString()} || || {-transactionAmount}.00";
            throw new NotImplementedException();
        }
    }
}
