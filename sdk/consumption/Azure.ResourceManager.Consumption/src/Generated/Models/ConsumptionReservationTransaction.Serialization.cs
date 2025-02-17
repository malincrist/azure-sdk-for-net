// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionReservationTransaction
    {
        internal static ConsumptionReservationTransaction DeserializeConsumptionReservationTransaction(JsonElement element)
        {
            Optional<IReadOnlyList<string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> eventDate = default;
            Optional<string> reservationOrderId = default;
            Optional<string> description = default;
            Optional<string> eventType = default;
            Optional<decimal> quantity = default;
            Optional<decimal> amount = default;
            Optional<string> currency = default;
            Optional<string> reservationOrderName = default;
            Optional<string> purchasingEnrollment = default;
            Optional<Guid> purchasingSubscriptionGuid = default;
            Optional<string> purchasingSubscriptionName = default;
            Optional<string> armSkuName = default;
            Optional<string> term = default;
            Optional<string> region = default;
            Optional<string> accountName = default;
            Optional<string> accountOwnerEmail = default;
            Optional<string> departmentName = default;
            Optional<string> costCenter = default;
            Optional<string> currentEnrollment = default;
            Optional<string> billingFrequency = default;
            Optional<int> billingMonth = default;
            Optional<decimal> monetaryCommitment = default;
            Optional<decimal> overage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
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
                    tags = array;
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
                        if (property0.NameEquals("eventDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            eventDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("reservationOrderId"u8))
                        {
                            reservationOrderId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("eventType"u8))
                        {
                            eventType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("quantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            quantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("amount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            amount = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("currency"u8))
                        {
                            currency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservationOrderName"u8))
                        {
                            reservationOrderName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("purchasingEnrollment"u8))
                        {
                            purchasingEnrollment = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("purchasingSubscriptionGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            purchasingSubscriptionGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("purchasingSubscriptionName"u8))
                        {
                            purchasingSubscriptionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("armSkuName"u8))
                        {
                            armSkuName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("term"u8))
                        {
                            term = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("region"u8))
                        {
                            region = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountName"u8))
                        {
                            accountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountOwnerEmail"u8))
                        {
                            accountOwnerEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("departmentName"u8))
                        {
                            departmentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("costCenter"u8))
                        {
                            costCenter = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentEnrollment"u8))
                        {
                            currentEnrollment = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingFrequency"u8))
                        {
                            billingFrequency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingMonth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            billingMonth = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("monetaryCommitment"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            monetaryCommitment = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("overage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            overage = property0.Value.GetDecimal();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConsumptionReservationTransaction(id, name, type, systemData.Value, Optional.ToNullable(eventDate), reservationOrderId.Value, description.Value, eventType.Value, Optional.ToNullable(quantity), Optional.ToNullable(amount), currency.Value, reservationOrderName.Value, purchasingEnrollment.Value, Optional.ToNullable(purchasingSubscriptionGuid), purchasingSubscriptionName.Value, armSkuName.Value, term.Value, region.Value, accountName.Value, accountOwnerEmail.Value, departmentName.Value, costCenter.Value, currentEnrollment.Value, billingFrequency.Value, Optional.ToNullable(billingMonth), Optional.ToNullable(monetaryCommitment), Optional.ToNullable(overage), Optional.ToList(tags));
        }
    }
}
