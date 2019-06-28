// <copyright file="CommandLineInterface.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.CommandLine
{
    using System;
    using InvestmentAnalysis.Analysis.PortfolioPerformance;
    using InvestmentAnalysis.Portfolio;
    using InvestmentAnalysis.Portfolio.Finam;

    /// <summary>
    /// The InvestmentAnalysis CLI is a command-line tool providing greate experience for managing investment portfolios.
    /// </summary>
    internal sealed class CommandLineInterface
    {
        /// <summary>
        /// The entry point.
        /// </summary>
        private static void Main(/* string[] args */)
        {
            var portfolio = new FinamPortfolioReader(@"SamplePortfolio.xml").Read();
            var analysis = new PortfolioPerformanceAnalysis().Analyze(portfolio);

            foreach (var transaction in portfolio.Transactions)
            {
                switch (transaction.TransactionType)
                {
                    case TransactionType.Buy:
                    case TransactionType.Sell:
                        Console.WriteLine($"{new DateTime(transaction.DateTime).ToShortDateString(), 10} "
                            + $"{transaction.Security.Symbol, -16} "
                            + $"{(transaction.TransactionType == TransactionType.Buy ? "BUY" : "SELL"), -6} "
                            + $"{transaction.Price.Price, -10} {transaction.Price.Currency, -4}");
                        break;
                }
            }

            foreach (var entry in analysis.Result)
            {
                Console.WriteLine($"Key: {entry.Key, 16}, Value: {entry.Value}");
            }
        }
    }
}
