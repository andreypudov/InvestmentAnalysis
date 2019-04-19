// <copyright file="IPortfolio.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    [ContractClass(typeof(PortfolioContract))]
    public interface IPortfolio<out T> where T : ITransaction
    {
        IEnumerable<T> Transactions { get; }
    }
}
