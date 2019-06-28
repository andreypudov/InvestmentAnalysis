// <copyright file="FinamTransaction.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam
{
    using System;

    /// <inheritdoc/>
    public class FinamTransaction : ITransaction<FinamSecurity, FinamPrice>, IEquatable<FinamTransaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinamTransaction"/> class.
        /// </summary>
        /// <param name="transactionType">The type of the transaction.</param>
        /// <param name="date">The date and time of the transaction.</param>
        /// <param name="security">The financial security.</param>
        /// <param name="units">The units of the transaction.</param>
        /// <param name="price">The price of the individual unit.</param>
        /// <param name="description">The description of the transaction.</param>
        public FinamTransaction(TransactionType transactionType, long date, FinamSecurity security, int units, FinamPrice price, string description)
        {
            this.TransactionType = transactionType;
            this.DateTime = date;
            this.Security = security;
            this.Units = units;
            this.Price = price;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinamTransaction"/> class.
        /// </summary>
        /// <param name="transactionType">The type of the transaction.</param>
        /// <param name="date">The date and time of the transaction.</param>
        /// <param name="price">The price of the individual unit.</param>
        /// <param name="description">The description of the transaction.</param>
        public FinamTransaction(TransactionType transactionType, long date, FinamPrice price, string description)
        {
            this.TransactionType = transactionType;
            this.DateTime = date;
            this.Security = FinamSecurity.Empty;
            this.Units = 0;
            this.Price = price;
            this.Description = description;
        }

        /// <inheritdoc/>
        public TransactionType TransactionType { get; }

        /// <inheritdoc/>
        public long DateTime { get; }

        /// <inheritdoc/>
        public FinamSecurity Security { get; }

        /// <inheritdoc/>
        public int Units { get; }

        /// <inheritdoc/>
        public FinamPrice Price { get; }

        /// <inheritdoc/>
        public string Description { get; }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if ((obj == null) || (this.GetType() != obj.GetType()))
            {
                return false;
            }

            var transaction = (FinamTransaction)obj;
            return (this.TransactionType == transaction.TransactionType)
                   && (this.DateTime == transaction.DateTime)
                   && (this.Security == transaction.Security)
                   && (this.Units == transaction.Units)
                   && (this.Price == transaction.Price);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.TransactionType.GetHashCode();

                hashCode = (hashCode * 397) ^ this.DateTime.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Security.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Units;
                hashCode = (hashCode * 397) ^ this.Price.GetHashCode();

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

            return (this.TransactionType == other.TransactionType)
                   && (this.DateTime == other.DateTime)
                   && (this.Security == other.Security)
                   && (this.Units == other.Units)
                   && (this.Price == other.Price);
        }
    }
}
