// <copyright file="IPortfolioReader.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// Represents an investment portfolio reader.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="IPortfolio{T}"/>.</typeparam>
    [ContractClass(typeof(PortfolioReaderContract))]
    public interface IPortfolioReader<out T>
        where T : IPortfolio<ITransaction>
    {
        /// <summary>
        /// Reads the <see cref="IPortfolio{T}"/> from the stream.
        /// </summary>
        /// <returns>The instance of <see cref="IPortfolio{T}"/>.</returns>
        T Read();
    }
}
