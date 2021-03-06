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

using System.Collections.ObjectModel;
using System.IdentityModel.Policy;
using System.Security.Principal;

namespace System.ServiceModel
{
	/// <summary>
	/// Provides an implementation of <see cref="IServiceSecurityContext"/> that 
	/// wraps the underlying runtime <see cref="ServiceSecurityContext"/>.
	/// </summary>
	public class ServiceSecurityContextWrapper : IServiceSecurityContext
	{
	    readonly ServiceSecurityContext _context;

		public ServiceSecurityContextWrapper(ServiceSecurityContext context)
		{
			this._context = context;
		}

		AuthorizationContext IServiceSecurityContext.AuthorizationContext => this._context.AuthorizationContext;

	    ReadOnlyCollection<IAuthorizationPolicy> IServiceSecurityContext.AuthorizationPolicies => this._context.AuthorizationPolicies;

	    bool IServiceSecurityContext.IsAnonymous => this._context.IsAnonymous;

	    IIdentity IServiceSecurityContext.PrimaryIdentity => this._context.PrimaryIdentity;

	    WindowsIdentity IServiceSecurityContext.WindowsIdentity => this._context.WindowsIdentity;
	}
}
