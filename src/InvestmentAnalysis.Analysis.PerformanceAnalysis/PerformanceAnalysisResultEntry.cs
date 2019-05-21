// <copyright file="PerformanceAnalysisResultEntry.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Analysis.PerformanceAnalysis
{
    using System.Collections.Generic;
    using InvestmentAnalysis.Portfolio;

    /// <inheritdoc />
    public class PerformanceAnalysisResultEntry : IAnalysisResultEntry<ISecurity, IPrice<ISecurity>>
    {
        private KeyValuePair<ISecurity, IPrice<ISecurity>> current;

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceAnalysisResultEntry"/> class.
        /// </summary>
        /// <param name="current">The current value of analysis result enumeration.</param>
        public PerformanceAnalysisResultEntry(KeyValuePair<ISecurity, IPrice<ISecurity>> current)
        {
            this.current = current;
        }

        /// <inheritdoc />
        public ISecurity Key => this.current.Key;

        /// <inheritdoc />
        public IPrice<ISecurity> Value => this.current.Value;
    }
}
