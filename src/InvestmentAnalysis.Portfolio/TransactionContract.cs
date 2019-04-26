// <copyright file="TransactionContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The contract class for <see cref="ITransaction{T}"/>.
    /// </summary>
    [ContractClassFor(typeof(ITransaction<>))]
    public abstract class TransactionContract : ITransaction<ISecurity>
    {
        /// <summary>
        /// Gets the financial security.
        /// </summary>
        /// <value>The financial security.</value>
        public ISecurity Security => Contract.Result<ISecurity>();

        /// <summary>
        /// Gets the type of the transaction.
        /// </summary>
        /// <value>The type of the transaction.</value>
        public TransactionType TransactionType => Contract.Result<TransactionType>();

        /// <summary>
        /// Gets the date and time of the transaction.
        /// </summary>
        /// <value>The date and time of the transaction.</value>
        public long DateTime => Contract.Result<int>();

        /// <summary>
        /// Gets the units of the transaction.
        /// </summary>
        /// <value>The units of the transaction.</value>
        public int Units => Contract.Result<int>();

        /// <summary>
        /// Gets the price of the individual unit.
        /// </summary>
        /// <value>The price of the individual unit.</value>
        public decimal Price => Contract.Result<decimal>();

        /// <summary>
        /// Gets the currency of the transaction.
        /// </summary>
        /// <value>The currency of the transaction..</value>
        public Currency Currency => Contract.Result<Currency>();
    }
}
