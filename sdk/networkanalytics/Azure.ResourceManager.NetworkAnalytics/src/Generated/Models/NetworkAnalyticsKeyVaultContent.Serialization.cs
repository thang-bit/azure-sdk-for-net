// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    public partial class NetworkAnalyticsKeyVaultContent : IUtf8JsonSerializable, IJsonModel<NetworkAnalyticsKeyVaultContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkAnalyticsKeyVaultContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkAnalyticsKeyVaultContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkAnalyticsKeyVaultContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkAnalyticsKeyVaultContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("keyVaultUrl"u8);
            writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        NetworkAnalyticsKeyVaultContent IJsonModel<NetworkAnalyticsKeyVaultContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkAnalyticsKeyVaultContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkAnalyticsKeyVaultContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkAnalyticsKeyVaultContent(document.RootElement, options);
        }

        internal static NetworkAnalyticsKeyVaultContent DeserializeNetworkAnalyticsKeyVaultContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri keyVaultUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultUrl"u8))
                {
                    keyVaultUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkAnalyticsKeyVaultContent(keyVaultUrl, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkAnalyticsKeyVaultContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkAnalyticsKeyVaultContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkAnalyticsKeyVaultContent)} does not support '{options.Format}' format.");
            }
        }

        NetworkAnalyticsKeyVaultContent IPersistableModel<NetworkAnalyticsKeyVaultContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkAnalyticsKeyVaultContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkAnalyticsKeyVaultContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkAnalyticsKeyVaultContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkAnalyticsKeyVaultContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
