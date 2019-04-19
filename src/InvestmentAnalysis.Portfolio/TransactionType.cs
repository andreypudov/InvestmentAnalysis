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
        Invalid, Buy, Sell, /* CoverShort, SellShort, */ Dividend, /* ReinvestDividend, Split, */ OtherExpense, OtherIncome
    }
}
