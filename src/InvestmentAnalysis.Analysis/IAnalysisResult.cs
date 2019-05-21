// <copyright file="IAnalysisResult.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Analysis
{
    using System.Collections.Generic;
    using InvestmentAnalysis.Portfolio;

    /// <summary>
    /// Represents the general result of portfolio analysis.
    /// </summary>
    /// <typeparam name="K">The type of the keys in the analysis result.</typeparam>
    /// <typeparam name="V">The type of the values in the analysis result.</typeparam>
    public interface IAnalysisResult<out K, out V>
        where K : ISecurity
        where V : IPrice<K>
    {
        /// <summary>
        /// Gets the result of the portfolio analysis.
        /// </summary>
        IEnumerable<IAnalysisResultEntry<K, V>> Result { get; }
    }
}
