// <copyright file="PriceContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The contract class for <see cref="IPrice{T}"/>.
    /// </summary>
    [ContractClassFor(typeof(IPrice<>))]
    public abstract class PriceContract : IPrice<ISecurity>
    {
        /// <summary>
        /// Gets the price of the security.
        /// </summary>
        /// <value>The price of the security.</value>
        public decimal Price => Contract.Result<decimal>();

        /// <summary>
        /// Gets the currency of the security.
        /// </summary>
        /// <value>The currency of the security.</value>
        public Currency Currency => Contract.Result<Currency>();
    }
}
