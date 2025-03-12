// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Chat
{
    public partial class ChatFunction : IJsonModel<ChatFunction>
    {
        internal ChatFunction()
        {
        }

        void IJsonModel<ChatFunction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatFunction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatFunction)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("name") != true)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(FunctionName);
            }
            if (Optional.IsDefined(FunctionDescription) && _additionalBinaryDataProperties?.ContainsKey("description") != true)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(FunctionDescription);
            }
            if (Optional.IsDefined(FunctionParameters) && _additionalBinaryDataProperties?.ContainsKey("parameters") != true)
            {
                writer.WritePropertyName("parameters"u8);
#if NET6_0_OR_GREATER
                writer.WriteRawValue(FunctionParameters);
#else
                using (JsonDocument document = JsonDocument.Parse(FunctionParameters))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        ChatFunction IJsonModel<ChatFunction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual ChatFunction JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatFunction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatFunction)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatFunction(document.RootElement, options);
        }

        internal static ChatFunction DeserializeChatFunction(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string functionName = default;
            string functionDescription = default;
            BinaryData functionParameters = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("name"u8))
                {
                    functionName = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("description"u8))
                {
                    functionDescription = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("parameters"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    functionParameters = BinaryData.FromString(prop.Value.GetRawText());
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new ChatFunction(functionName, functionDescription, functionParameters, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ChatFunction>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatFunction>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatFunction)} does not support writing '{options.Format}' format.");
            }
        }

        ChatFunction IPersistableModel<ChatFunction>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual ChatFunction PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatFunction>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeChatFunction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatFunction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatFunction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(ChatFunction chatFunction)
        {
            if (chatFunction == null)
            {
                return null;
            }
            return BinaryContent.Create(chatFunction, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator ChatFunction(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeChatFunction(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
