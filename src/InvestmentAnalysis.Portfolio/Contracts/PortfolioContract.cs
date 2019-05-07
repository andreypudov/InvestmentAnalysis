// <copyright file="PortfolioContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Contracts
{
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The contract class for <see cref="IPortfolio{T}"/>.
    /// </summary>
    [ContractClassFor(typeof(IPortfolio<>))]
    public abstract class PortfolioContract : IPortfolio<ITransaction<ISecurity, IPrice<ISecurity>>>
    {
        /// <inheritdoc />
        public IEnumerable<ITransaction<ISecurity, IPrice<ISecurity>>> Transactions { get; } = Contract.Result<IEnumerable<ITransaction<ISecurity, IPrice<ISecurity>>>>();
    }
}
