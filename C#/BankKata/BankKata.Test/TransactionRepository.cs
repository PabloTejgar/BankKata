namespace BankKata.Test
{
    [TestFixture]
    public class TransactionRepositoryTest
    {
        [Test]
        public void AddATransactionReturnsATransaction()
        {
            var transactionRepository = new TransactionRepository();

            transactionRepository.AddTransaction(400, new DateTime(2012, 01, 10));
            Assert.That(1, Is.EqualTo(transactionRepository.GetTransactions().Count));
        }

        [Test]

        public void CorrectlyFormattedTransactions()
        {
            TransactionRepository transactionRepository = new TransactionRepository();
            transactionRepository.AddTransaction(1000, new DateTime(2012, 01, 10));
            var formattedTransactions = transactionRepository.FormatTransactions();
            formattedTransactions.Contains("10/01/2012 || 1000.00 || || 1000.00");
        }
    }
}
