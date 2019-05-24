// <copyright file="AnalysisContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Analysis
{
    using System.Diagnostics.Contracts;
    using InvestmentAnalysis.Portfolio;

    /// <summary>
    /// The contract class for <see cref="IAnalysis{K, V, E, R}"/>.
    /// </summary>
    /// <typeparam name="K">The type of the keys in the analysis result.</typeparam>
    /// <typeparam name="V">The type of the values in the analysis result.</typeparam>
    /// <typeparam name="E">The type of the analysis result entry.</typeparam>
    /// <typeparam name="R">The type of the analysis result.</typeparam>
    [ContractClassFor(typeof(IAnalysis<,,,>))]
    public abstract class AnalysisContract<K, V, E, R> : IAnalysis<K, V, E, R>
        where E : IAnalysisResultEntry<K, V>
        where R : IAnalysisResult<K, V, E>
    {
        /// <inheritdoc />
        public R Analyze(IPortfolio<ITransaction<ISecurity, IPrice<ISecurity>>> portfolio) => Contract.Result<R>();
    }
}
