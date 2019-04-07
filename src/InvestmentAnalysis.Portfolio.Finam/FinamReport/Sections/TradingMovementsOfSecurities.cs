// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace InvestmentAnalysis.Portfolio.Finam.FinamReport
{
    /// <summary>
    /// Торговые движения ценных бумаг (включая незавершенные сделки), в т.ч. Комиссии.
    /// </summary>
    [Serializable()]
    public class TradingMovementsOfSecurities
    {
        /// <summary>
        /// Название таблицы.
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute]
        public string Name { get; set; }

        [XmlElement("R")]
        public List<TradingMovementsOfSecuritiesRow> Rows { get; set; }

        [XmlElement("T")]
        public List<TradingMovementsOfSecuritiesTotal> Total { get; set; }
    }
}
