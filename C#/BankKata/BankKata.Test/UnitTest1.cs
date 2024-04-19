namespace BankKata.Test
{
    public class AccountTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenDepositThenBalanceIncreases()
        {
            Account account = new Account(0);
            account.Deposit(100);
            Assert.That(100, Is.EqualTo(account.Balance));
        }
    }
}