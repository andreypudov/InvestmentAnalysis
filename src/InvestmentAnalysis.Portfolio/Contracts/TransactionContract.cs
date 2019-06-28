// <copyright file="TransactionContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Contracts
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The contract class for <see cref="ITransaction{T, P}"/>.
    /// </summary>
    [ContractClassFor(typeof(ITransaction<,>))]
    public abstract class TransactionContract : ITransaction<ISecurity, IPrice<ISecurity>>
    {
        /// <inheritdoc />
        public TransactionType TransactionType => Contract.Result<TransactionType>();

        /// <inheritdoc />
        public long DateTime => Contract.Result<int>();

        /// <inheritdoc />
        public ISecurity Security => Contract.Result<ISecurity>();

        /// <inheritdoc />
        public int Units => Contract.Result<int>();

        /// <inheritdoc />
        public IPrice<ISecurity> Price => Contract.Result<IPrice<ISecurity>>();

        /// <inheritdoc />
        public string Description => Contract.Result<string>();
    }
}
