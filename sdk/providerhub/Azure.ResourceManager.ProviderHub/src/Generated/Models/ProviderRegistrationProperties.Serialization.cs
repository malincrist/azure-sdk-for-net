// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ProviderRegistrationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProviderHubMetadata))
            {
                writer.WritePropertyName("providerHubMetadata"u8);
                writer.WriteObjectValue(ProviderHubMetadata);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(SubscriptionLifecycleNotificationSpecifications))
            {
                writer.WritePropertyName("subscriptionLifecycleNotificationSpecifications"u8);
                writer.WriteObjectValue(SubscriptionLifecycleNotificationSpecifications);
            }
            if (Optional.IsDefined(ProviderAuthentication))
            {
                writer.WritePropertyName("providerAuthentication"u8);
                writer.WriteObjectValue(ProviderAuthentication);
            }
            if (Optional.IsCollectionDefined(ProviderAuthorizations))
            {
                writer.WritePropertyName("providerAuthorizations"u8);
                writer.WriteStartArray();
                foreach (var item in ProviderAuthorizations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsDefined(ProviderVersion))
            {
                writer.WritePropertyName("providerVersion"u8);
                writer.WriteStringValue(ProviderVersion);
            }
            if (Optional.IsDefined(ProviderType))
            {
                writer.WritePropertyName("providerType"u8);
                writer.WriteStringValue(ProviderType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(RequiredFeatures))
            {
                writer.WritePropertyName("requiredFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredFeatures)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FeaturesRule))
            {
                writer.WritePropertyName("featuresRule"u8);
                writer.WriteObjectValue(FeaturesRule);
            }
            if (Optional.IsDefined(RequestHeaderOptions))
            {
                writer.WritePropertyName("requestHeaderOptions"u8);
                writer.WriteObjectValue(RequestHeaderOptions);
            }
            if (Optional.IsDefined(Management))
            {
                writer.WritePropertyName("management"u8);
                writer.WriteObjectValue(Management);
            }
            if (Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Metadata.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(TemplateDeploymentOptions))
            {
                writer.WritePropertyName("templateDeploymentOptions"u8);
                writer.WriteObjectValue(TemplateDeploymentOptions);
            }
            writer.WriteEndObject();
        }

        internal static ProviderRegistrationProperties DeserializeProviderRegistrationProperties(JsonElement element)
        {
            Optional<ProviderRegistrationPropertiesProviderHubMetadata> providerHubMetadata = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<ProviderRegistrationPropertiesSubscriptionLifecycleNotificationSpecifications> subscriptionLifecycleNotificationSpecifications = default;
            Optional<ResourceProviderManifestPropertiesProviderAuthentication> providerAuthentication = default;
            Optional<IList<ResourceProviderAuthorization>> providerAuthorizations = default;
            Optional<string> @namespace = default;
            Optional<string> providerVersion = default;
            Optional<ResourceProviderType> providerType = default;
            Optional<IList<string>> requiredFeatures = default;
            Optional<ResourceProviderManifestPropertiesFeaturesRule> featuresRule = default;
            Optional<ResourceProviderManifestPropertiesRequestHeaderOptions> requestHeaderOptions = default;
            Optional<ResourceProviderManifestPropertiesManagement> management = default;
            Optional<IList<ResourceProviderCapabilities>> capabilities = default;
            Optional<BinaryData> metadata = default;
            Optional<ResourceProviderManifestPropertiesTemplateDeploymentOptions> templateDeploymentOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerHubMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    providerHubMetadata = ProviderRegistrationPropertiesProviderHubMetadata.DeserializeProviderRegistrationPropertiesProviderHubMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionLifecycleNotificationSpecifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subscriptionLifecycleNotificationSpecifications = ProviderRegistrationPropertiesSubscriptionLifecycleNotificationSpecifications.DeserializeProviderRegistrationPropertiesSubscriptionLifecycleNotificationSpecifications(property.Value);
                    continue;
                }
                if (property.NameEquals("providerAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    providerAuthentication = ResourceProviderManifestPropertiesProviderAuthentication.DeserializeResourceProviderManifestPropertiesProviderAuthentication(property.Value);
                    continue;
                }
                if (property.NameEquals("providerAuthorizations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceProviderAuthorization> array = new List<ResourceProviderAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderAuthorization.DeserializeResourceProviderAuthorization(item));
                    }
                    providerAuthorizations = array;
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerVersion"u8))
                {
                    providerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    providerType = new ResourceProviderType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requiredFeatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    requiredFeatures = array;
                    continue;
                }
                if (property.NameEquals("featuresRule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    featuresRule = ResourceProviderManifestPropertiesFeaturesRule.DeserializeResourceProviderManifestPropertiesFeaturesRule(property.Value);
                    continue;
                }
                if (property.NameEquals("requestHeaderOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestHeaderOptions = ResourceProviderManifestPropertiesRequestHeaderOptions.DeserializeResourceProviderManifestPropertiesRequestHeaderOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("management"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    management = ResourceProviderManifestPropertiesManagement.DeserializeResourceProviderManifestPropertiesManagement(property.Value);
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceProviderCapabilities> array = new List<ResourceProviderCapabilities>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderCapabilities.DeserializeResourceProviderCapabilities(item));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("templateDeploymentOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    templateDeploymentOptions = ResourceProviderManifestPropertiesTemplateDeploymentOptions.DeserializeResourceProviderManifestPropertiesTemplateDeploymentOptions(property.Value);
                    continue;
                }
            }
            return new ProviderRegistrationProperties(providerAuthentication.Value, Optional.ToList(providerAuthorizations), @namespace.Value, providerVersion.Value, Optional.ToNullable(providerType), Optional.ToList(requiredFeatures), featuresRule.Value, requestHeaderOptions.Value, management.Value, Optional.ToList(capabilities), metadata.Value, templateDeploymentOptions.Value, providerHubMetadata.Value, Optional.ToNullable(provisioningState), subscriptionLifecycleNotificationSpecifications.Value);
        }
    }
}
