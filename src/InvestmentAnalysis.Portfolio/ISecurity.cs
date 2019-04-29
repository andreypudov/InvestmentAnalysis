// <copyright file="ISecurity.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// Represents a financial security.
    /// </summary>
    [ContractClass(typeof(SecurityContract))]
    public interface ISecurity
    {
        /// <summary>
        /// Gets the International Securities Identification Number. (optional)
        /// </summary>
        /// <value>The international securities identification number.</value>
        string ISIN { get; }

        /// <summary>
        /// Gets the ticker symbol of the stock.
        /// </summary>
        /// <value>The ticker symbol of the stock.</value>
        string Symbol { get; }

        /// <summary>
        /// Gets the description of security.
        /// </summary>
        /// <value>The description of security.</value>
        string Description { get; }
    }
}
