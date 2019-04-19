// <copyright file="FinamPortfolioFactory.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam
{
    using System;
    using System.Linq;
    using System.Xml;
    using System.Xml.Serialization;
    using InvestmentAnalysis.Portfolio.Finam.Report;

    /// <summary>
    /// Provides access to factory methods for creating and configuring <c>FinamPortfolio</c> instance.
    /// </summary>
    internal sealed class FinamPortfolioFactory : IPortfolioFactory<FinamPortfolio>
    {
        private const string RussianStandardTimeZoneId = "Russian Standard Time";
        private const string EuropeMoscowTimeZoneId = "Europe/Moscow";

        private readonly TimeZoneInfo russianStandardTime = TimeZoneInfo.GetSystemTimeZones()
                .First(tz => ((tz.Id == RussianStandardTimeZoneId) || (tz.Id == EuropeMoscowTimeZoneId)));

        /// <inheritdoc/>
        public FinamPortfolio CreatePortfolio(XmlReader reader)
        {
            var serializer = new XmlSerializer(typeof(FinamReport));
            var report = (FinamReport)serializer.Deserialize(reader);

            var transactions = report
                .Sections
                .TradingMovementsOfSecurities
                .Rows
                .Select(this.GetTradingMovementsTransaction);

            return new FinamPortfolio(transactions);
        }

        private static TransactionType GetTransactionType(string tradeType)
        {
            switch (tradeType)
            {
                case "Покупка":
                    return TransactionType.Buy;
                case "Продажа":
                    return TransactionType.Sell;
                default:
                    return TransactionType.Invalid;
            }
        }

        private FinamTransaction GetTradingMovementsTransaction(TradingMovementsOfSecuritiesRow row)
        {
            return new FinamTransaction(
                symbol: row.ShortName,
                transactionType: GetTransactionType(row.TradeType),
                date: TimeZoneInfo.ConvertTime(DateTime.ParseExact(row.TradeDate, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture).Add(row.TradeTime.TimeOfDay), this.russianStandardTime, TimeZoneInfo.Utc).Ticks,
                units: (int)row.Quantity,
                price: row.Price,
                currency: FinamCurrency.Parse(row.Currency));
        }
    }
}
