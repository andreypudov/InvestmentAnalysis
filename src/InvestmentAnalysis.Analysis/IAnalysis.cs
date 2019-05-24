// <copyright file="IAnalysis.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Analysis
{
    // using System.Diagnostics.Contracts;
    using InvestmentAnalysis.Portfolio;

    /// <summary>
    /// The base interface for analysis.
    /// </summary>
    /// <typeparam name="K">The type of the keys in the analysis result.</typeparam>
    /// <typeparam name="V">The type of the values in the analysis result.</typeparam>
    /// <typeparam name="E">The type of the analysis result entry.</typeparam>
    /// <typeparam name="R">The type of the analysis result.</typeparam>
    // [ContractClass(typeof(AnalysisContract))]
    public interface IAnalysis<out K, out V, out E, out R>
        where E : IAnalysisResultEntry<K, V>
        where R : IAnalysisResult<K, V, E>
    {
        /// <summary>
        /// Returns the result of portfolio analysis.
        /// </summary>
        /// <param name="portfolio">The collection of individual transactions.</param>
        /// <returns>The result of portfolio analysis</returns>
        R Analyze(IPortfolio<ITransaction<ISecurity, IPrice<ISecurity>>> portfolio);
    }
}
