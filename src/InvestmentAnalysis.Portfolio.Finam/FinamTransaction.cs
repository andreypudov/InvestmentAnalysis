// <copyright file="FinamTransaction.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam
{
    using System;

    public sealed class FinamTransaction : ITransaction
    {
        public string Symbol { get; }

        public TransactionType TransactionType { get; }

        public long DateTime { get; }

        public int Units { get; }

        public decimal Price { get; }

        public Currency Currency { get; }

        public FinamTransaction(string symbol, TransactionType transactionType, long date, int units, decimal price, Currency currency)
        {
            this.Symbol = symbol;
            this.TransactionType = transactionType;
            this.DateTime = date;
            this.Units = units;
            this.Price = price;
            this.Currency = currency;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || (this.GetType() != obj.GetType()))
            {
                return false;
            }

            var transaction = (FinamTransaction)obj;
            return (this.Symbol == transaction.Symbol)
                   && (this.TransactionType == transaction.TransactionType)
                   && (this.DateTime == transaction.DateTime)
                   && (this.Units == transaction.Units)
                   && (this.Price == transaction.Price)
                   && (this.Currency == transaction.Currency);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (int)this.TransactionType;

                hashCode = (hashCode * 397) ^ this.Symbol.GetHashCode(StringComparison.Ordinal);
                hashCode = (hashCode * 397) ^ this.TransactionType.GetHashCode();
                hashCode = (hashCode * 397) ^ this.DateTime.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Units;
                hashCode = (hashCode * 397) ^ this.Price.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Currency.GetHashCode();

                return hashCode;
            }
        }

        public bool Equals(ITransaction other)
        {
            if (other == null)
            {
                return false;
            }

            return (this.Symbol == other.Symbol)
                    && (this.TransactionType == other.TransactionType)
                    && (this.DateTime == other.DateTime)
                    && (this.Units == other.Units)
                    && (this.Price == other.Price)
                    && (this.Currency == other.Currency);
        }
    }
}
