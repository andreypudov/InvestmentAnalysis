// <copyright file="IHistoryPrice.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// Represents a historical price of the security.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="ISecurity"/>.</typeparam>
    [ContractClass(typeof(HistoryPriceContract))]
    public interface IHistoryPrice<out T> : IPrice<T>
        where T : ISecurity
    {
        /// <summary>
        /// Gets the date and time of the price.
        /// </summary>
        /// <value>The date and time of the price.</value>
        long DateTime { get; }
    }
}
