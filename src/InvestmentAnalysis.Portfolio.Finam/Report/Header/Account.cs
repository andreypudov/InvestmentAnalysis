﻿// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Xml.Serialization;

namespace InvestmentAnalysis.Portfolio.Finam.Report
{
    /// <summary>
    /// Счет клиента.
    /// </summary>
    [Serializable()]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.CodeAnalysis.FxCopAnalyzers", "CA2235: Mark all non-serializable fields")]
    public sealed class Account
    {
        /// <summary>
        /// Наименование счета клиента.
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute("ID")]
        public uint Id { get; set; }
    }
}