using System;
using System.Collections.Generic;

namespace InvestmentAnalysis.Portfolio
{
    public class PortfolioReaderException : Exception
    {
        public PortfolioReaderException(string message)
            : this(message, new List<string>())
        {
        }

        public PortfolioReaderException(string message, IEnumerable<string> errors)
            : base(message)
        {
            Data["Errors"] = errors;
        }
    }
}
