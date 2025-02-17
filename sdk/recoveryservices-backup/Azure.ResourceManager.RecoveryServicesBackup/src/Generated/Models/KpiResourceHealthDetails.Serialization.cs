// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class KpiResourceHealthDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceHealthStatus))
            {
                writer.WritePropertyName("resourceHealthStatus"u8);
                writer.WriteStringValue(ResourceHealthStatus.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ResourceHealthDetails))
            {
                writer.WritePropertyName("resourceHealthDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceHealthDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static KpiResourceHealthDetails DeserializeKpiResourceHealthDetails(JsonElement element)
        {
            Optional<ResourceHealthStatus> resourceHealthStatus = default;
            Optional<IList<ResourceHealthDetails>> resourceHealthDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceHealthStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceHealthStatus = new ResourceHealthStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceHealthDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceHealthDetails> array = new List<ResourceHealthDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.ResourceHealthDetails.DeserializeResourceHealthDetails(item));
                    }
                    resourceHealthDetails = array;
                    continue;
                }
            }
            return new KpiResourceHealthDetails(Optional.ToNullable(resourceHealthStatus), Optional.ToList(resourceHealthDetails));
        }
    }
}
