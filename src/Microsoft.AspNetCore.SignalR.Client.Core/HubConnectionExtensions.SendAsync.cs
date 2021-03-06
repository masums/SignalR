﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Client
{
    public static partial class HubConnectionExtensions
    {
        public static Task SendAsync(this HubConnection hubConnection, string methodName, CancellationToken cancellationToken = default)
        {
            return hubConnection.SendAsync(methodName, Array.Empty<object>(), cancellationToken);
        }

        public static Task SendAsync(this HubConnection hubConnection, string methodName, object arg1, CancellationToken cancellationToken = default)
        {
            return hubConnection.SendAsync(methodName, new object[] { arg1 }, cancellationToken);
        }

        public static Task SendAsync(this HubConnection hubConnection, string methodName, object arg1, object arg2, CancellationToken cancellationToken = default)
        {
            return hubConnection.SendAsync(methodName, new object[] { arg1, arg2 }, cancellationToken);
        }

        public static Task SendAsync(this HubConnection hubConnection, string methodName, object arg1, object arg2, object arg3, CancellationToken cancellationToken = default)
        {
            return hubConnection.SendAsync(methodName, new object[] { arg1, arg2, arg3 }, cancellationToken);
        }

        public static Task SendAsync(this HubConnection hubConnection, string methodName, object arg1, object arg2, object arg3, object arg4, CancellationToken cancellationToken = default)
        {
            return hubConnection.SendAsync(methodName, new object[] { arg1, arg2, arg3, arg4 }, cancellationToken);
        }

        public static Task SendAsync(this HubConnection hubConnection, string methodName, object arg1, object arg2, object arg3, object arg4, object arg5, CancellationToken cancellationToken = default)
        {
            return hubConnection.SendAsync(methodName, new object[] { arg1, arg2, arg3, arg4, arg5 }, cancellationToken);
        }

        public static Task SendAsync(this HubConnection hubConnection, string methodName, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, CancellationToken cancellationToken = default)
        {
            return hubConnection.SendAsync(methodName, new object[] { arg1, arg2, arg3, arg4, arg5, arg6 }, cancellationToken);
        }

        public static Task SendAsync(this HubConnection hubConnection, string methodName, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7,  CancellationToken cancellationToken = default)
        {
            return hubConnection.SendAsync(methodName, new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7 }, cancellationToken);
        }

        public static Task SendAsync(this HubConnection hubConnection, string methodName, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, CancellationToken cancellationToken = default)
        {
            return hubConnection.SendAsync(methodName, new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8 }, cancellationToken);
        }

        public static Task SendAsync(this HubConnection hubConnection, string methodName, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, CancellationToken cancellationToken = default)
        {
            return hubConnection.SendAsync(methodName, new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9 }, cancellationToken);
        }

        public static Task SendAsync(this HubConnection hubConnection, string methodName, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, CancellationToken cancellationToken = default)
        {
            return hubConnection.SendAsync(methodName, new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10 }, cancellationToken);
        }
    }
}
