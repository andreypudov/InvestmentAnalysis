// <copyright file="ITransaction.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System;
    using System.Diagnostics.Contracts;

    [ContractClass(typeof(TransactionContract))]
    public interface ITransaction : IEquatable<ITransaction>
    {
        string Symbol { get; }

        TransactionType TransactionType { get; }

        long DateTime { get; }

        int Units { get; }

        decimal Price { get; }

        Currency Currency { get; }
    }
}
