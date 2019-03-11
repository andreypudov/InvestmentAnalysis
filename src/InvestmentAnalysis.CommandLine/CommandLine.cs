// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using InvestmentAnalysis.Portfolio.Finam;

namespace InvestmentAnalysis.CommandLine
{
    public sealed class CommandLine
    {
        public static void Main(string[] args)
        {
            var portfolio = new FinamPortfolioReader(
                @"/Users/andrey/Dropbox/Documents/Finance/Investments/Reports/Пудов Андрей Семенович КлФ-ИИС903418 (01.10.2018 по 31.12.2018).xml")
                .Read();

            Console.WriteLine(portfolio);
        }
    }
}
