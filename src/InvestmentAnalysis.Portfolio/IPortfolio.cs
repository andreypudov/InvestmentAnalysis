// <copyright file="IPortfolio.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The collection of individual transactions.
    /// </summary>
    /// <typeparam name="T">The type of <c>Transaction</c>.</typeparam>
    [ContractClass(typeof(PortfolioContract))]
    public interface IPortfolio<out T>
        where T : ITransaction
    {
        /// <summary>
        /// Gets enumerable collection of transactions.
        /// </summary>
        IEnumerable<T> Transactions { get; }
    }
}
