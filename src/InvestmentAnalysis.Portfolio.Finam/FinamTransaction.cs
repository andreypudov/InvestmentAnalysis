// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

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
