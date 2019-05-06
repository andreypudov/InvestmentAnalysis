// <copyright file="FinamServiceTransaction.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam
{
    using System;

    /// <inheritdoc/>
    public sealed class FinamServiceTransaction : FinamTransaction, ITransaction<FinamSecurity, FinamPrice>, IEquatable<FinamServiceTransaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinamServiceTransaction"/> class.
        /// </summary>
        /// <param name="transactionType">The type of the transaction.</param>
        /// <param name="date">The date and time of the transaction.</param>
        /// <param name="price">The price of the individual unit.</param>
        /// <param name="description">The description of the transaction.</param>
        public FinamServiceTransaction(TransactionType transactionType, long date, FinamPrice price, string description)
            : base(transactionType, date, price, description)
        {
            // intentionally left blank
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if ((obj == null) || (this.GetType() != obj.GetType()))
            {
                return false;
            }

            var transaction = (FinamServiceTransaction)obj;
            return this == transaction;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="FinamServiceTransaction"/> is equal to the current <see cref="FinamServiceTransaction"/>.
        /// </summary>
        /// <param name="other">The <see cref="FinamServiceTransaction"/> to compare with the current <see cref="FinamServiceTransaction"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="FinamServiceTransaction"/> is equal to
        /// the current <see cref="FinamServiceTransaction"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(FinamServiceTransaction other)
        {
            if (other == null)
            {
                return false;
            }

            return this == other;
        }
    }
}
