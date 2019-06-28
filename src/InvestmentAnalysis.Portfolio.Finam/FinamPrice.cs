// <copyright file="FinamPrice.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam
{
    using System;

    /// <inheritdoc/>
    public sealed class FinamPrice : IPrice<FinamSecurity>, IEquatable<FinamPrice>
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

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if ((obj == null) || (this.GetType() != obj.GetType()))
            {
                return false;
            }

            var transaction = (FinamPrice)obj;
            return (this.Price == transaction.Price)
                   && (this.Currency == transaction.Currency);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.Price.GetHashCode();

                hashCode = (hashCode * 397) ^ this.Currency.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        /// Determines whether the specified <see cref="FinamPrice"/> is equal to the current <see cref="FinamPrice"/>.
        /// </summary>
        /// <param name="other">The <see cref="FinamPrice"/> to compare with the current <see cref="FinamPrice"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="FinamPrice"/> is equal to
        /// the current <see cref="FinamPrice"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(FinamPrice other)
        {
            if (other == null)
            {
                return false;
            }

            return (this.Price == other.Price)
                   && (this.Currency == other.Currency);
        }
    }
}
