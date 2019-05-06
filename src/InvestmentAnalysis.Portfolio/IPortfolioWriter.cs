// <copyright file="IPortfolioWriter.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// Represents an investment portfolio writer.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="IPortfolio{T}"/>.</typeparam>
    [ContractClass(typeof(PortfolioWriterContract))]
    public interface IPortfolioWriter<in T>
        where T : IPortfolio<ITransaction<ISecurity, IPrice<ISecurity>>>
    {
        /// <summary>
        /// Writes the <see cref="IPortfolio{T}"/> to the stream.
        /// </summary>
        /// <param name="portfolio">The instance of <see cref="IPortfolio{T}"/>.</param>
        void Write(T portfolio);
    }
}
