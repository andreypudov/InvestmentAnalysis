// <copyright file="FinamTransactionFactory.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam
{
    using System;
    using System.Linq;
    using InvestmentAnalysis.Portfolio.Finam.Report;

    /// <summary>
    /// Provides access to factory methods for creating and configuring <see cref="FinamTransaction"/> instance.
    /// </summary>
    internal static class FinamTransactionFactory
    {
        private const string RussianStandardTimeZoneId = "Russian Standard Time";
        private const string EuropeMoscowTimeZoneId = "Europe/Moscow";
        private const string BuyTransaction = "Покупка";
        private const string SellTransaction = "Продажа";
        private const string BrokerageFree = "Комиссия брокерская";
        private const string DepositoryFee = "Комиссия депозитария";

        private static readonly TimeZoneInfo RussianStandardTime = TimeZoneInfo.GetSystemTimeZones()
                .First(tz => ((tz.Id == RussianStandardTimeZoneId) || (tz.Id == EuropeMoscowTimeZoneId)));

        /// <summary>
        /// Creates a new instance of the <see cref="FinamTransaction"/> class based on the type of transaction.
        /// </summary>
        /// <param name="row">The trading movements row.</param>
        /// <returns>A new instance of the <see cref="FinamTransaction"/> class.</returns>
        public static FinamTransaction CreateTransaction(TradingMovementsOfSecuritiesRow row)
        {
            switch (row.TradeType)
            {
                case BuyTransaction:
                case SellTransaction:
                    return CreateBuyOrSellTransaction(row);
                case BrokerageFree:
                case DepositoryFee:
                    return CreateFeeTransaction(row);
                default:
                    return null;
            }
        }

        private static FinamTradeTransaction CreateBuyOrSellTransaction(TradingMovementsOfSecuritiesRow row)
        {
            return new FinamTradeTransaction(
                security: new FinamSecurity(row.ISIN, row.ShortName, row.Security),
                transactionType: (row.TradeType == BuyTransaction) ? TransactionType.Buy : TransactionType.Sell,
                date: GetTransactionDateTime(row),
                units: (int)row.Quantity,
                price: new FinamPrice(row.Price, FinamCurrency.Parse(row.Currency)),
                description: row.Comment);
        }

        private static FinamServiceTransaction CreateFeeTransaction(TradingMovementsOfSecuritiesRow row)
        {
            return new FinamServiceTransaction(
                transactionType: TransactionType.OtherExpense,
                date: GetTransactionDateTime(row),
                price: new FinamPrice(row.Fee, FinamCurrency.Parse(row.FeeCurrency)),
                description: row.Comment);
        }

        private static long GetTransactionDateTime(TradingMovementsOfSecuritiesRow row)
        {
            return TimeZoneInfo.ConvertTime(
                DateTime
                .ParseExact(row.TradeDate, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture)
                .Add(row.TradeTime.TimeOfDay),
                RussianStandardTime,
                TimeZoneInfo.Utc).Ticks;
        }
    }
}
