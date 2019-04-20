// <copyright file="Sections.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam.Report
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// The sections of the broker report [Разделы "Отчета брокера"].
    /// </summary>
    [Serializable]
    public sealed class Sections
    {
        /// <summary>
        /// Gets or sets the trading movements of securities [Торговые движения ценных бумаг (включая незавершенные сделки), в т.ч. Комиссии].
        /// </summary>
        /// <value>The trading movements of securities.</value>
        [XmlElement("DB9")]
        public TradingMovementsOfSecurities TradingMovementsOfSecurities { get; set; }
    }
}
