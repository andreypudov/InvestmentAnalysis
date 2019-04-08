// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System.Diagnostics.Contracts;
using System.Xml;

namespace InvestmentAnalysis.Portfolio
{
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
