// <copyright file="IPortfolio.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace InvestmentAnalysis.Portfolio
{
    [ContractClass(typeof(PortfolioContract))]
    public interface IPortfolio<out T> where T : ITransaction
    {
        IEnumerable<T> Transactions { get; }
    }
}
