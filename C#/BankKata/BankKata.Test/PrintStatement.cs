﻿using NSubstitute;

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

            testClock.Now().Returns(new DateTime(2012, 01, 10));
            account.Deposit(1000);
            testClock.Now().Returns(new DateTime(2012, 01, 13));
            account.Deposit(2000);
            testClock.Now().Returns(new DateTime(2012, 01, 14));
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
