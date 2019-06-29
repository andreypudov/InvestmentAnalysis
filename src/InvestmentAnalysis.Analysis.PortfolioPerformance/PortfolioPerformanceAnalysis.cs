// <copyright file="PortfolioPerformanceAnalysis.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Analysis.PortfolioPerformance
{
    using System;
    using System.Linq;
    using InvestmentAnalysis.Portfolio;

    /// <summary>
    /// The performance analysis.
    /// </summary>
    public sealed class PortfolioPerformanceAnalysis : IAnalysis<ISecurity, IPrice<ISecurity>, PortfolioPerformanceAnalysisResultEntry, PortfolioPerformanceAnalysisResult>
    {
        private static readonly Func<ITransaction<ISecurity, IPrice<ISecurity>>, decimal> TransactionCost = transaction =>
        {
            var price = transaction.Price.Price;

            if (transaction.TransactionType == TransactionType.Buy)
            {
                return price * transaction.Units * -1;
            }

            // transaction.TransactionType == TransactionType.Sell
            return price * transaction.Units;
        };

        /// <inheritdoc />
        public PortfolioPerformanceAnalysisResult Analyze(IPortfolio<ITransaction<ISecurity, IPrice<ISecurity>>> portfolio)
        {
            var dictionary = portfolio.Transactions
                .Where(t => (t.TransactionType == TransactionType.Buy) || (t.TransactionType == TransactionType.Sell))
                .GroupBy(t => t.Security)
                .Select(t => new
                {
                    t.First().Security,
                    Price = t.First().Price.Create(t.Sum(TransactionCost))
                })
                .ToDictionary(d => d.Security, d => d.Price);

            return new PortfolioPerformanceAnalysisResult(dictionary);
        }
    }
}
