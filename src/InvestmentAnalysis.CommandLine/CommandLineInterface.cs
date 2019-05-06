// <copyright file="CommandLineInterface.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.CommandLine
{
    using System;
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

            foreach (var transaction in portfolio.Transactions)
            {
                switch (transaction.TransactionType)
                {
                    case TransactionType.Buy:
                    case TransactionType.Sell:
                        var entry = transaction as ITradeTransaction<ISecurity>;
                        Console.WriteLine($"{new DateTime(entry.DateTime).ToShortDateString()} "
                            + $"{entry.Security.Symbol} "
                            + $"{(entry.TransactionType == TransactionType.Buy ? "BUY" : "SELL")} "
                            + $"{entry.Price} {entry.Currency}");
                        break;
                }
            }
        }
    }
}
