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
        private readonly Dictionary<ISecurity, IPrice<ISecurity>>.Enumerator enumerator;

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioPerformanceAnalysisResult"/> class.
        /// </summary>
        /// <param name="enumerator">The enumerator of the analysis results.</param>
        public PortfolioPerformanceAnalysisResult(Dictionary<ISecurity, IPrice<ISecurity>>.Enumerator enumerator)
        {
            this.enumerator = enumerator;
        }

        /// <inheritdoc />
        public IEnumerable<PortfolioPerformanceAnalysisResultEntry> Result
        {
            get
            {
                while (this.enumerator.MoveNext())
                {
                    yield return new PortfolioPerformanceAnalysisResultEntry(this.enumerator.Current);
                }
            }
        }
    }
}
