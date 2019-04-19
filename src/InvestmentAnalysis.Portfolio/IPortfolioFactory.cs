// <copyright file="IPortfolioFactory.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;
    using System.Xml;

    [ContractClass(typeof(PortfolioFactoryContract))]
    public interface IPortfolioFactory<out T> where T : IPortfolio<ITransaction>
    {
        T CreatePortfolio(XmlReader reader);
    }
}
