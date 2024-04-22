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

        public List<Transaction> GetTransactions()
        {
            return listTransactions;
        }

        public List<string> FormatTransactions()
        {
            int balance = 0;
            List<string> formattedTransactions = new List<string>();
            foreach (var transaction in listTransactions)
            {
                balance += transaction.Amount;
                formattedTransactions.Add($"{transaction.Format()} || {balance}.00");
            }

            formattedTransactions.Reverse();
            return formattedTransactions;
        }
    }
}