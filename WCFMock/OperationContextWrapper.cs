#region License

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

using System.Collections.Generic;
using System.ServiceModel.Channels;
using System.ServiceModel.Security;

namespace System.ServiceModel
{
	/// <summary>
	/// Provides an implementation of <see cref="IOperationContext"/> that 
	/// wraps the underlying runtime <see cref="OperationContext"/>.
	/// </summary>
	public class OperationContextWrapper : IOperationContext
	{
	    readonly OperationContext context;

		public OperationContextWrapper(OperationContext context)
		{
			this.context = context;
		}

		public event EventHandler OperationCompleted;

		T IOperationContext.GetCallbackChannel<T>()
		{
			return context.GetCallbackChannel<T>();
		}

		void IOperationContext.SetTransactionComplete()
		{
			context.SetTransactionComplete();
		}

		IContextChannel IOperationContext.Channel => context.Channel;

	    IExtensionCollection<OperationContext> IOperationContext.Extensions => context.Extensions;

	    bool IOperationContext.HasSupportingTokens => context.HasSupportingTokens;

	    ServiceHostBase IOperationContext.Host => context.Host;

	    MessageHeaders IOperationContext.IncomingMessageHeaders => context.IncomingMessageHeaders;

	    MessageProperties IOperationContext.IncomingMessageProperties => context.IncomingMessageProperties;

	    MessageVersion IOperationContext.IncomingMessageVersion => context.IncomingMessageVersion;

	    InstanceContext IOperationContext.InstanceContext => context.InstanceContext;

	    bool IOperationContext.IsUserContext => context.IsUserContext;

	    MessageHeaders IOperationContext.OutgoingMessageHeaders => context.OutgoingMessageHeaders;

	    MessageProperties IOperationContext.OutgoingMessageProperties => context.OutgoingMessageProperties;

	    RequestContext IOperationContext.RequestContext
		{
			get
			{
				return context.RequestContext;
			}
			set
			{
				context.RequestContext = value;
			}
		}

		IServiceSecurityContext IOperationContext.ServiceSecurityContext => new ServiceSecurityContextWrapper(context.ServiceSecurityContext);

	    string IOperationContext.SessionId => context.SessionId;

	    ICollection<SupportingTokenSpecification> IOperationContext.SupportingTokens => context.SupportingTokens;
	}
}
