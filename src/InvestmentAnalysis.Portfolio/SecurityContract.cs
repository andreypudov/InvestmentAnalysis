// <copyright file="SecurityContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The contract class for <see cref="ISecurity"/>.
    /// </summary>
    [ContractClassFor(typeof(ISecurity))]
    public abstract class SecurityContract : ISecurity
    {
        /// <inheritdoc/>
        public string ISIN => Contract.Result<string>();

        /// <inheritdoc/>
        public string Symbol => Contract.Result<string>();

        /// <inheritdoc/>
        public string Description => Contract.Result<string>();
    }
}
