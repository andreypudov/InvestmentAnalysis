// <copyright file="FinamReport.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam.Report
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// The portfolio report of Finam broker.
    /// </summary>
    [Serializable]
    [XmlRoot("REPORT_DOC")]
    public sealed class FinamReport
    {
        /// <summary>
        /// Gets or sets the details of the portfolio document [Реквизиты документа].
        /// </summary>
        /// <value>The details of the portfolio document [Реквизиты документа].</value>
        [XmlElement("DOC_REQUISITES")]
        public Requisites Requisites { get; set; }

        /// <summary>
        /// Gets or sets the header of the portfolio document [Заголовок документа].
        /// </summary>
        /// <value>The header of the portfolio document [Заголовок документа].</value>
        [XmlElement("HEADER_DOC")]
        public Header Header { get; set; }

        /// <summary>
        /// Gets or sets the sections of the broker report [Разделы "Отчета брокера"].
        /// </summary>
        /// <value>The sections of the broker report [Разделы "Отчета брокера"].</value>
        [XmlElement("SECTIONS")]
        public Sections Sections { get; set; }
    }
}
