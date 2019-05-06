// <copyright file="IPortfolioFactory.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;
    using System.Xml;

    /// <summary>
    /// Provides access to factory methods for creating and configuring <see cref="IPortfolio{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="IPortfolio{T}"/>.</typeparam>
    [ContractClass(typeof(PortfolioFactoryContract))]
    public interface IPortfolioFactory<out T>
        where T : IPortfolio<ITransaction<ISecurity, IPrice<ISecurity>>>
    {
        /// <summary>
        /// Creates a portfolio with specified <see cref="XmlReader"/>.
        /// </summary>
        /// <param name="reader">The <see cref="XmlReader"/> containing the XML data to read.</param>
        /// <returns>The created <see cref="IPortfolio{T}"/> instance.</returns>
        T CreatePortfolio(XmlReader reader);
    }
}
