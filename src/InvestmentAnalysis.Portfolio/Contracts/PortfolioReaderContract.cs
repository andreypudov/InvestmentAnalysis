// <copyright file="PortfolioReaderContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Contracts
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The contract class for <see cref="IPortfolioReader{T}"/>.
    /// </summary>
    [ContractClassFor(typeof(IPortfolioReader<>))]
    public abstract class PortfolioReaderContract : IPortfolioReader<IPortfolio<ITransaction<ISecurity, IPrice<ISecurity>>>>
    {
        /// <inheritdoc />
        [Pure]
        public IPortfolio<ITransaction<ISecurity, IPrice<ISecurity>>> Read()
        {
            return Contract.Result<IPortfolio<ITransaction<ISecurity, IPrice<ISecurity>>>>();
        }
    }
}
