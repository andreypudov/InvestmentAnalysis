// <copyright file="FinamTradeTransaction.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam
{
    using System;

    /// <inheritdoc/>
    public sealed class FinamTradeTransaction : FinamTransaction, ITradeTransaction<FinamSecurity>, IEquatable<FinamTradeTransaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinamTradeTransaction"/> class.
        /// </summary>
        /// <param name="security">The financial security.</param>
        /// <param name="transactionType">The type of the transaction.</param>
        /// <param name="date">The date and time of the transaction.</param>
        /// <param name="units">The units of the transaction.</param>
        /// <param name="price">The price of the individual unit.</param>
        /// <param name="currency">The currency of the transaction.</param>
        /// <param name="description">The description of the transaction.</param>
        public FinamTradeTransaction(FinamSecurity security, TransactionType transactionType, long date, int units, decimal price, Currency currency, string description)
            : base(transactionType, date, price, currency, description)
        {
            this.Security = security;
            this.Units = units;
        }

        /// <inheritdoc/>
        public FinamSecurity Security { get; }

        /// <inheritdoc/>
        public int Units { get; }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if ((obj == null) || (this.GetType() != obj.GetType()))
            {
                return false;
            }

            var transaction = (FinamTradeTransaction)obj;
            return (this == transaction)
                   && (this.Security == transaction.Security)
                   && (this.Units == transaction.Units);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.GetHashCode();

                hashCode = (hashCode * 397) ^ this.Security.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Units;

                return hashCode;
            }
        }

        /// <summary>
        /// Determines whether the specified <see cref="FinamTransaction"/> is equal to the current <see cref="FinamTransaction"/>.
        /// </summary>
        /// <param name="other">The <see cref="FinamTransaction"/> to compare with the current <see cref="FinamTransaction"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="FinamTransaction"/> is equal to
        /// the current <see cref="FinamTransaction"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(FinamTradeTransaction other)
        {
            if (other == null)
            {
                return false;
            }

            return (this == other)
                    && (this.Security == other.Security)
                    && (this.Units == other.Units);
        }
    }
}
