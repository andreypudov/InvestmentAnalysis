// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

namespace InvestmentAnalysis.Portfolio.Finam
{
    public class FinamTransaction : ITransaction
    {
        public TransactionType TransactionType { get; }

        public long DateTime { get; }

        public int Units { get; }

        public decimal Price { get; }

        public FinamTransaction(TransactionType transactionType, long date, int units, decimal price)
        {
            TransactionType = transactionType;
            DateTime = date;
            Units = units;
            Price = price;
        }
    }
}
