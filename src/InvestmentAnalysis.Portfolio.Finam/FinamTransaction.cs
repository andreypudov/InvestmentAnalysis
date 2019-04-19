// <copyright file="FinamTransaction.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

using System;

namespace InvestmentAnalysis.Portfolio.Finam
{
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
            Symbol = symbol;
            TransactionType = transactionType;
            DateTime = date;
            Units = units;
            Price = price;
            Currency = currency;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || (GetType() != obj.GetType()))
            {
                return false;
            }

            var transaction = (FinamTransaction) obj;
            return ((TransactionType == transaction.TransactionType)
                   && (DateTime == transaction.DateTime)
                   && (Units == transaction.Units)
                   && (Price == transaction.Price));
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (int) TransactionType;

                hashCode = (hashCode * 397) ^ Symbol.GetHashCode(StringComparison.Ordinal);
                hashCode = (hashCode * 397) ^ TransactionType.GetHashCode();
                hashCode = (hashCode * 397) ^ DateTime.GetHashCode();
                hashCode = (hashCode * 397) ^ Units;
                hashCode = (hashCode * 397) ^ Price.GetHashCode();
                hashCode = (hashCode * 397) ^ Currency.GetHashCode();

                return hashCode;
            }
        }

        public bool Equals(ITransaction other)
        {
            if (other == null)
            {
                return false;
            }

            return ((TransactionType == other.TransactionType)
                    && (DateTime == other.DateTime)
                    && (Units == other.Units)
                    && (Price == other.Price));
        }
    }
}
