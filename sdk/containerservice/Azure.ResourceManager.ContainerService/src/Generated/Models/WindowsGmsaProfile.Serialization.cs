// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class WindowsGmsaProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(DnsServer))
            {
                writer.WritePropertyName("dnsServer"u8);
                writer.WriteStringValue(DnsServer);
            }
            if (Optional.IsDefined(RootDomainName))
            {
                writer.WritePropertyName("rootDomainName"u8);
                writer.WriteStringValue(RootDomainName);
            }
            writer.WriteEndObject();
        }

        internal static WindowsGmsaProfile DeserializeWindowsGmsaProfile(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<string> dnsServer = default;
            Optional<string> rootDomainName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dnsServer"u8))
                {
                    dnsServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rootDomainName"u8))
                {
                    rootDomainName = property.Value.GetString();
                    continue;
                }
            }
            return new WindowsGmsaProfile(Optional.ToNullable(enabled), dnsServer.Value, rootDomainName.Value);
        }
    }
}
