// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Xml.Serialization;

namespace InvestmentAnalysis.Portfolio.Finam.FinamReport
{
    /// <summary>
    /// Строка таблицы с итогами.
    /// </summary>
    [Serializable()]
    public class TradingMovementsOfSecuritiesTotal
    {
        /// <summary>
        /// Итого.
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute]
        public string Name { get; set; }

        /// <summary>
        /// Сумма по колонке Вознаграждение Брокера, биржевой сбор. (optional)
        /// </summary>
        /// <value>The fee.</value>
        [XmlAttribute]
        public decimal Fee { get; set; }

        /// <summary>
        /// Валюта Вознаграждения Брокера, биржевого сбора. (optional)
        /// </summary>
        /// <value>The fee currency.</value>
        [XmlAttribute("CurF")]
        public string FeeCurrency { get; set; }
    }
}
