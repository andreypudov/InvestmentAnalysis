// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Xml.Serialization;

namespace InvestmentAnalysis.Portfolio.Finam.FinamReport
{
    /// <summary>
    /// Счет(а) депо.
    /// </summary>
    [Serializable()]
    public class DepoAccount
    {
        /// <summary>
        /// Наименование. (optional)
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute("N")]
        public string Name { get; set; }
    }
}
