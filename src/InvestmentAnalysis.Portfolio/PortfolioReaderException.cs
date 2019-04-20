// <copyright file="PortfolioReaderException.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents errors that occur during reading of the portfolio.
    /// </summary>
    public sealed class PortfolioReaderException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioReaderException"/> class.
        /// </summary>
        public PortfolioReaderException()
        {
            // Intentionally left blank
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioReaderException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public PortfolioReaderException(string message)
            : this(message, new List<string>())
        {
            // Intentionally left blank
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioReaderException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public PortfolioReaderException(string message, Exception innerException)
            : base(message, innerException)
        {
            // Intentionally left blank
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioReaderException"/> class with additional user-defined information about the exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="errors">Additional user-defined information about the exception.</param>
        public PortfolioReaderException(string message, IEnumerable<string> errors)
            : base(message)
        {
            this.Data["Errors"] = errors;
        }
    }
}
