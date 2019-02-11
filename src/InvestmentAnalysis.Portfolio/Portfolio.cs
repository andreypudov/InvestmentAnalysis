// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

namespace InvestmentAnalysis.Portfolio
{
    public abstract class Portfolio
    {
        public static readonly Portfolio Empty = new NullPortfolio();

        private class NullPortfolio : Portfolio
        {
            // internal NullPortfolio() { }
            // public override void MakeSound() { }
        }

        // public abstract void MakeSound();
    }
}