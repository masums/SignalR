// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Linq;

namespace Microsoft.AspNetCore.SignalR.Internal.Protocol
{
    public class InvocationMessage : HubMessage
    {
        // Use ExceptionDispatchInfo ?
        private readonly Exception _bindingError;
        private readonly object[] _arguments;

        public string Target { get; }

        public object[] Arguments
        {
            get
            {
                if (_bindingError != null)
                {
                    throw _bindingError;
                }

                return _arguments;
            }
        }

        public bool NonBlocking { get; }

        public InvocationMessage(string invocationId, bool nonBlocking, string target, Exception bindingError, params object[] arguments)
            : base(invocationId)
        {
            if (string.IsNullOrEmpty(invocationId))
            {
                throw new ArgumentNullException(nameof(invocationId));
            }

            if (string.IsNullOrEmpty(target))
            {
                throw new ArgumentNullException(nameof(target));
            }

            if ((arguments == null && bindingError == null) || (arguments?.Length > 0 && bindingError != null))
            {
                // TODO: fix the exception
                throw new ArgumentNullException(nameof(arguments));
            }

            Target = target;
            _arguments = arguments;
            _bindingError = bindingError;
            NonBlocking = nonBlocking;
        }

        public override string ToString()
        {
            return $"Invocation {{ {nameof(InvocationId)}: \"{InvocationId}\", {nameof(NonBlocking)}: {NonBlocking}, {nameof(Target)}: \"{Target}\", {nameof(Arguments)}: [ {string.Join(", ", Arguments.Select(a => a?.ToString()))} ] }}";
        }
    }
}
