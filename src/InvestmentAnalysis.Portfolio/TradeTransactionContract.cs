// <copyright file="TradeTransactionContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The contract class for <see cref="ITradeTransaction{T}"/>.
    /// </summary>
    [ContractClassFor(typeof(ITradeTransaction<>))]
    public abstract class TradeTransactionContract : TransactionContract, ITradeTransaction<ISecurity>
    {
        /// <summary>
        /// Gets the financial security.
        /// </summary>
        /// <value>The financial security.</value>
        public ISecurity Security => Contract.Result<ISecurity>();

        /// <summary>
        /// Gets the units of the transaction.
        /// </summary>
        /// <value>The units of the transaction.</value>
        public int Units => Contract.Result<int>();
    }
}
