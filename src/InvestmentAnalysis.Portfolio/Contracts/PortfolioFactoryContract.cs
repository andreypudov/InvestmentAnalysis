// <copyright file="PortfolioFactoryContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Contracts
{
    using System.Diagnostics.Contracts;
    using System.Xml;

    /// <summary>
    /// The contract class for <see cref="IPortfolioFactory{T}"/>.
    /// </summary>
    [ContractClassFor(typeof(IPortfolioFactory<>))]
    public abstract class PortfolioFactoryContract : IPortfolioFactory<IPortfolio<ITransaction<ISecurity, IPrice<ISecurity>>>>
    {
        /// <inheritdoc />
        [Pure]
        public IPortfolio<ITransaction<ISecurity, IPrice<ISecurity>>> CreatePortfolio(XmlReader reader)
        {
            Contract.Requires(reader != null);

            return Contract.Result<IPortfolio<ITransaction<ISecurity, IPrice<ISecurity>>>>();
        }
    }
}
