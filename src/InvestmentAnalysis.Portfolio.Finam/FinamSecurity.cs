// <copyright file="FinamSecurity.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam
{
    using System;

    /// <inheritdoc/>
    public sealed class FinamSecurity : ISecurity, IEquatable<FinamSecurity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinamSecurity"/> class.
        /// </summary>
        /// <param name="securityId">The international securities identification number.</param>
        /// <param name="symbol">The ticker symbol of the stock.</param>
        /// <param name="description">The description of security.</param>
        public FinamSecurity(string securityId, string symbol, string description)
        {
            this.ISIN = securityId;
            this.Symbol = symbol;
            this.Description = description;
        }

        /// <inheritdoc/>
        public string ISIN { get; }

        /// <inheritdoc/>
        public string Symbol { get; }

        /// <inheritdoc/>
        public string Description { get; }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if ((obj == null) || (this.GetType() != obj.GetType()))
            {
                return false;
            }

            var security = (FinamSecurity)obj;
            return (this.ISIN == security.ISIN)
                   && (this.Symbol == security.Symbol)
                   && (this.Description == security.Description);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.ISIN.GetHashCode(StringComparison.Ordinal);

                hashCode = (hashCode * 397) ^ this.Symbol.GetHashCode(StringComparison.Ordinal);
                hashCode = (hashCode * 397) ^ this.Description.GetHashCode(StringComparison.Ordinal);

                return hashCode;
            }
        }

        /// <summary>
        /// Determines whether the specified <see cref="FinamSecurity"/> is equal to the current <see cref="FinamSecurity"/>.
        /// </summary>
        /// <param name="other">The <see cref="FinamSecurity"/> to compare with the current <see cref="FinamSecurity"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="FinamSecurity"/> is equal to the
        /// current <see cref="FinamSecurity"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(FinamSecurity other)
        {
            if (other == null)
            {
                return false;
            }

            return (this.ISIN == other.ISIN)
                    && (this.Symbol == other.Symbol)
                    && (this.Description == other.Description);
        }
    }
}
