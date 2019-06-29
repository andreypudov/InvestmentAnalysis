// <copyright file="PortfolioPerformanceAnalysisResult.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Analysis.PortfolioPerformance
{
    using System.Collections.Generic;
    using InvestmentAnalysis.Portfolio;

    /// <summary>
    /// Represents the performance analysis result of the portfolio.
    /// </summary>
    public sealed class PortfolioPerformanceAnalysisResult : IAnalysisResult<ISecurity, IPrice<ISecurity>, PortfolioPerformanceAnalysisResultEntry>
    {
        private readonly Dictionary<ISecurity, IPrice<ISecurity>> results;

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioPerformanceAnalysisResult"/> class.
        /// </summary>
        /// <param name="results">The collection of the analysis results.</param>
        public PortfolioPerformanceAnalysisResult(Dictionary<ISecurity, IPrice<ISecurity>> results)
        {
            this.results = results;
        }

        /// <inheritdoc />
        public IEnumerable<PortfolioPerformanceAnalysisResultEntry> Result
        {
            get
            {
                var enumerator = this.results.GetEnumerator();

                while (enumerator.MoveNext())
                {
                    yield return new PortfolioPerformanceAnalysisResultEntry(enumerator.Current);
                }
            }
        }
    }
}
