// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace InvestmentAnalysis.Portfolio
{
    [ContractClassFor(typeof(IPortfolio<>))]
    public abstract class PortfolioContract : IPortfolio<ITransaction>
    {
        public IEnumerable<ITransaction> Transactions { get; } = Contract.Result<IEnumerable<ITransaction>>();
    }
}
