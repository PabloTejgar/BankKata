using NSubstitute;
using System;
using NUnit.Framework;


namespace BankKata.Test
{
    [TestFixture]
    public class PrintStatementTest
    {

        private readonly IConsole testConsole = Substitute.For<IConsole>();
        private readonly IClock testClock = Substitute.For<IClock>();

        [Test]
        public void CorrectlySetTransaction()
        {
            var account = new Account(new TransactionRepository(), testClock, testConsole);

            account.Deposit(1000);
            account.Withdraw(500);
            account.PrintStatement();

            Received.InOrder(() =>
            {
                testConsole.Received().PrintLine("date       || credit   || debit    || balance");
                testConsole.Received().PrintLine("14/01/2012 || || 500.00 || 2500.00");
                testConsole.Received().PrintLine("13/01/2012 || 2000.00 || || 3000.00");
                testConsole.Received().PrintLine("10/01/2012 || 1000.00 || || 1000.00");
            });
        }
    }
}
