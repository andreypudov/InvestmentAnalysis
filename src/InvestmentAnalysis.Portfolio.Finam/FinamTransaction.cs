﻿// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;

namespace InvestmentAnalysis.Portfolio.Finam
{
    public class FinamTransaction : ITransaction
    {
        public TransactionType TransactionType { get; }

        public long DateTime { get; }

        public int Units { get; }

        public decimal Price { get; }

        public FinamTransaction(TransactionType transactionType, long date, int units, decimal price)
        {
            TransactionType = transactionType;
            DateTime = date;
            Units = units;
            Price = price;
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
                hashCode = (hashCode * 397) ^ DateTime.GetHashCode();
                hashCode = (hashCode * 397) ^ Units;
                hashCode = (hashCode * 397) ^ Price.GetHashCode();

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
