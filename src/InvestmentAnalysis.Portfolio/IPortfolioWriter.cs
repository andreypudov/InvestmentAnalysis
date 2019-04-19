// <copyright file="IPortfolioWriter.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;

    [ContractClass(typeof(PortfolioWriterContract))]
    public interface IPortfolioWriter<in T> where T : IPortfolio<ITransaction>
    {
        void Write(T portfolio);
    }
}
