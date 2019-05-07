// <copyright file="HistoricalProviderContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Contracts
{
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The contract class for <see cref="IHistoricalProvider"/>.
    /// </summary>
    [ContractClassFor(typeof(IHistoricalProvider))]
    public abstract class HistoricalProviderContract : IHistoricalProvider
    {
        /// <inheritdoc />
        [Pure]
        public IEnumerable<IHistoryPrice<ISecurity>> GetPrices(ISecurity security, long startDate, long endDate) => Contract.Result<IEnumerable<IHistoryPrice<ISecurity>>>();
    }
}
