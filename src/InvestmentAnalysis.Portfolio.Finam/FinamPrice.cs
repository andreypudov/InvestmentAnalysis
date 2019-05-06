// <copyright file="FinamPrice.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam
{
    /// <inheritdoc/>
    public sealed class FinamPrice : IPrice<FinamSecurity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinamPrice"/> class.
        /// </summary>
        /// <param name="price">The the price of the security.</param>
        /// <param name="currency">The currency of the security.</param>
        public FinamPrice(decimal price, Currency currency)
        {
            this.Price = price;
            this.Currency = currency;
        }

        /// <inheritdoc/>
        public decimal Price { get; }

        /// <inheritdoc/>
        public Currency Currency { get; }
    }
}
