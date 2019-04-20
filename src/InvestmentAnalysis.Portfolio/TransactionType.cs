// <copyright file="TransactionType.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    /// <summary>
    /// The type of the transaction.
    /// </summary>
    public enum TransactionType
    {
        /// <summary>
        /// The transaction is invalid.
        /// </summary>
        Invalid,

        /// <summary>
        /// The buy type of the transaction.
        /// </summary>
        Buy,

        /// <summary>
        /// The sell type of the transaction.
        /// </summary>
        Sell, /* CoverShort, SellShort, */

        /// <summary>
        /// The dividend type of the transaction.
        /// </summary>
        Dividend, /* ReinvestDividend, Split, */

        /// <summary>
        /// The other expense type of the transaction.
        /// </summary>
        OtherExpense,

        /// <summary>
        /// The other income type of the transaction.
        /// </summary>
        OtherIncome
    }
}
