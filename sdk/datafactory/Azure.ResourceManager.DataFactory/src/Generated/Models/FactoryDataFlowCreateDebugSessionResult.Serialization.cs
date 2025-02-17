// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class FactoryDataFlowCreateDebugSessionResult
    {
        internal static FactoryDataFlowCreateDebugSessionResult DeserializeFactoryDataFlowCreateDebugSessionResult(JsonElement element)
        {
            Optional<string> status = default;
            Optional<Guid> sessionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sessionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sessionId = property.Value.GetGuid();
                    continue;
                }
            }
            return new FactoryDataFlowCreateDebugSessionResult(status.Value, Optional.ToNullable(sessionId));
        }
    }
}
