// <copyright file="AnalysisContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Analysis
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The contract class for <see cref="IAnalysis"/>.
    /// </summary>
    [ContractClassFor(typeof(IAnalysis))]
    public abstract class AnalysisContract : IAnalysis
    {
        /// <inheritdoc/>
        public string SomeData { get; } = Contract.Result<string>();
    }
}
