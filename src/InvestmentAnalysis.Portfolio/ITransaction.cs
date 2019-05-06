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
    /// <typeparam name="P">The type of <see cref="IPrice{T}"/>.</typeparam>
    [ContractClass(typeof(TransactionContract))]
    public interface ITransaction<out T, out P>
        where T : ISecurity
        where P : IPrice<T>
    {
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
        /// Gets the price of the individual unit.
        /// </summary>
        /// <value>The price of the individual unit.</value>
        P Price { get; }

        /// <summary>
        /// Gets the description of the transaction.
        /// </summary>
        string Description { get; }
    }
}
