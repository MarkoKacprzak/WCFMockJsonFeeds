﻿#region License

// The MIT License
//
// Copyright (c) 2009 Pablo Mariano Cibraro.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.ServiceModel.Web
{
	public class OutgoingWebResponseContextWrapper : IOutgoingWebResponseContext
	{
		private readonly OutgoingWebResponseContext _context;

		public OutgoingWebResponseContextWrapper(OutgoingWebResponseContext context)
		{
			_context = context;
		}

		#region IOutgoingWebResponseContext Members

		public void SetStatusAsCreated(Uri locationUri)
		{
			_context.SetStatusAsCreated(locationUri);
		}

		public void SetStatusAsNotFound()
		{
			_context.SetStatusAsNotFound();
		}

		public void SetStatusAsNotFound(string description)
		{
			_context.SetStatusAsNotFound(description);
		}

		public long ContentLength
		{
			get
			{
				return _context.ContentLength;
			}
			set
			{
				_context.ContentLength = value;
			}
		}

		public string ContentType
		{
			get
			{
				return _context.ContentType;
			}
			set
			{
				_context.ContentType = value;
			}
		}

	    public WebMessageFormat? Format
	    {
	        get { return _context.Format; }
	        set { _context.Format = value; }
	    }

        public string ETag
		{
			get
			{
				return _context.ETag;
			}
			set
			{
				_context.ETag = value;
			}
		}

		public System.Net.WebHeaderCollection Headers => _context.Headers;

	    public DateTime LastModified
		{
			get
			{
				return _context.LastModified;
			}
			set
			{
				_context.LastModified = value;
			}
		}

		public string Location
		{
			get
			{
				return _context.Location;
			}
			set
			{
				_context.Location = value;
			}
		}

		public System.Net.HttpStatusCode StatusCode
		{
			get
			{
				return _context.StatusCode;
			}
			set
			{
				_context.StatusCode = value;
			}
		}

		public string StatusDescription
		{
			get
			{
				return _context.StatusDescription;
			}
			set
			{
				_context.StatusDescription = value;
			}
		}

		public bool SuppressEntityBody
		{
			get
			{
				return _context.SuppressEntityBody;
			}
			set
			{
				_context.SuppressEntityBody = value;
			}
		}

		#endregion
	}


}
