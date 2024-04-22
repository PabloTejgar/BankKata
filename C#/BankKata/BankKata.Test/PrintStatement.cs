using NSubstitute;
using System;
using NUnit.Framework;


namespace BankKata.Test
{
    [TestFixture]
    public class PrintStatementTest
    {

        private readonly IConsole testConsole = Substitute.For<IConsole>();

        [Test]
        public void CorrectlySetTransaction()
        {
            var account = new Account(0, testConsole);

            account.Deposit(100);
            account.PrintStatement();

            Received.InOrder(() =>
            {
                testConsole.Received().PrintLine("date       || credit   || debit    || balance");
                testConsole.Received().PrintLine("14/01/2012 || || 500.00 || 2500.00");
            });
        }
    }
}
