// <copyright file="FinamTransaction.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam
{
    using System;

    /// <inheritdoc/>
    public abstract class FinamTransaction : ITransaction<FinamSecurity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinamTransaction"/> class.
        /// </summary>
        /// <param name="transactionType">The type of the transaction.</param>
        /// <param name="date">The date and time of the transaction.</param>
        /// <param name="price">The price of the individual unit.</param>
        /// <param name="currency">The currency of the transaction.</param>
        /// <param name="description">The description of the transaction.</param>
        public FinamTransaction(TransactionType transactionType, long date, decimal price, Currency currency, string description)
        {
            this.TransactionType = transactionType;
            this.DateTime = date;
            this.Price = price;
            this.Currency = currency;
            this.Description = description;
        }

        /// <inheritdoc/>
        public TransactionType TransactionType { get; }

        /// <inheritdoc/>
        public long DateTime { get; }

        /// <inheritdoc/>
        public decimal Price { get; }

        /// <inheritdoc/>
        public Currency Currency { get; }

        /// <inheritdoc/>
        public string Description { get; }
    }
}
