// <copyright file="FinamPortfolioReader.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;

namespace InvestmentAnalysis.Portfolio.Finam
{
    public sealed class FinamPortfolioReader : IPortfolioReader<FinamPortfolio>
    {
        private readonly string _path;

        /// <summary>
        /// Initializes a new instance of the <see cref="FinamPortfolioReader"/> class for the specified file name.
        /// </summary>
        /// <param name="path">The complete file path to be read.</param>
        public FinamPortfolioReader(string path)
        {
            _path = path ?? throw new ArgumentNullException(nameof(path));
        }

        public FinamPortfolio Read()
        {
            using (var stream = new FileStream(_path, FileMode.Open))
            {
                var validationErrors = new List<string>();
                var portfolio = ReadXml(stream, validationErrors);

                CheckValidation(validationErrors);

                return portfolio;
            }
        }

        /// <summary>
        /// Reads the specified XML stream for a Portfolio schema.
        /// </summary>
        /// <param name="xmlStream">The XML stream.</param>
        /// <param name="validationErrors">The validation errors.</param>
        /// <returns></returns>
        private static FinamPortfolio ReadXml(Stream xmlStream, ICollection<string> validationErrors)
        {
            var portfolio = FinamPortfolio.Empty;

            using (var xsdStream = OpenXsd())
            using (var reader = OpenXml(xmlStream, xsdStream, validationErrors))
            {
                portfolio = new FinamPortfolioFactory().CreatePortfolio(reader);
            }

            return portfolio;
        }

        /// <summary>
        /// Opens the XML stream, given an XSD validation.
        /// </summary>
        /// <param name="xmlStream">The XML stream.</param>
        /// <param name="xsdStream">The XSD stream.</param>
        /// <param name="validationErrors">The validation errors.</param>
        /// <returns></returns>
        private static XmlReader OpenXml(Stream xmlStream, Stream xsdStream, ICollection<string> validationErrors)
        {
            validationErrors.Clear();

            var xmlReaderSettings = new XmlReaderSettings();
            xmlReaderSettings.Schemas.Add(null, XmlReader.Create(xsdStream));
            xmlReaderSettings.ValidationType = ValidationType.Schema;
            xmlReaderSettings.ValidationEventHandler += ((sender, e) => validationErrors.Add(e.Message));

            var xmlValidator = XmlReader.Create(xmlStream, xmlReaderSettings);

            return xmlValidator;
        }

        /// <summary>
        /// Opens the XSD validation file.
        /// </summary>
        /// <returns></returns>
        private static Stream OpenXsd()
        {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(typeof(FinamPortfolioReader), "Schema.xsd");
        }

        private static void CheckValidation(IList<string> validationErrors)
        {
            if (validationErrors.Count > 0)
            {
                throw new PortfolioReaderException(string.Empty, validationErrors);
            }
        }
    }
}
