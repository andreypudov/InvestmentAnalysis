// <copyright file="Account.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam.Report
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// The customer account [Счет клиента].
    /// </summary>
    [Serializable]
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Microsoft.CodeAnalysis.FxCopAnalyzers",
        "CA2235: Mark all non-serializable fields",
        Justification = "Ignore false positive in 2.6.* package.")]
    public sealed class Account
    {
        /// <summary>
        /// Gets or sets the name of the customer account. [Наименование счета клиента].
        /// </summary>
        /// <value>The name of the customer account [Наименование счета клиента].</value>
        [XmlAttribute]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the id of the customer account.
        /// </summary>
        [XmlAttribute("ID")]
        public uint Id { get; set; }
    }
}
