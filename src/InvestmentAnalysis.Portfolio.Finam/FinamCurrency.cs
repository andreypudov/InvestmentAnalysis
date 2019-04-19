// <copyright file="FinamCurrency.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam
{
    /// <summary>
    /// Provides helper methods for currency management.
    /// </summary>
    internal static class FinamCurrency
    {
        /// <summary>
        /// Converts the string representation of a currency to its ISO 4217 equivalent implemented by <c>Currency</c>.
        /// </summary>
        /// <param name="value">A string containing a currency to convert.</param>
        /// <returns>A ISO 4217 equivalent to the currency specified in value.</returns>
        public static Currency Parse(string value)
        {
            switch (value)
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
