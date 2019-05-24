// <copyright file="PriceContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Contracts
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The contract class for <see cref="IPrice{T}"/>.
    /// </summary>
    [ContractClassFor(typeof(IPrice<>))]
    public abstract class PriceContract : IPrice<ISecurity>
    {
        /// <inheritdoc />
        public decimal Price => Contract.Result<decimal>();

        /// <inheritdoc />
        public Currency Currency => Contract.Result<Currency>();
    }
}
