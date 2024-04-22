using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKata.Test
{
    [TestFixture]
    public class TransactionRepositoryTest
    {
        public void AddATransactionReturnsATransaction()
        {
            var transactionRepository = new TransactionRepository();

            transactionRepository.AddTransaction(400, new DateTime(2012, 01, 10));
            Assert.AreEqual(transactionRepository.GetTransactions().Length, 1);
        }

    }
}
