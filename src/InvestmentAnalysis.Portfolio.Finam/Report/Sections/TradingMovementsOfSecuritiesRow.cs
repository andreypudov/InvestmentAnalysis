// <copyright file="TradingMovementsOfSecuritiesRow.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio.Finam.Report
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// Строка таблицы "Торговые движения ценных бумаг (включая незавершенные сделки), в т.ч. Комиссии".
    /// </summary>
    [Serializable]
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Microsoft.CodeAnalysis.FxCopAnalyzers",
        "CA2235: Mark all non-serializable fields",
        Justification = "Ignore false positive in 2.6.* package.")]
    public sealed class TradingMovementsOfSecuritiesRow
    {
        /// <summary>
        /// Дата сделки.
        /// </summary>
        /// <value>The trade date.</value>
        [XmlAttribute("D")]
        public string TradeDate { get; set; }

        /// <summary>
        /// Время сделки. (optional)
        /// </summary>
        /// <value>The trade time.</value>
        [XmlAttribute("T")]
        public DateTime TradeTime { get; set; }

        /// <summary>
        /// Краткое наименование ценной бумаги. (optional)
        /// </summary>
        /// <value>The short name.</value>
        [XmlAttribute("IS")]
        public string ShortName { get; set; }

        /// <summary>
        /// International Securities Identification Number. (optional)
        /// </summary>
        /// <value>The international securities identification number.</value>
        [XmlAttribute("ISIN")]
        public string ISIN { get; set; }

        /// <summary>
        /// Вид сделки / Операция.
        /// </summary>
        /// <value>The type of the trade.</value>
        [XmlAttribute("Op")]
        public string TradeType { get; set; }

        /// <summary>
        /// Количество (шт.). (optional)
        /// </summary>
        /// <value>The quantity.</value>
        [XmlAttribute("Qty")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Цена сделки. (optional)
        /// </summary>
        /// <value>The price.</value>
        [XmlAttribute("Pr")]
        public decimal Price { get; set; }

        /// <summary>
        /// Валюта цены. (optional)
        /// </summary>
        /// <value>The currency.</value>
        [XmlAttribute("Cur")]
        public string Currency { get; set; }

        /// <summary>
        /// Накопленный купонный доход. (optional)
        /// </summary>
        /// <value>The acy.</value>
        [XmlAttribute("ACY")]
        public decimal AccruedInterest { get; set; }

        /// <summary>
        /// Сумма сделки в валюте цены. (optional)
        /// </summary>
        /// <value>The trade amount in price currency.</value>
        [XmlAttribute("SPr")]
        public decimal TradeAmountInPriceCurrency { get; set; }

        /// <summary>
        /// Сумма сделки в валюте цены с НКД. (optional)
        /// </summary>
        /// <value>The trade amount in price currency with accrued interest.</value>
        [XmlAttribute("SPrA")]
        public decimal TradeAmountInPriceCurrencyWithAccruedInterest { get; set; }

        /// <summary>
        /// Валюта оплаты. (optional)
        /// </summary>
        /// <value>The payment currency.</value>
        [XmlAttribute("CurP")]
        public string PaymentCurrency { get; set; }

        /// <summary>
        /// Курс к рублю. (optional)
        /// </summary>
        /// <value>The ruble exchange rate.</value>
        [XmlAttribute("Rt")]
        public decimal RubleExchangeRate { get; set; }

        /// <summary>
        /// Сумма оплаты по сделке в валюте оплаты с НКД. (optional)
        /// </summary>
        /// <value>The payment amount in price currency with accrued interest.</value>
        [XmlAttribute("SPay")]
        public decimal PaymentAmountInPriceCurrencyWithAccruedInterest { get; set; }

        /// <summary>
        /// Вознаграждение Брокера, биржевой сбор. (optional)
        /// </summary>
        /// <value>The fee.</value>
        [XmlAttribute("Fee")]
        public decimal Fee { get; set; }

        /// <summary>
        /// Валюта Вознаграждения Брокера, биржевого сбора. (optional)
        /// </summary>
        /// <value>The fee currency.</value>
        [XmlAttribute("CurF")]
        public string FeeCurrency { get; set; }

        /// <summary>
        /// Задолженность по оплате. (optional)
        /// </summary>
        /// <value>he debt payment.</value>
        [XmlAttribute("DebtP")]
        public decimal DebtPayment { get; set; }

        /// <summary>
        /// Задолженность по поставке. (optional)
        /// </summary>
        /// <value>The debt delivery.</value>
        [XmlAttribute("DebtD")]
        public decimal DebtDelivery { get; set; }

        /// <summary>
        /// Дата оплаты (план). (optional)
        /// </summary>
        /// <value>The planned payment date.</value>
        [XmlAttribute("DPayP")]
        public string PlannedPaymentDate { get; set; }

        /// <summary>
        /// Дата поставки (план). (optional)
        /// </summary>
        /// <value>The planned delivery date.</value>
        [XmlAttribute("DDelP")]
        public string PlannedDeliveryDate { get; set; }

        /// <summary>
        /// Дата оплаты (факт). (optional)
        /// </summary>
        /// <value>The actual payment date.</value>
        [XmlAttribute("DPayF")]
        public string ActualPaymentDate { get; set; }

        /// <summary>
        /// Дата поставки (факт). (optional)
        /// </summary>
        /// <value>The actual delivery date.</value>
        [XmlAttribute("DDelF")]
        public string ActualDeliveryDate { get; set; }

        /// <summary>
        /// Режим торгов. (optional)
        /// </summary>
        /// <value>The trading mode.</value>
        [XmlAttribute("M")]
        public string TradingMode { get; set; }

        /// <summary>
        /// Площадка. (optional)
        /// </summary>
        /// <value>The stock exchange.</value>
        [XmlAttribute("P")]
        public string StockExchange { get; set; }

        /// <summary>
        /// Номер поручения/биржевой заявки. (optional)
        /// </summary>
        /// <value>The request number.</value>
        [XmlAttribute("RqNo")]
        public string RequestNumber { get; set; }

        /// <summary>
        /// № сделки. (optional)
        /// </summary>
        /// <value>The trade number.</value>
        [XmlAttribute("TrdN")]
        public string TradeNumber { get; set; }

        /// <summary>
        /// Ценная бумага (эмитент, вид, тип, категория, выпуск, транш, серия, № гос. регистрации). (optional)
        /// </summary>
        /// <value>The security.</value>
        [XmlAttribute("I")]
        public string Security { get; set; }

        /// <summary>
        /// Комментарии. (optional)
        /// </summary>
        /// <value>The comment.</value>
        [XmlAttribute("C")]
        public string Comment { get; set; }
    }
}
