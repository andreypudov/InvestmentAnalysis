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
    [Serializable]
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Microsoft.CodeAnalysis.FxCopAnalyzers",
        "CA2235: Mark all non-serializable fields",
        Justification = "Ignore false positive in 2.6.* package.")]
    public sealed class Requisites
    {
        /// <summary>
        /// Gets or sets the title of the document [Заголовок документа].
        /// </summary>
        /// <value>The title of the document [Заголовок документа].</value>
        [XmlAttribute]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the title of the report [Заголовок отчета].
        /// </summary>
        /// <value>The title of the report [Заголовок отчета].</value>
        [XmlAttribute]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the name of the broker [Наименование брокера].
        /// </summary>
        /// <value>The name of the broker [Наименование брокера].</value>
        [XmlAttribute]
        public string Firm { get; set; }

        /// <summary>
        /// Gets or sets the start date of the report [Дата начала отчета].
        /// </summary>
        /// <value>The start date of the report [Дата начала отчета].</value>
        [XmlAttribute]
        public string DateBegin { get; set; }

        /// <summary>
        /// Gets or sets the end date of the report [Дата окончания отчета].
        /// </summary>
        /// <value>The end date of the report [Дата окончания отчета].</value>
        [XmlAttribute]
        public string DateEnd { get; set; }

        /// <summary>
        /// Gets or sets the creation date of the report [Дата создания отчета].
        /// </summary>
        /// <value>The creation date of the report [Дата создания отчета].</value>
        [XmlAttribute]
        public string DateCreate { get; set; }

        /// <summary>
        /// Gets or sets the amount of days in the report [Количество дней, за которые построен отчет].
        /// </summary>
        /// <value>The amount of days in the report [Количество дней, за которые построен отчет].</value>
        [XmlAttribute]
        public string AmountDays { get; set; }

        /// <summary>
        /// Gets or sets the template of the report.
        /// </summary>
        /// <value>The template of the report.</value>
        [XmlElement("TEMPLATE")]
        public Template Template { get; set; }
    }
}
