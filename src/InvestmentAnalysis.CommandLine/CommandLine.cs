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
                @"C:\Users\apudov\Dropbox\Documents\Finance\Investments\Reports\Пудов Андрей Семенович КлФ-ИИС903418 (01.01.2017 по 31.03.2017).xml")
                .Read();

            Console.WriteLine(portfolio);
        }
    }
}
