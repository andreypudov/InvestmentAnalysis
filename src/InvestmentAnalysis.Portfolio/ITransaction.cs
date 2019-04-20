// <copyright file="ITransaction.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System;
    using System.Diagnostics.Contracts;

    /// <summary>
    /// Represents a financial transaction.
    /// </summary>
    [ContractClass(typeof(TransactionContract))]
    public interface ITransaction : IEquatable<ITransaction>
    {
        /// <summary>
        /// Gets the ticker symbol of the stock.
        /// </summary>
        /// <value>The ticker symbol of the stock.</value>
        string Symbol { get; }

        /// <summary>
        /// Gets the type of the transaction.
        /// </summary>
        /// <value>The type of the transaction.</value>
        TransactionType TransactionType { get; }

        /// <summary>
        /// Gets the date and time of the transaction.
        /// </summary>
        /// <value>The date and time of the transaction.</value>
        long DateTime { get; }

        /// <summary>
        /// Gets the units of the transaction.
        /// </summary>
        /// <value>The units of the transaction.</value>
        int Units { get; }

        /// <summary>
        /// Gets the price of the individual unit.
        /// </summary>
        /// <value>The price of the individual unit.</value>
        decimal Price { get; }

        /// <summary>
        /// Gets the currency of the transaction.
        /// </summary>
        /// <value>The currency of the transaction.</value>
        Currency Currency { get; }
    }
}
