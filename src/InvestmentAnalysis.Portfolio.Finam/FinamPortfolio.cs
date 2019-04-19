// <copyright file="FinamPortfolio.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.Contracts;
using System.Linq;

namespace InvestmentAnalysis.Portfolio.Finam
{
    public class FinamPortfolio : IPortfolio<FinamTransaction>
    {
        public static readonly FinamPortfolio Empty = new NullPortfolio();

        public FinamPortfolio()
        {
            Transactions = Enumerable.Empty<FinamTransaction>();
        }

        /// <summary>Initializes a new instance of the <see cref="InvestmentAnalysis.Portfolio.Finam.FinamPortfolio"></see> class that contains elements copied from the specified collection and has sufficient capacity to accommodate the number of elements copied.</summary>
        /// <param name="collection">The collection whose elements are copied to the new list.</param>
        /// <exception cref="System.ArgumentNullException"><paramref name="collection">collection</paramref> is null.</exception>
        public FinamPortfolio(IEnumerable<FinamTransaction> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            Transactions = collection.ToImmutableList();
        }

        public IEnumerable<FinamTransaction> Transactions
        {
            get;
        }

        private class NullPortfolio : FinamPortfolio
        {
            // internal NullPortfolio() {}
        }
    }
}
