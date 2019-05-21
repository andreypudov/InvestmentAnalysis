// <copyright file="PerformanceAnalysis.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Analysis.PerformanceAnalysis
{
    using System.Collections.Generic;
    using InvestmentAnalysis.Portfolio;

    /// <summary>
    /// The performance analysis.
    /// </summary>
    public class PerformanceAnalysis : IAnalysis
    {
        /// <inheritdoc />
        public PerformanceAnalysisResult Analyze(IPortfolio<ITradeTransaction<ISecurity, IPrice<ISecurity>>> portfolio)
        {
            var dictionary = new Dictionary<ISecurity, IPrice<ISecurity>>();
            return new PerformanceAnalysisResult(dictionary.GetEnumerator());
        }
    }
}
