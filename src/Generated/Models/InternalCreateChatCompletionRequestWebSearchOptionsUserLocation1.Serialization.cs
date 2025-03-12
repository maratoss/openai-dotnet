// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;
using OpenAI.Internal;

namespace OpenAI.Chat
{
    internal partial class InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1 : IJsonModel<InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1>
    {
        internal InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1()
        {
        }

        void IJsonModel<InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.ToString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("approximate") != true)
            {
                writer.WritePropertyName("approximate"u8);
                writer.WriteObjectValue(Approximate, options);
            }
            if (_additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
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
        }

        InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1 IJsonModel<InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1 JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalCreateChatCompletionRequestWebSearchOptionsUserLocation1(document.RootElement, options);
        }

        internal static InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1 DeserializeInternalCreateChatCompletionRequestWebSearchOptionsUserLocation1(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1Type @type = default;
            InternalWebSearchLocation approximate = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    @type = new InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1Type(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("approximate"u8))
                {
                    approximate = InternalWebSearchLocation.DeserializeInternalWebSearchLocation(prop.Value, options);
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1(@type, approximate, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1)} does not support writing '{options.Format}' format.");
            }
        }

        InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1 IPersistableModel<InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1 PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalCreateChatCompletionRequestWebSearchOptionsUserLocation1(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1 internalCreateChatCompletionRequestWebSearchOptionsUserLocation1)
        {
            if (internalCreateChatCompletionRequestWebSearchOptionsUserLocation1 == null)
            {
                return null;
            }
            return BinaryContent.Create(internalCreateChatCompletionRequestWebSearchOptionsUserLocation1, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalCreateChatCompletionRequestWebSearchOptionsUserLocation1(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
