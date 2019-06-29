// <copyright file="IPrice.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;
    using InvestmentAnalysis.Portfolio.Contracts;

    /// <summary>
    /// Represents a price of the security.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="ISecurity"/>.</typeparam>
    [ContractClass(typeof(PriceContract))]
    public interface IPrice<out T>
        where T : ISecurity
    {
        /// <summary>
        /// Gets the price of the security.
        /// </summary>
        /// <value>The price of the security.</value>
        decimal Price { get; }

        /// <summary>
        /// Gets the currency of the security.
        /// </summary>
        /// <value>The currency of the security.</value>
        Currency Currency { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPrice{T}"/> class with specified price.
        /// </summary>
        /// <param name="price">The price of the security.</param>
        /// <returns>A new instance of the <see cref="IPrice{T}"/>.</returns>
        IPrice<ISecurity> Create(decimal price);
    }
}
