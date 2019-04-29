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
    /// Provides access to factory methods for creating and configuring <see cref="FinamPortfolio"/> instance.
    /// </summary>
    internal sealed class FinamPortfolioFactory : IPortfolioFactory<FinamPortfolio>
    {
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

        private FinamTransaction GetTradingMovementsTransaction(TradingMovementsOfSecuritiesRow row)
        {
            return FinamTransactionFactory.CreateTransaction(row);
        }
    }
}
