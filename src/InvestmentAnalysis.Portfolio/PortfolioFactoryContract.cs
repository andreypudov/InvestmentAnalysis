// <copyright file="PortfolioFactoryContract.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;
    using System.Xml;

    [ContractClassFor(typeof(IPortfolioFactory<>))]
    public abstract class PortfolioFactoryContract : IPortfolioFactory<IPortfolio<ITransaction>>
    {
        [Pure]
        public IPortfolio<ITransaction> CreatePortfolio(XmlReader reader)
        {
            Contract.Requires(reader != null);

            return Contract.Result<IPortfolio<ITransaction>>();
        }
    }
}
