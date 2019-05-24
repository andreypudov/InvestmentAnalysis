// <copyright file="PortfolioPerformanceAnalysisResultEntry.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Analysis.PortfolioPerformance
{
    using System.Collections.Generic;
    using InvestmentAnalysis.Portfolio;

    /// <inheritdoc />
    public class PortfolioPerformanceAnalysisResultEntry : IAnalysisResultEntry<ISecurity, IPrice<ISecurity>>
    {
        private readonly KeyValuePair<ISecurity, IPrice<ISecurity>> current;

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioPerformanceAnalysisResultEntry"/> class.
        /// </summary>
        /// <param name="current">The current value of analysis result enumeration.</param>
        public PortfolioPerformanceAnalysisResultEntry(KeyValuePair<ISecurity, IPrice<ISecurity>> current)
        {
            this.current = current;
        }

        /// <inheritdoc />
        public ISecurity Key => this.current.Key;

        /// <inheritdoc />
        public IPrice<ISecurity> Value => this.current.Value;
    }
}
