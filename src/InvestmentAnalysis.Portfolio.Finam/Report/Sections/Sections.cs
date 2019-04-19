// <copyright file="Sections.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam.Report
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// Разделы "Отчета брокера".
    /// </summary>
    [Serializable]
    public sealed class Sections
    {
        [XmlElement("DB9")]
        public TradingMovementsOfSecurities TradingMovementsOfSecurities { get; set; }
    }
}
