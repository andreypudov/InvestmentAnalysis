// <copyright file="IHistoricalProvider.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using InvestmentAnalysis.Portfolio.Contracts;

    /// <summary>
    /// The collection of historical security prices.
    /// </summary>
    [ContractClass(typeof(HistoricalProviderContract))]
    public interface IHistoricalProvider
    {
        /// <summary>
        /// Returns the collection of historical prices for the <see cref="ISecurity"/> on the provided date range.
        /// </summary>
        /// <param name="security">The financial security.</param>
        /// <param name="startDate">The start date for the query.</param>
        /// <param name="endDate">The end date for the query</param>
        /// <returns>The collection of historical prices for the <see cref="ISecurity"/> on the provided date range.</returns>
        IEnumerable<IHistoryPrice<ISecurity>> GetPrices(ISecurity security, long startDate, long endDate);
    }
}
