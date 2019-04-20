// <copyright file="PortfolioFactoryContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;
    using System.Xml;

    /// <summary>
    /// The contract class for <see cref="IPortfolioFactory{T}"/>.
    /// </summary>
    [ContractClassFor(typeof(IPortfolioFactory<>))]
    public abstract class PortfolioFactoryContract : IPortfolioFactory<IPortfolio<ITransaction>>
    {
        /// <summary>
        /// Creates a portfolio with specified <see cref="XmlReader"/>.
        /// </summary>
        /// <param name="reader">The <see cref="XmlReader"/> containing the XML data to read.</param>
        /// <returns>The created <see cref="IPortfolio{T}"/> instance.</returns>
        [Pure]
        public IPortfolio<ITransaction> CreatePortfolio(XmlReader reader)
        {
            Contract.Requires(reader != null);

            return Contract.Result<IPortfolio<ITransaction>>();
        }
    }
}
