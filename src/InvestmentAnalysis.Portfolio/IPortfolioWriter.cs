// <copyright file="IPortfolioWriter.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// Represents an investment portfolio writer.
    /// </summary>
    /// <typeparam name="T">The type of <c>Portfolio</c>.</typeparam>
    [ContractClass(typeof(PortfolioWriterContract))]
    public interface IPortfolioWriter<in T>
        where T : IPortfolio<ITransaction>
    {
        /// <summary>
        /// Writes the <c>IPortfolio</c> to the stream.
        /// </summary>
        /// <param name="portfolio">The instance of <c>Portfolio</c>.</param>
        void Write(T portfolio);
    }
}
