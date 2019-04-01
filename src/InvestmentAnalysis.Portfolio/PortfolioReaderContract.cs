// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System.Diagnostics.Contracts;

namespace InvestmentAnalysis.Portfolio
{
    [ContractClassFor(typeof(IPortfolioReader))]
    public abstract class PortfolioReaderContract : IPortfolioReader
    {
        [Pure]
        public IPortfolio Read()
        {
            return Contract.Result<IPortfolio>();
        }
    }
}
