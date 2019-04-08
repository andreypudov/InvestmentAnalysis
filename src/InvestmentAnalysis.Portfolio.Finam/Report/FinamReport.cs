// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Xml.Serialization;

namespace InvestmentAnalysis.Portfolio.Finam.Report
{
    [Serializable()]
    [XmlRoot("REPORT_DOC")]
    public sealed class FinamReport
    {
        [XmlElement("DOC_REQUISITES")]
        public Requisites Requisites { get; set; }

        [XmlElement("HEADER_DOC")]
        public Header Header { get; set; }

        [XmlElement("SECTIONS")]
        public Sections Sections { get; set; }
    }
}
