// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace InvestmentAnalysis.Portfolio.Finam
{
    public class FinamPortfolio : IPortfolio
    {
        public static readonly FinamPortfolio Empty = new NullPortfolio();

        public FinamPortfolio()
        {
            Transactions = Enumerable.Empty<ITransaction>();
        }

        /// <summary>Initializes a new instance of the <see cref="T:InvestmentAnalysis.Portfolio.Finam.FinamPortfolio`1"></see> class that contains elements copied from the specified collection and has sufficient capacity to accommodate the number of elements copied.</summary>
        /// <param name="collection">The collection whose elements are copied to the new list.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="collection">collection</paramref> is null.</exception>
        public FinamPortfolio(IEnumerable<ITransaction> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            Transactions = new List<ITransaction>(collection);
        }

        public IEnumerable<ITransaction> Transactions
        {
            get;
        }

        private class NullPortfolio : FinamPortfolio
        {
            internal NullPortfolio() {}
        }
    }
}
