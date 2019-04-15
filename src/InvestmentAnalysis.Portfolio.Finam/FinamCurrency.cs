// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

namespace InvestmentAnalysis.Portfolio.Finam
{
    internal static class FinamCurrency
    {
        public static Currency Parse(string value)
        {
            switch(value)
            {
                case "Рубль":
                    return Currency.RUB;
                case "Доллар США":
                    return Currency.USD;
                default:
                    return Currency.Invalid;
            }
        }
    }
}
