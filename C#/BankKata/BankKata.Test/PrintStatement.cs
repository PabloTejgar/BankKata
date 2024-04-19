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
            Account account = new Account(3000);
            account.Withdraw(500);
            Assert.That(account.PrintStatement(), Is.EqualTo("Date || Amount || Balance" + "\n 14 / 01 / 2012 || -500 || 2500"));
        }

        [Test]
        public void CreateTransaction2ThenTransactionReturned()
        {
            Account account = new Account(3000);
            account.Deposit(200);
            Assert.That(account.PrintStatement(), Is.EqualTo("Date || Amount || Balance" + "\n 14 / 01 / 2012 || 200 || 3200"));
        }

    }
}
