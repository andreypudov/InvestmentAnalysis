// <copyright file="Header.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam.Report
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// Заголовок документа.
    /// </summary>
    [Serializable]
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Microsoft.CodeAnalysis.FxCopAnalyzers",
        "CA2235: Mark all non-serializable fields",
        Justification = "Ignore false positive in 2.6.* package.")]
    public sealed class Header
    {
        [XmlAttribute("ISREFERENCE")]
        public bool IsReference { get; set; }

        [XmlAttribute("ISSHORTFORM")]
        public bool IsShortForm { get; set; }

        [XmlElement("ACCOUNT")]
        public Account Account { get; set; }

        [XmlElement("CLIENT")]
        public Client Client { get; set; }

        [XmlElement("CONTRACT")]
        public Contract Contract { get; set; }

        [XmlElement("DP", IsNullable = true)]
        public DepoAccount DepoAccount { get; set; }
    }
}
