// <copyright file="TransactionContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

using System.Diagnostics.Contracts;

namespace InvestmentAnalysis.Portfolio
{
    [ContractClassFor(typeof(ITransaction))]
    public abstract class TransactionContract : ITransaction
    {
        public string Symbol => Contract.Result<string>();

        public TransactionType TransactionType => Contract.Result<TransactionType>();

        public long DateTime => Contract.Result<int>();

        public int Units => Contract.Result<int>();

        public decimal Price => Contract.Result<decimal>();

        public Currency Currency => Contract.Result<Currency>();

        public bool Equals(ITransaction other) => Contract.Result<bool>();
    }
}
