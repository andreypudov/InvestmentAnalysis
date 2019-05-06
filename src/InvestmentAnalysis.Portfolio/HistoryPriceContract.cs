// <copyright file="HistoryPriceContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The contract class for <see cref="IHistoryPrice{T}"/>.
    /// </summary>
    [ContractClassFor(typeof(IHistoryPrice<>))]
    public abstract class HistoryPriceContract : PriceContract, IHistoryPrice<ISecurity>
    {
        /// <summary>
        /// Gets the date and time of the price.
        /// </summary>
        /// <value>The date and time of the price.</value>
        public long DateTime => Contract.Result<int>();
    }
}
