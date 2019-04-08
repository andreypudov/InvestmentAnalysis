// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System.Xml;
using System.Xml.Serialization;
using InvestmentAnalysis.Portfolio.Finam.Report;

namespace InvestmentAnalysis.Portfolio.Finam
{
    internal sealed class FinamPortfolioFactory : IPortfolioFactory<FinamPortfolio>
    {
        public FinamPortfolio CreatePortfolio(XmlReader reader)
        {
            var serializer = new XmlSerializer(typeof(FinamReport));
            var report = (FinamReport) serializer.Deserialize(reader);

            return FinamPortfolio.Empty;
        }
    }
}
