// <copyright file="CommandLineInterface.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.CommandLine
{
    using System;
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

            Console.WriteLine(portfolio);
        }
    }
}
