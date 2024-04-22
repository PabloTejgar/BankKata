namespace BankKata.Test
{
    [TestFixture]
    public class AccountTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TransactioDeposit()
        {
            Transaction transaction = new Transaction(500, new DateTime(2024, 01, 01));
            Assert.That(transaction.Format(), Is.EqualTo("01/01/2024 || 500.00 ||"));
        }

        [Test]
        public void TransactioWithdraw()
        {
            Transaction transaction = new Transaction(-500, new DateTime(2024, 01, 01));
            Assert.That(transaction.Format(), Is.EqualTo("01/01/2024 || || 500.00"));
        }
    }
}