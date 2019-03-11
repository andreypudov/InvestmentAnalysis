// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System.Collections.Generic;

namespace InvestmentAnalysis.Portfolio
{
    public interface IPortfolio
    {
        IEnumerable<ITransaction> Transactions { get; set; }
    }
}