// <copyright file="IAnalysis.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Analysis
{
    using System.Diagnostics.Contracts;
    using InvestmentAnalysis.Portfolio;

    /// <summary>
    /// The base interface for analysis.
    /// </summary>
    [ContractClass(typeof(AnalysisContract))]
    public interface IAnalysis
    {
        /// <summary>
        /// Returns the result of portfolio analysis.
        /// </summary>
        /// <param name="portfolio">The collection of individual transactions.</param>
        /// <returns>The result of portfolio analysis</returns>
        IAnalysisResult<ISecurity, IPrice<ISecurity>> Analyze(IPortfolio<ITradeTransaction<ISecurity, IPrice<ISecurity>>> portfolio);
    }
}
