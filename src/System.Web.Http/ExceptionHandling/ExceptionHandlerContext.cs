﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Web.Http.ExceptionHandling
{
    /// <summary>Represents the context within which unhandled exception handling occurs.</summary>
    public class ExceptionHandlerContext
    {
        private readonly ExceptionContext _exceptionContext;

        /// <summary>Initializes a new instance of the <see cref="ExceptionHandlerContext"/> class.</summary>
        /// <param name="exceptionContext">The exception context.</param>
        public ExceptionHandlerContext(ExceptionContext exceptionContext)
        {
            if (exceptionContext == null)
            {
                throw new ArgumentNullException("exceptionContext");
            }

            _exceptionContext = exceptionContext;
        }

        /// <summary>Gets or sets the exception context providing the exception and related data.</summary>
        public ExceptionContext ExceptionContext
        {
            get { return _exceptionContext; }
        }

        /// <summary>Gets or sets the result providing the response message when the exception is handled.</summary>
        /// <remarks>
        /// If this value is <see langword="null"/>, the exception is left unhandled and will be re-thrown.
        /// </remarks>
        public IHttpActionResult Result { get; set; }
    }
}