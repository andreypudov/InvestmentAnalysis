// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using InvestmentAnalysis.Runtime.Extensions;

namespace InvestmentAnalysis.Portfolio.Finam
{
    public sealed class FinamPortfolioReader : PortfolioReader
    {
        private sealed class ValidationException : XmlSchemaValidationException
        {
            public ValidationException(IList<string> errors)
            {
                Data["Errors"] = errors;
            }
        }

        private const int DefaultBufferSize = 1024; // Byte buffer size

        private StreamReader _stream;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:InvestmentAnalysis.Portfolio.Finam.FinamPortfoloReader"/> class for the specified file name.
        /// </summary>
        /// <param name="path">The complete file path to be read.</param>
        public FinamPortfolioReader(string path)
            : this(path, true)
        {
        }

        public FinamPortfolioReader(string path, bool detectEncodingFromByteOrderMarks)
            : this(path, Encoding.Unicode, detectEncodingFromByteOrderMarks, DefaultBufferSize)
        {
        }

        public FinamPortfolioReader(string path, Encoding encoding)
            : this(path, encoding, true, DefaultBufferSize)
        {
        }

        public FinamPortfolioReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
            : this(path, encoding, detectEncodingFromByteOrderMarks, DefaultBufferSize)
        {
        }

        public FinamPortfolioReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
        {
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            if (encoding == null)
            {
                throw new ArgumentNullException(nameof(encoding));
            }

            if (path.Length == 0)
            {
                throw new ArgumentException(Messages.Argument_EmptyPath);
            }

            if (bufferSize <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(bufferSize), Messages.ArgumentOutOfRange_NeedPosNum);
            }

            var stream = new StreamReader(path, encoding, detectEncodingFromByteOrderMarks, bufferSize);

            Init(stream);
        }

        private void Init(StreamReader stream)
        {
            _stream = stream;
        }

        public override void Close()
        {
            Dispose(true);
        }

        public override Portfolio Read()
        {
            if (_disposedValue)
            {
                throw new ObjectDisposedException(null, Messages.ObjectDisposed_ReaderClosed);
            }

            var validationErrors = new List<string>();
            var portfolio = ReadXml(_stream, validationErrors);

            CheckValidation(validationErrors);

            return portfolio;
        }

        public Task<Portfolio> ReadAsync()
        {
            return Task.FromResult(Read());
        }

        /// <summary>
        /// Reads the specified XML stream for a Portfolio schema.
        /// </summary>
        /// <param name="xmlStream">The XML stream.</param>
        /// <param name="validationErrors">The validation errors.</param>
        /// <returns></returns>
        private static Portfolio ReadXml(TextReader xmlStream, ICollection<string> validationErrors)
        {
            using (var xsdStream = OpenXsd())
            using (var reader = OpenXml(xmlStream, xsdStream, validationErrors))
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            Console.WriteLine($"{new string('\t', reader.Depth)} Start Element {reader.Name}");

                            if (reader.HasAttributes)
                            {
                                for (var index = 0; index < reader.AttributeCount; ++index)
                                {
                                    reader.MoveToAttribute(index);
                                    Console.WriteLine($"{new string('\t', reader.Depth + 1)} Attribute {reader.Name} {reader.Value}");
                                }

                                reader.MoveToElement();
                            }
                            break;
                        case XmlNodeType.Text:
                            Console.WriteLine($"{ new string('\t', reader.Depth)} Text Node {reader.Value}");
                            break;
                        case XmlNodeType.EndElement:
                            Console.WriteLine($"{new string('\t', reader.Depth)} End Element {reader.Name}");
                            break;
                        case XmlNodeType.Attribute:
                            Console.WriteLine("Attribute {0}", reader.GetAttribute(0));
                            break;
                        case XmlNodeType.CDATA:
                        case XmlNodeType.Comment:
                        case XmlNodeType.Document:
                        case XmlNodeType.DocumentFragment:
                        case XmlNodeType.DocumentType:
                        case XmlNodeType.EndEntity:
                        case XmlNodeType.Entity:
                        case XmlNodeType.EntityReference:
                        case XmlNodeType.None:
                        case XmlNodeType.Notation:
                        case XmlNodeType.ProcessingInstruction:
                        case XmlNodeType.SignificantWhitespace:
                        case XmlNodeType.Whitespace:
                        case XmlNodeType.XmlDeclaration:
                            break;
                        default:
                            Console.WriteLine("Other node {0} with value {1}",
                                reader.NodeType, reader.Value);
                            break;
                    }
                }
            }

            return Portfolio.Empty;
        }

        /// <summary>
        /// Opens the XML stream, given an XSD validation.
        /// </summary>
        /// <param name="xmlStream">The XML stream.</param>
        /// <param name="xsdStream">The XSD stream.</param>
        /// <param name="validationErrors">The validation errors.</param>
        /// <returns></returns>
        private static XmlReader OpenXml(TextReader xmlStream, Stream xsdStream, ICollection<string> validationErrors)
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
                throw new ValidationException(validationErrors);
            }
        }

        #region IDisposable Support
        private bool _disposedValue = false; // To detect redundant calls

        /// <summary>
        /// Dispose the specified disposing.
        /// </summary>
        /// <param name="disposing">If set to <c>true</c> disposing.</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (!_disposedValue)
                {
                    if (disposing)
                    {
                        _stream.Close();
                    }

                    _disposedValue = true;
                }
            }
            finally
            {
                if (_stream != null)
                {
                    _stream = null;
                    base.Dispose(disposing);
                }
            }
        }
        #endregion
    }
}
