// <copyright file="Header.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam.Report
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// The header of the portfolio document [Заголовок документа].
    /// </summary>
    [Serializable]
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Microsoft.CodeAnalysis.FxCopAnalyzers",
        "CA2235: Mark all non-serializable fields",
        Justification = "Ignore false positive in 2.6.* package.")]
    public sealed class Header
    {
        /// <summary>
        /// Gets or sets a value indicating whether report is reference [Тип отчета: справка]. (optional)
        /// </summary>
        /// <value><c>true</c> if report is reference [Тип отчета: справка]; otherwise, <c>false</c>.</value>
        [XmlAttribute("ISREFERENCE")]
        public bool IsReference { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether report is short form [Тип отчета: краткая форма]. (optional)
        /// </summary>
        /// <value><c>true</c> if report is short form [Тип отчета: краткая форма]; otherwise, <c>false</c>.</value>
        [XmlAttribute("ISSHORTFORM")]
        public bool IsShortForm { get; set; }

        /// <summary>
        /// Gets or sets the customer account [Счет клиента].
        /// </summary>
        /// <value>The customer account [Счет клиента].</value>
        [XmlElement("ACCOUNT")]
        public Account Account { get; set; }

        /// <summary>
        /// Gets or sets the customer [Клиент].
        /// </summary>
        /// <value>The customer [Клиент].</value>
        [XmlElement("CLIENT")]
        public Client Client { get; set; }

        /// <summary>
        /// Gets or sets the customer agreement [Договор с клиентом].
        /// </summary>
        /// <value>The customer agreement [Договор с клиентом].</value>
        [XmlElement("CONTRACT")]
        public Contract Contract { get; set; }

        /// <summary>
        /// Gets or sets the custodial account [Счет(а) депо].
        /// </summary>
        /// <value>The custodial account [Счет(а) депо].</value>
        [XmlElement("DP", IsNullable = true)]
        public DepoAccount DepoAccount { get; set; }
    }
}
