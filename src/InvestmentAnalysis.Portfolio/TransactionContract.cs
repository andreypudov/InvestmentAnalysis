// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System.Diagnostics.Contracts;

namespace InvestmentAnalysis.Portfolio
{
    [ContractClassFor(typeof(ITransaction))]
    public abstract class TransactionContract : ITransaction
    {
        public TransactionType TransactionType
        {
            get
            {
                return Contract.Result<TransactionType>();
            }
        }

        public long Date
        {
            get
            {
                return Contract.Result<int>();
            }
        }

        public int Units
        {
            get
            {
                return Contract.Result<int>();
            }
        }

        public decimal Price
        {
            get
            {
                return Contract.Result<decimal>();
            }
        }
    }
}
