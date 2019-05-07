// <copyright file="PortfolioWriterContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Contracts
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The contract class for <see cref="IPortfolioWriter{T}"/>.
    /// </summary>
    [ContractClassFor(typeof(IPortfolioWriter<>))]
    public abstract class PortfolioWriterContract : IPortfolioWriter<IPortfolio<ITransaction<ISecurity, IPrice<ISecurity>>>>
    {
        /// <inheritdoc />
        public void Write(IPortfolio<ITransaction<ISecurity, IPrice<ISecurity>>> portfolio) => Contract.Requires(portfolio != null);
    }
}
