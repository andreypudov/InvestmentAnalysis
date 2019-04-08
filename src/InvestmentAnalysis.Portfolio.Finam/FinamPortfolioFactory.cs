// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using InvestmentAnalysis.Portfolio.Finam.Report;

namespace InvestmentAnalysis.Portfolio.Finam
{
    internal sealed class FinamPortfolioFactory : IPortfolioFactory<FinamPortfolio>
    {
        private readonly FinamReport _report;

        public FinamPortfolioFactory(FinamReport report)
        {
            _report = report;
        }

        public FinamPortfolio CreatePortfolio()
        {
            return FinamPortfolio.Empty;
        }
    }
}
