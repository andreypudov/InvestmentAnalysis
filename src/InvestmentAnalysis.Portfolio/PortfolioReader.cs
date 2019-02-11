// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;

namespace InvestmentAnalysis.Portfolio
{
    public abstract class PortfolioReader : IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:InvestmentAnalysis.Portfolio.PortfolioReader"/> class.
        /// </summary>
        /// <remarks>
        /// Use this constructor for derived classes.
        /// </remarks>
        protected PortfolioReader() 
        {
            // Intentionally left blank.
        }

        /// <summary>
        /// Closes the <see cref="T:InvestmentAnalysis.Portfolio.PortfolioReader"/> and releases any system resources associated with the <code>PortfolioReader</code>.
        /// </summary>
        /// <remarks>
        /// This implementation of <code>Close</code> calls the <see cref="M:PortfolioReader.Dispose(Boolean)"/> method and passes it a true value. 
        /// </remarks>
        public virtual void Close()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual Portfolio Read()
        {
            return Portfolio.Empty;
        }

        #region IDisposable Support
        /// <summary>
        /// Releases all resource used by the <see cref="T:InvestmentAnalysis.Portfolio.PortfolioReader"/> object.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="T:InvestmentAnalysis.Portfolio.PortfolioReader"/> and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            // Intentionally left blank.
        }
        #endregion
    }
}