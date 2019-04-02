// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using InvestmentAnalysis.Portfolio.Finam;

namespace InvestmentAnalysis.CommandLine
{
    public sealed class CommandLineInterface
    {
        public static void Main(/* string[] args */)
        {
            var portfolio = new FinamPortfolioReader(@"SamplePortfolio.xml").Read();

            Console.WriteLine(portfolio);
        }
    }
}
