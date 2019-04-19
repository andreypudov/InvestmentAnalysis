// <copyright file="PortfolioReaderContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(IPortfolioReader<>))]
    public abstract class PortfolioReaderContract : IPortfolioReader<IPortfolio<ITransaction>>
    {
        [Pure]
        public IPortfolio<ITransaction> Read()
        {
            return Contract.Result<IPortfolio<ITransaction>>();
        }
    }
}
