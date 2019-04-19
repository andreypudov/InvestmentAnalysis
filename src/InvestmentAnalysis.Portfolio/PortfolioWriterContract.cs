// <copyright file="PortfolioWriterContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

using System.Diagnostics.Contracts;

namespace InvestmentAnalysis.Portfolio
{
    [ContractClassFor(typeof(IPortfolioWriter<>))]
    public abstract class PortfolioWriterContract : IPortfolioWriter<IPortfolio<ITransaction>>
    {
        public void Write(IPortfolio<ITransaction> portfolio)
        {
            Contract.Requires(portfolio != null);
        }
    }
}
