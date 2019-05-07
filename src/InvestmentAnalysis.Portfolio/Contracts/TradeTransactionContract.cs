// <copyright file="TradeTransactionContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Contracts
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The contract class for <see cref="ITradeTransaction{T, P}"/>.
    /// </summary>
    [ContractClassFor(typeof(ITradeTransaction<,>))]
    public abstract class TradeTransactionContract : TransactionContract, ITradeTransaction<ISecurity, IPrice<ISecurity>>
    {
        /// <inheritdoc />
        public ISecurity Security => Contract.Result<ISecurity>();

        /// <inheritdoc />
        public int Units => Contract.Result<int>();
    }
}
