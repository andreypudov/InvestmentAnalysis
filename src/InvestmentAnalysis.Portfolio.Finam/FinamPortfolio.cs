// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System.Collections.Generic;

namespace InvestmentAnalysis.Portfolio.Finam
{
    public class FinamPortfolio : IPortfolio
    {
        public static readonly FinamPortfolio Empty = new NullPortfolio();

        public IEnumerable<ITransaction> Transactions
        { 
            get => throw new System.NotImplementedException();
        }

        private class NullPortfolio : FinamPortfolio
        {
            // internal NullPortfolio() { }
            // public override void MakeSound() { }
        }
    }
}
