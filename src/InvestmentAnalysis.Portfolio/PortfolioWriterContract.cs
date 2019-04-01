// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System.Diagnostics.Contracts;

namespace InvestmentAnalysis.Portfolio
{
    [ContractClassFor(typeof(IPortfolioWriter))]
    public abstract class PortfolioWriterContract : IPortfolioWriter
    {
        [Pure]
        public void Write(IPortfolio portfolio)
        {
            Contract.Requires(portfolio != null);
        }
    }
}
