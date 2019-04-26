// <copyright file="FinamTransaction.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam
{
    using System;

    /// <inheritdoc/>
    public sealed class FinamTransaction : ITransaction<FinamSecurity>, IEquatable<FinamTransaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinamTransaction"/> class.
        /// </summary>
        /// <param name="security">The financial security.</param>
        /// <param name="transactionType">The type of the transaction.</param>
        /// <param name="date">The date and time of the transaction.</param>
        /// <param name="units">The units of the transaction.</param>
        /// <param name="price">The price of the individual unit.</param>
        /// <param name="currency">The currency of the transaction.</param>
        public FinamTransaction(FinamSecurity security, TransactionType transactionType, long date, int units, decimal price, Currency currency)
        {
            this.Security = security;
            this.TransactionType = transactionType;
            this.DateTime = date;
            this.Units = units;
            this.Price = price;
            this.Currency = currency;
        }

        /// <inheritdoc/>
        public FinamSecurity Security { get; }

        /// <inheritdoc/>
        public TransactionType TransactionType { get; }

        /// <inheritdoc/>
        public long DateTime { get; }

        /// <inheritdoc/>
        public int Units { get; }

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

            var transaction = (FinamTransaction)obj;
            return (this.Security == transaction.Security)
                   && (this.TransactionType == transaction.TransactionType)
                   && (this.DateTime == transaction.DateTime)
                   && (this.Units == transaction.Units)
                   && (this.Price == transaction.Price)
                   && (this.Currency == transaction.Currency);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.Security.GetHashCode();

                hashCode = (hashCode * 397) ^ this.TransactionType.GetHashCode();
                hashCode = (hashCode * 397) ^ this.DateTime.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Units;
                hashCode = (hashCode * 397) ^ this.Price.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Currency.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        /// Determines whether the specified <see cref="FinamTransaction"/> is equal to the current <see cref="FinamTransaction"/>.
        /// </summary>
        /// <param name="other">The <see cref="FinamTransaction"/> to compare with the current <see cref="FinamTransaction"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="FinamTransaction"/> is equal to
        /// the current <see cref="FinamTransaction"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(FinamTransaction other)
        {
            if (other == null)
            {
                return false;
            }

            return (this.Security == other.Security)
                    && (this.TransactionType == other.TransactionType)
                    && (this.DateTime == other.DateTime)
                    && (this.Units == other.Units)
                    && (this.Price == other.Price)
                    && (this.Currency == other.Currency);
        }
    }
}
