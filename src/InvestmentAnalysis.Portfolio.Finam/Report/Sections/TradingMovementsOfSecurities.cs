// <copyright file="TradingMovementsOfSecurities.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam.Report
{
    using System;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    /// <summary>
    /// The list of transactions represents secutiry tradings [Торговые движения ценных бумаг (включая незавершенные сделки), в т.ч. Комиссии].
    /// </summary>
    [Serializable]
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Microsoft.CodeAnalysis.FxCopAnalyzers",
        "CA2235: Mark all non-serializable fields",
        Justification = "Ignore false positive in 2.6.* package.")]
    public sealed class TradingMovementsOfSecurities
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradingMovementsOfSecurities"/> class.
        /// </summary>
        public TradingMovementsOfSecurities()
        {
            this.Rows = new Collection<TradingMovementsOfSecuritiesRow>();
            this.Total = new Collection<TradingMovementsOfSecuritiesTotal>();
        }

        /// <summary>
        /// Gets or sets the name of the table [Название таблицы].
        /// </summary>
        /// <value>The name of the table.</value>
        [XmlAttribute]
        public string Name { get; set; }

        /// <summary>
        /// Gets the rows of the trading movements of securities.
        /// </summary>
        /// <value>The rows of the trading movements of securities.</value>
        [XmlElement("R")]
        public Collection<TradingMovementsOfSecuritiesRow> Rows { get; private set; }

        /// <summary>
        /// Gets the total rows of the trading movements of securities.
        /// </summary>
        /// <value>The total rows of the trading movements of securities.</value>
        [XmlElement("T")]
        public Collection<TradingMovementsOfSecuritiesTotal> Total { get; private set; }
    }
}
