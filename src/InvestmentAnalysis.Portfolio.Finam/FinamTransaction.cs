namespace InvestmentAnalysis.Portfolio.Finam
{
    public class FinamTransaction : ITransaction
    {
        public TransactionType TransactionType { get; }

        public long Date { get; }

        public int Units { get; }

        public decimal Price { get; }

        public FinamTransaction(TransactionType transactionType, long date, int units, decimal price)
        {
            TransactionType = transactionType;
            Date = date;
            Units = units;
            Price = price;
        }
    }
}
