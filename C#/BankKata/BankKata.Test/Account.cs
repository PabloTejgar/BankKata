namespace BankKata.Test
{
    [TestFixture]
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
            Account account = new Account(initialBalance, new PrintStatement());
            account.Deposit(deposit);
            return account.Balance;
        }

        [TestCase(100, 100, ExpectedResult = 0)]
        [TestCase(100, 450, ExpectedResult = 350)]
        [TestCase(500, 600, ExpectedResult = 100)]
        public int WhenWithdrawThenBalanceDecreases(int withdraw, int initialBalance)
        {
            Account account = new Account(initialBalance, new PrintStatement());
            account.Withdraw(withdraw);
            return account.Balance;
        }
    }
}