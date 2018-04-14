﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Microsoft.AspNetCore.Connections;

namespace Microsoft.Azure.SignalR
{
    public interface IServiceConnectionManager
    {
        void AddServiceConnection(ServiceConnection serviceConnection);

        Task StartAllServiceConnection(ConnectionDelegate connectionDelegate);

        Task SendServiceMessage(ServiceMessage seviceMessage);
    }
}