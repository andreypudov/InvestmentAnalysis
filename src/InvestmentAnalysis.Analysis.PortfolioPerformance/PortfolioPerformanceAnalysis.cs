// <copyright file="PortfolioPerformanceAnalysis.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Analysis.PortfolioPerformance
{
    using System.Collections.Generic;
    using InvestmentAnalysis.Portfolio;

    /// <summary>
    /// The performance analysis.
    /// </summary>
    public sealed class PortfolioPerformanceAnalysis : IAnalysis<ISecurity, IPrice<ISecurity>, PortfolioPerformanceAnalysisResultEntry, PortfolioPerformanceAnalysisResult>
    {
        /// <inheritdoc />
        public PortfolioPerformanceAnalysisResult Analyze(IPortfolio<ITransaction<ISecurity, IPrice<ISecurity>>> portfolio)
        {
            var dictionary = new Dictionary<ISecurity, IPrice<ISecurity>>();
            return new PortfolioPerformanceAnalysisResult(dictionary.GetEnumerator());
        }
    }
}
