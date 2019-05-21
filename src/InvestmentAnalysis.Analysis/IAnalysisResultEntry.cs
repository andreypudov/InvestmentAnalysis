// <copyright file="IAnalysisResultEntry.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Analysis
{
    using InvestmentAnalysis.Portfolio;

    /// <summary>
    /// Represents the entry of the portfolio analysis result.
    /// </summary>
    /// <typeparam name="K">The type of the keys in the analysis result.</typeparam>
    /// <typeparam name="V">The type of the values in the analysis result.</typeparam>
    public interface IAnalysisResultEntry<out K, out V>
        where K : ISecurity
        where V : IPrice<K>
    {
        /// <summary>
        /// Gets the key in the analysis result.
        /// </summary>
        K Key { get; }

        /// <summary>
        /// Gets the value in the analysis result.
        /// </summary>
        V Value { get; }
    }
}
