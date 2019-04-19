// <copyright file="Requisites.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam.Report
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// Реквизиты документа.
    /// </summary>
    [Serializable()]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.CodeAnalysis.FxCopAnalyzers", "CA2235: Mark all non-serializable fields")]
    public sealed class Requisites
    {
        /// <summary>
        /// Заголовок документа.
        /// </summary>
        /// <value>The title.</value>
        [XmlAttribute]
        public string Title { get; set; }

        /// <summary>
        /// Заголовок отчета.
        /// </summary>
        /// <value>The text.</value>
        [XmlAttribute]
        public string Text { get; set; }

        /// <summary>
        /// Наименование брокера.
        /// </summary>
        /// <value>The firm.</value>
        [XmlAttribute]
        public string Firm { get; set; }

        /// <summary>
        /// Дата начала отчета.
        /// </summary>
        /// <value>The date begin.</value>
        [XmlAttribute]
        public string DateBegin { get; set; }

        /// <summary>
        /// Дата окончания отчета.
        /// </summary>
        /// <value>The date end.</value>
        [XmlAttribute]
        public string DateEnd { get; set; }

        /// <summary>
        /// Дата создания отчета.
        /// </summary>
        /// <value>The date create.</value>
        [XmlAttribute]
        public string DateCreate { get; set; }

        /// <summary>
        /// Количество дней, за которые построен отчет.
        /// </summary>
        /// <value>The amount days.</value>
        [XmlAttribute]
        public string AmountDays { get; set; }

        [XmlElement("TEMPLATE")]
        public Template Template { get; set; }
    }
}
