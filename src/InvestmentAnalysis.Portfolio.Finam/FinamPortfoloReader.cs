// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using InvestmentAnalysis.Runtime.Extensions;

namespace InvestmentAnalysis.Portfolio.Finam
{
    public class FinamPortfoloReader : PortfolioReader
    {
        private const int DefaultBufferSize = 1024; // Byte buffer size

        private string _s;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:InvestmentAnalysis.Portfolio.Finam.FinamPortfoloReader"/> class for the specified file name.
        /// </summary>
        /// <param name="path">The complete file path to be read.</param>
        public FinamPortfoloReader(string path)
            : this(path, true)
        {
        }

        public FinamPortfoloReader(string path, bool detectEncodingFromByteOrderMarks)
            : this(path, Encoding.UTF8, detectEncodingFromByteOrderMarks, DefaultBufferSize)
        {
        }

        public FinamPortfoloReader(string path, Encoding encoding)
            : this(path, encoding, true, DefaultBufferSize)
        {
        }

        public FinamPortfoloReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
            : this(path, encoding, detectEncodingFromByteOrderMarks, DefaultBufferSize)
        {
        }

        public FinamPortfoloReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
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

            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read,
                DefaultFileStreamBufferSize, FileOptions.SequentialScan);

            Init(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize, leaveOpen: false);
        }

        private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
        {
            _stream = stream;
            _encoding = encoding;
            _decoder = encoding.GetDecoder();
            if (bufferSize < MinBufferSize)
            {
                bufferSize = MinBufferSize;
            }

            _byteBuffer = new byte[bufferSize];
            _maxCharsPerBuffer = encoding.GetMaxCharCount(bufferSize);
            _charBuffer = new char[_maxCharsPerBuffer];
            _byteLen = 0;
            _bytePos = 0;
            _detectEncoding = detectEncodingFromByteOrderMarks;
            _checkPreamble = encoding.Preamble.Length > 0;
            _isBlocked = false;
            _closable = !leaveOpen;
        }

        public override void Close() 
        {
            Dispose(true);
        }

        public override Portfolio Read()
        {
            if (disposedValue)
            {
                throw new ObjectDisposedException(null, Messages.ObjectDisposed_ReaderClosed);
            }

            XElement booksFromFile = XElement.Load(@"books.xml");

            return Portfolio.Empty;
        }

        public Task<Portfolio> ReadAsync()
        {
            return Task.FromResult(Read());
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~FinamPortfoloReader() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose the specified disposing.
        /// </summary>
        /// <param name="disposing">If set to <c>true</c> disposing.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _s = null;
                }

                disposedValue = true;
            }
        }
        #endregion
    }
}