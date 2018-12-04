// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using System;
using System.Threading.Channels;

namespace Microsoft.AspNetCore.SignalR
{
    internal static class ReflectionHelper
    {
        public static bool IsStreamingType(Type type)
        {
            // TODO #2594 - add Streams here, to make sending files easy
            return type != null && type.IsGenericType && type.GetGenericTypeDefinition() == typeof(ChannelReader<>);
        }
    }
}
