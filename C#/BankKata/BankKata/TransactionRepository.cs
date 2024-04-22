namespace BankKata
{
    public class TransactionRepository
    {
        private List<Transaction> listTransactions;

        public TransactionRepository()
        {
            listTransactions = new List<Transaction>();
        }

        public void AddTransaction(int amount, DateTime time)
        {
            listTransactions.Add(new Transaction(amount, time));
        }

    }
}