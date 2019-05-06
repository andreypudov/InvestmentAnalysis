// <copyright file="TransactionContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The contract class for <see cref="ITransaction{T, P}"/>.
    /// </summary>
    [ContractClassFor(typeof(ITransaction<,>))]
    public abstract class TransactionContract : ITransaction<ISecurity, IPrice<ISecurity>>
    {
        /// <summary>
        /// Gets the type of the transaction.
        /// </summary>
        /// <value>The type of the transaction.</value>
        public TransactionType TransactionType => Contract.Result<TransactionType>();

        /// <summary>
        /// Gets the date and time of the transaction.
        /// </summary>
        /// <value>The date and time of the transaction.</value>
        public long DateTime => Contract.Result<int>();

        /// <summary>
        /// Gets the price of the individual unit.
        /// </summary>
        /// <value>The price of the individual unit.</value>
        public IPrice<ISecurity> Price => Contract.Result<IPrice<ISecurity>>();

        /// <summary>
        /// Gets the description of the transaction.
        /// </summary>
        /// <value>The description of the transaction..</value>
        public string Description => Contract.Result<string>();
    }
}
