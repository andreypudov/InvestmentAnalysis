// <copyright file="PerformanceAnalysisResult.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Analysis.PerformanceAnalysis
{
    using System.Collections.Generic;
    using InvestmentAnalysis.Portfolio;

    /// <summary>
    /// Represents the performance analysis result of the portfolio.
    /// </summary>
    public sealed class PerformanceAnalysisResult : IAnalysisResult<ISecurity, IPrice<ISecurity>>
    {
        private Dictionary<ISecurity, IPrice<ISecurity>>.Enumerator enumerator;

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceAnalysisResult"/> class.
        /// </summary>
        /// <param name="enumerator">The enumerator of the analysis results.</param>
        public PerformanceAnalysisResult(Dictionary<ISecurity, IPrice<ISecurity>>.Enumerator enumerator)
        {
            this.enumerator = enumerator;
        }

        /// <inheritdoc />
        public IEnumerable<IAnalysisResultEntry<ISecurity, IPrice<ISecurity>>> Result
        {
            get
            {
                while (this.enumerator.MoveNext())
                {
                    yield return new PerformanceAnalysisResultEntry(this.enumerator.Current);
                }
            }
        }
    }
}
