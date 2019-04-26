// <copyright file="ITransaction.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// Represents a financial transaction.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="ISecurity"/>.</typeparam>
    [ContractClass(typeof(TransactionContract))]
    public interface ITransaction<out T>
        where T : ISecurity
    {
        /// <summary>
        /// Gets the financial security.
        /// </summary>
        /// <value>The financial security.</value>
        T Security { get; }

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
