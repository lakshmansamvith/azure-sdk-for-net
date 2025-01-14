// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class WebTestPropertiesValidationRulesContentValidation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ContentMatch))
            {
                writer.WritePropertyName("ContentMatch"u8);
                writer.WriteStringValue(ContentMatch);
            }
            if (Optional.IsDefined(IgnoreCase))
            {
                writer.WritePropertyName("IgnoreCase"u8);
                writer.WriteBooleanValue(IgnoreCase.Value);
            }
            if (Optional.IsDefined(PassIfTextFound))
            {
                writer.WritePropertyName("PassIfTextFound"u8);
                writer.WriteBooleanValue(PassIfTextFound.Value);
            }
            writer.WriteEndObject();
        }

        internal static WebTestPropertiesValidationRulesContentValidation DeserializeWebTestPropertiesValidationRulesContentValidation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> contentMatch = default;
            Optional<bool> ignoreCase = default;
            Optional<bool> passIfTextFound = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ContentMatch"u8))
                {
                    contentMatch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("IgnoreCase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreCase = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("PassIfTextFound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    passIfTextFound = property.Value.GetBoolean();
                    continue;
                }
            }
            return new WebTestPropertiesValidationRulesContentValidation(contentMatch.Value, Optional.ToNullable(ignoreCase), Optional.ToNullable(passIfTextFound));
        }
    }
}
