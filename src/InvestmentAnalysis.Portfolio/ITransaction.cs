namespace InvestmentAnalysis.Portfolio
{
    public interface ITransaction
    {
        TransactionType TransactionType { get; }

        long Date { get; }

        int Units { get; }

        decimal Price { get; }
    }
}
