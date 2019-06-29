// <copyright file="CommandLineInterface.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.CommandLine
{
    using System;
    using System.CommandLine;
    using System.IO;
    using InvestmentAnalysis.Analysis.PortfolioPerformance;
    using InvestmentAnalysis.Portfolio;
    using InvestmentAnalysis.Portfolio.Finam;

    /// <summary>
    /// The InvestmentAnalysis CLI is a command-line tool providing greate experience for managing investment portfolios.
    /// </summary>
    internal sealed class CommandLineInterface
    {
        /// <summary>
        /// Investment portfolio analysis tool. Copyright (c) Andrey Pudov. All Rights Reserved.
        /// </summary>
        /// <param name="portfolioOption">The path to the portfolio report file.</param>
        private static void Main(FileInfo portfolioOption)
        {
            if ((portfolioOption.Exists != true) || (portfolioOption.Attributes != FileAttributes.Normal))
            {
                throw new ArgumentException($"Invalid value of the portfolio report argument.");
            }

            var portfolio = new FinamPortfolioReader(portfolioOption.FullName).Read();
            var analysis = new PortfolioPerformanceAnalysis().Analyze(portfolio);

            Console.WriteLine("Transactions:");
            foreach (var transaction in portfolio.Transactions)
            {
                switch (transaction.TransactionType)
                {
                    case TransactionType.Buy:
                    case TransactionType.Sell:
                        Console.WriteLine($"{new DateTime(transaction.DateTime).ToShortDateString(), 10} "
                            + $"{transaction.Security.Symbol, -16} "
                            + $"{(transaction.TransactionType == TransactionType.Buy ? "BUY" : "SELL"), -6} "
                            + $"{transaction.Units, -6} "
                            + $"{transaction.Price.Price, -10} {transaction.Price.Currency, -4}");
                        break;
                }
            }

            Console.WriteLine("\nPerformance Analysis:");
            foreach (var entry in analysis.Result)
            {
                Console.WriteLine($"  {entry.Key.Symbol, -16} {entry.Value.Price, -14} {entry.Value.Currency, -4}");
            }
        }
    }
}
