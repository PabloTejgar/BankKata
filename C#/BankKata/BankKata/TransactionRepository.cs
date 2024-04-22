namespace BankKata
{
    public class TransactionRepository
    {
        private List<Transaction> listTransactions;

        public TransactionRepository()
        {
            listTransactions = new List<Transaction>();
        }

        internal void Withdraw(int amount, DateTime time)
        {
            listTransactions.Add(new Transaction(amount, time));
        }

        internal void Deposit(int amount, DateTime time)
        {
            listTransactions.Add(new Transaction(amount, time));
        }
    }
}