// <copyright file="IHistoricalRecord.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;
    using InvestmentAnalysis.Portfolio.Contracts;

    /// <summary>
    /// The historical record of security price.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="ISecurity"/>.</typeparam>
    [ContractClass(typeof(HistoricalRecordContract))]
    public interface IHistoricalRecord<out T>
        where T : ISecurity
    {
        /// <summary>
        /// Gets the highest price of a security trading.
        /// </summary>
        IHistoryPrice<T> High { get; }

        /// <summary>
        /// Gets the lowest price of a security trading.
        /// </summary>
        IHistoryPrice<T> Low { get; }

        /// <summary>
        /// Gets the open price of a security trading.
        /// </summary>
        IHistoryPrice<T> Open { get; }

        /// <summary>
        /// Gets the final price at which a security is traded on a trading day.
        /// </summary>
        IHistoryPrice<T> Close { get; }

        /// <summary>
        /// Gets the volume of trading of a security.
        /// </summary>
        long Volume { get; }

        /// <summary>
        /// Gets the date and time of the record.
        /// </summary>
        /// <value>The date and time of the record.</value>
        long DateTime { get; }
    }
}
