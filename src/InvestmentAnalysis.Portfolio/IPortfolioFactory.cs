// <copyright file="IPortfolioFactory.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;
    using System.Xml;

    /// <summary>
    /// Provides access to factory methods for creating and configuring portfolio instance.
    /// </summary>
    /// <typeparam name="T">The type of <c>Portfolio</c>.</typeparam>
    [ContractClass(typeof(PortfolioFactoryContract))]
    public interface IPortfolioFactory<out T>
        where T : IPortfolio<ITransaction>
    {
        /// <summary>
        /// Creates a portfolio with specified XML reader.
        /// </summary>
        /// <param name="reader">The <c>XmlReader</c> containing the XML data to read.</param>
        /// <returns>The created portfolio instance.</returns>
        T CreatePortfolio(XmlReader reader);
    }
}
