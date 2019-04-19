// <copyright file="FinamPortfolio.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Diagnostics.Contracts;
    using System.Linq;

    /// <summary>
    /// The collection of individual transactions.
    /// </summary>
    public class FinamPortfolio : IPortfolio<FinamTransaction>
    {
        /// <summary>
        /// Represents the empty <c>FinamPortfolio</c>.
        /// </summary>
        public static readonly FinamPortfolio Empty = new NullPortfolio();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinamPortfolio"/> class that is empty.
        /// </summary>
        public FinamPortfolio()
        {
            this.Transactions = Enumerable.Empty<FinamTransaction>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinamPortfolio"/> class that contains elements copied from the specified collection and has sufficient capacity to accommodate the number of elements copied.
        /// </summary>
        /// <param name="collection">The collection whose elements are copied to the new list.</param>
        /// <exception cref="ArgumentNullException"><paramref name="collection">collection</paramref> is null.</exception>
        public FinamPortfolio(IEnumerable<FinamTransaction> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            this.Transactions = collection.ToImmutableList();
        }

        /// <inheritdoc/>
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
