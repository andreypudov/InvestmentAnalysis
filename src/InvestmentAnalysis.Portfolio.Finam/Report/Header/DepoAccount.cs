// <copyright file="DepoAccount.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam.Report
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// The custodial account [Счет(а) депо].
    /// </summary>
    [Serializable]
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Microsoft.CodeAnalysis.FxCopAnalyzers",
        "CA2235: Mark all non-serializable fields",
        Justification = "Ignore false positive in 2.6.* package.")]
    public sealed class DepoAccount
    {
        /// <summary>
        /// Gets or sets the name of the custodial account [Наименование]. (optional)
        /// </summary>
        /// <value>The name of the custodial account [Наименование].</value>
        [XmlAttribute("N")]
        public string Name { get; set; }
    }
}
