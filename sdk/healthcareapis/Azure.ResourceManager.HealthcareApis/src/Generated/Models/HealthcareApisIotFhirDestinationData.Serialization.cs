// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthcareApis
{
    public partial class HealthcareApisIotFhirDestinationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("resourceIdentityResolutionType"u8);
            writer.WriteStringValue(ResourceIdentityResolutionType.ToString());
            writer.WritePropertyName("fhirServiceResourceId"u8);
            writer.WriteStringValue(FhirServiceResourceId);
            writer.WritePropertyName("fhirMapping"u8);
            writer.WriteObjectValue(FhirMapping);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static HealthcareApisIotFhirDestinationData DeserializeHealthcareApisIotFhirDestinationData(JsonElement element)
        {
            Optional<AzureLocation> location = default;
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<HealthcareApisProvisioningState> provisioningState = default;
            HealthcareApisIotIdentityResolutionType resourceIdentityResolutionType = default;
            ResourceIdentifier fhirServiceResourceId = default;
            HealthcareApisIotMappingProperties fhirMapping = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new HealthcareApisProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceIdentityResolutionType"u8))
                        {
                            resourceIdentityResolutionType = new HealthcareApisIotIdentityResolutionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("fhirServiceResourceId"u8))
                        {
                            fhirServiceResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("fhirMapping"u8))
                        {
                            fhirMapping = HealthcareApisIotMappingProperties.DeserializeHealthcareApisIotMappingProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HealthcareApisIotFhirDestinationData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), resourceIdentityResolutionType, fhirServiceResourceId, fhirMapping, Optional.ToNullable(location), Optional.ToNullable(etag));
        }
    }
}
