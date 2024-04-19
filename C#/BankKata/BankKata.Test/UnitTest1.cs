namespace BankKata.Test
{
    public class AccountTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(100, 0, ExpectedResult = 100)]
        [TestCase(350, 150, ExpectedResult = 500)]
        [TestCase(40, 160, ExpectedResult = 200)]
        public int WhenDepositThenBalanceIncreases(int deposit, int initialBalance)
        {
            Account account = new Account(initialBalance);
            account.Deposit(deposit);
            return account.Balance;
        }

        public void WhenWithdrawThenBalanceDecreases()
        {
            Account account = new Account(100);
            account.Withdraw(100);
            Assert.That(account.Balance, Is.EqualTo(0));
        }

    }
}