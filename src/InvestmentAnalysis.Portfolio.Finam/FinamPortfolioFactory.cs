// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using InvestmentAnalysis.Portfolio.Finam.Report;

namespace InvestmentAnalysis.Portfolio.Finam
{
    sealed class FinamPortfolioFactory : IPortfolioFactory<FinamPortfolio>
    {
        private readonly TimeZoneInfo MoscowZone = TimeZoneInfo.FindSystemTimeZoneById("Europe/Moscow");

        public FinamPortfolio CreatePortfolio(XmlReader reader)
        {
            var serializer = new XmlSerializer(typeof(FinamReport));
            var report = (FinamReport) serializer.Deserialize(reader);

            var transactions = report
                .Sections
                .TradingMovementsOfSecurities
                .Rows
                .Select(row => GetTransaction(row));

            return new FinamPortfolio(transactions);
        }

        private FinamTransaction GetTransaction(TradingMovementsOfSecuritiesRow row)
        {
            return new FinamTransaction(
                GetTransactionType(row.TradeType),
                TimeZoneInfo.ConvertTime(
                        DateTime
                            .ParseExact(row.TradeDate, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture)
                            .Add(row.TradeTime.TimeOfDay),
                        MoscowZone,
                        TimeZoneInfo.Utc)
                    .Ticks,
                (int) row.Quantity,
                row.Price);
        }

        private TransactionType GetTransactionType(string tradeType)
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
    }
}
