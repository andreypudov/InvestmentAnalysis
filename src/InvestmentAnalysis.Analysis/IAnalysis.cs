// <copyright file="IAnalysis.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Analysis
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The base interface for analysis.
    /// </summary>
    [ContractClass(typeof(AnalysisContract))]
    public interface IAnalysis
    {
        /// <summary>
        /// Gets some data.
        /// </summary>
        /// <value>Some data.</value>
        string SomeData { get; }
    }
}
