// <copyright file="TradingMovementsOfSecuritiesTotal.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam.Report
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// Строка таблицы с итогами.
    /// </summary>
    [Serializable]
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Microsoft.CodeAnalysis.FxCopAnalyzers",
        "CA2235: Mark all non-serializable fields",
        Justification = "Ignore false positive in 2.6.* package.")]
    public sealed class TradingMovementsOfSecuritiesTotal
    {
        /// <summary>
        /// Gets or sets the name of the total column [Итого].
        /// </summary>
        /// <value>The name of the total column [Итого].</value>
        [XmlAttribute]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the amount of broker reward. [Сумма по колонке Вознаграждение Брокера, биржевой сбор]. (optional)
        /// </summary>
        /// <value>The fee.</value>
        [XmlAttribute]
        public decimal Fee { get; set; }

        /// <summary>
        /// Gets or sets the broker reward currency [Валюта Вознаграждения Брокера, биржевого сбора]. (optional)
        /// </summary>
        /// <value>The fee currency.</value>
        [XmlAttribute("CurF")]
        public string FeeCurrency { get; set; }
    }
}
