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
        /// Gets or sets the date of transaction [Дата сделки].
        /// </summary>
        /// <value>The date of transaction [Дата сделки].</value>
        [XmlAttribute("D")]
        public string TradeDate { get; set; }

        /// <summary>
        /// Gets or sets the time of transaction [Время сделки]. (optional)
        /// </summary>
        /// <value>The time of transaction [Время сделки].</value>
        [XmlAttribute("T")]
        public DateTime TradeTime { get; set; }

        /// <summary>
        /// Gets or sets the short name of security [Краткое наименование ценной бумаги]. (optional)
        /// </summary>
        /// <value>The short name of security [Краткое наименование ценной бумаги].</value>
        [XmlAttribute("IS")]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets the International Securities Identification Number. (optional)
        /// </summary>
        /// <value>The international securities identification number.</value>
        [XmlAttribute("ISIN")]
        public string ISIN { get; set; }

        /// <summary>
        /// Gets or sets the type of transaction [Вид сделки / Операция].
        /// </summary>
        /// <value>The type of transaction [Вид сделки / Операция].</value>
        [XmlAttribute("Op")]
        public string TradeType { get; set; }

        /// <summary>
        /// Gets or sets the quantity of securities [Количество (шт.)]. (optional)
        /// </summary>
        /// <value>The quantity of securities [Количество (шт.)].</value>
        [XmlAttribute("Qty")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or sets the price of security [Цена сделки]. (optional)
        /// </summary>
        /// <value>The price of security [Цена сделки].</value>
        [XmlAttribute("Pr")]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the currency of the price [Валюта цены]. (optional)
        /// </summary>
        /// <value>The currency of the price [Валюта цены].</value>
        [XmlAttribute("Cur")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the accrued interest [Накопленный купонный доход]. (optional)
        /// </summary>
        /// <value>The accrued interest [Накопленный купонный доход].</value>
        [XmlAttribute("ACY")]
        public decimal AccruedInterest { get; set; }

        /// <summary>
        /// Gets or sets the total price of the transaction [Сумма сделки в валюте цены]. (optional)
        /// </summary>
        /// <value>The total price of the transaction [Сумма сделки в валюте цены].</value>
        [XmlAttribute("SPr")]
        public decimal TradeAmountInPriceCurrency { get; set; }

        /// <summary>
        /// Gets or sets the total price of the transaction with accrued interest [Сумма сделки в валюте цены с НКД]. (optional)
        /// </summary>
        /// <value>The total price of the transaction with accrued interest [Сумма сделки в валюте цены с НКД].</value>
        [XmlAttribute("SPrA")]
        public decimal TradeAmountInPriceCurrencyWithAccruedInterest { get; set; }

        /// <summary>
        /// Gets or sets the currency of the payment [Валюта оплаты]. (optional)
        /// </summary>
        /// <value>The currency of the payment [Валюта оплаты].</value>
        [XmlAttribute("CurP")]
        public string PaymentCurrency { get; set; }

        /// <summary>
        /// Gets or sets the exchange rate of the Rubble [Курс к рублю]. (optional)
        /// </summary>
        /// <value>The exchange rate of the Rubble [Курс к рублю].</value>
        [XmlAttribute("Rt")]
        public decimal RubleExchangeRate { get; set; }

        /// <summary>
        /// Gets or sets the total price of the transaction with accrued interest in the currency of the payment [Сумма оплаты по сделке в валюте оплаты с НКД]. (optional)
        /// </summary>
        /// <value>The total price of the transaction with accrued interest in the currency of the payment [Сумма оплаты по сделке в валюте оплаты с НКД].</value>
        [XmlAttribute("SPay")]
        public decimal PaymentAmountInPriceCurrencyWithAccruedInterest { get; set; }

        /// <summary>
        /// Gets or sets the amount of fee [Вознаграждение Брокера, биржевой сбор]. (optional)
        /// </summary>
        /// <value>The amount of fee [Вознаграждение Брокера, биржевой сбор].</value>
        [XmlAttribute("Fee")]
        public decimal Fee { get; set; }

        /// <summary>
        /// Gets or sets the currency of the fee [Валюта Вознаграждения Брокера, биржевого сбора]. (optional)
        /// </summary>
        /// <value>The currency of the fee [Валюта Вознаграждения Брокера, биржевого сбора].</value>
        [XmlAttribute("CurF")]
        public string FeeCurrency { get; set; }

        /// <summary>
        /// Gets or sets the debt of payment [Задолженность по оплате]. (optional)
        /// </summary>
        /// <value>he debt of payment [Задолженность по оплате].</value>
        [XmlAttribute("DebtP")]
        public decimal DebtPayment { get; set; }

        /// <summary>
        /// Gets or sets the debt of delivery [Задолженность по поставке]. (optional)
        /// </summary>
        /// <value>The debt of delivery [Задолженность по поставке].</value>
        [XmlAttribute("DebtD")]
        public decimal DebtDelivery { get; set; }

        /// <summary>
        /// Gets or sets the planned date of payment [Дата оплаты (план)]. (optional)
        /// </summary>
        /// <value>The planned date of payment [Дата оплаты (план)].</value>
        [XmlAttribute("DPayP")]
        public string PlannedPaymentDate { get; set; }

        /// <summary>
        /// Gets or sets the planned date of delivery [Дата поставки (план)]. (optional)
        /// </summary>
        /// <value>The planned date of delivery [Дата поставки (план)].</value>
        [XmlAttribute("DDelP")]
        public string PlannedDeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the actual date of payment [Дата оплаты (факт)]. (optional)
        /// </summary>
        /// <value>The actual date of payment [Дата оплаты (факт)].</value>
        [XmlAttribute("DPayF")]
        public string ActualPaymentDate { get; set; }

        /// <summary>
        /// Gets or sets the actual date of delivery [Дата поставки (факт)]. (optional)
        /// </summary>
        /// <value>The actual date of delivery [Дата поставки (факт)].</value>
        [XmlAttribute("DDelF")]
        public string ActualDeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the settlement date of transaction [Режим торгов]. (optional)
        /// </summary>
        /// <value>The settlement date of transaction [Режим торгов].</value>
        [XmlAttribute("M")]
        public string TradingMode { get; set; }

        /// <summary>
        /// Gets or sets the name of the stock exchange [Площадка]. (optional)
        /// </summary>
        /// <value>The name of the stock exchange [Площадка].</value>
        [XmlAttribute("P")]
        public string StockExchange { get; set; }

        /// <summary>
        /// Gets or sets the number of exchange order [Номер поручения/биржевой заявки]. (optional)
        /// </summary>
        /// <value>The number of exchange order [Номер поручения/биржевой заявки].</value>
        [XmlAttribute("RqNo")]
        public string RequestNumber { get; set; }

        /// <summary>
        /// Gets or sets the number of transaction [№ сделки]. (optional)
        /// </summary>
        /// <value>The number of transaction [№ сделки].</value>
        [XmlAttribute("TrdN")]
        public string TradeNumber { get; set; }

        /// <summary>
        /// Gets or sets the full name of security [Ценная бумага (эмитент, вид, тип, категория, выпуск, транш, серия, № гос. регистрации)]. (optional)
        /// </summary>
        /// <value>The name of security [Ценная бумага (эмитент, вид, тип, категория, выпуск, транш, серия, № гос. регистрации)].</value>
        [XmlAttribute("I")]
        public string Security { get; set; }

        /// <summary>
        /// Gets or sets the note [Комментарии]. (optional)
        /// </summary>
        /// <value>The note [Комментарии].</value>
        [XmlAttribute("C")]
        public string Comment { get; set; }
    }
}
