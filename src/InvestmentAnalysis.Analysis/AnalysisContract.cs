// <copyright file="AnalysisContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Analysis
{
    using System.Diagnostics.Contracts;
    using InvestmentAnalysis.Portfolio;

    /// <summary>
    /// The contract class for <see cref="IAnalysis"/>.
    /// </summary>
    [ContractClassFor(typeof(IAnalysis))]
    public abstract class AnalysisContract : IAnalysis
    {
        /// <inheritdoc/>
        public IAnalysisResult Analyze(IPortfolio<ITradeTransaction<ISecurity, IPrice<ISecurity>>> portfolio) => Contract.Result<IAnalysisResult>();
    }
}
