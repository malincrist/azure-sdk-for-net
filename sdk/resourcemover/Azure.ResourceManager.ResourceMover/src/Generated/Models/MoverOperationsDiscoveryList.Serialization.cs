// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    internal partial class MoverOperationsDiscoveryList
    {
        internal static MoverOperationsDiscoveryList DeserializeMoverOperationsDiscoveryList(JsonElement element)
        {
            Optional<IReadOnlyList<MoverOperationsDiscovery>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MoverOperationsDiscovery> array = new List<MoverOperationsDiscovery>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MoverOperationsDiscovery.DeserializeMoverOperationsDiscovery(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new MoverOperationsDiscoveryList(Optional.ToList(value), nextLink.Value);
        }
    }
}
