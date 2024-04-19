using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKata.Test
{
    [TestFixture]
    public class PrintStatementTest
    {
        [Test]
        public void CreateTransactionThenTransactionReturned()
        {
            Account account = new Account(1000);
            account.Deposit(100);
            Assert.That(account.PrintStatement(), Is.EqualTo("Date || Amount || Balance" + "\n 14 / 01 / 2012 || -500 || 2500"));
        }
    }
}
