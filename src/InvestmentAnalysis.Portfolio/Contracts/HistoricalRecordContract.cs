// <copyright file="HistoricalRecordContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Contracts
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The contract class for <see cref="IHistoricalRecord{T}"/>.
    /// </summary>
    [ContractClassFor(typeof(IHistoricalRecord<>))]
    public abstract class HistoricalRecordContract : IHistoricalRecord<ISecurity>
    {
        /// <inheritdoc/>
        public IHistoryPrice<ISecurity> High => Contract.Result<IHistoryPrice<ISecurity>>();

        /// <inheritdoc/>
        public IHistoryPrice<ISecurity> Low => Contract.Result<IHistoryPrice<ISecurity>>();

        /// <inheritdoc/>
        public IHistoryPrice<ISecurity> Open => Contract.Result<IHistoryPrice<ISecurity>>();

        /// <inheritdoc/>
        public IHistoryPrice<ISecurity> Close => Contract.Result<IHistoryPrice<ISecurity>>();

        /// <inheritdoc/>
        public long Volume => Contract.Result<long>();

        /// <inheritdoc/>
        public long DateTime => Contract.Result<long>();
    }
}
