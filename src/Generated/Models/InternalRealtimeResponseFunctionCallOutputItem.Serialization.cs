// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeResponseFunctionCallOutputItem : IJsonModel<InternalRealtimeResponseFunctionCallOutputItem>
    {
        internal InternalRealtimeResponseFunctionCallOutputItem()
        {
        }

        void IJsonModel<InternalRealtimeResponseFunctionCallOutputItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseFunctionCallOutputItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeResponseFunctionCallOutputItem)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("call_id") != true)
            {
                writer.WritePropertyName("call_id"u8);
                writer.WriteStringValue(CallId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("output") != true)
            {
                writer.WritePropertyName("output"u8);
                writer.WriteStringValue(Output);
            }
        }

        InternalRealtimeResponseFunctionCallOutputItem IJsonModel<InternalRealtimeResponseFunctionCallOutputItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalRealtimeResponseFunctionCallOutputItem)JsonModelCreateCore(ref reader, options);

        protected override InternalRealtimeConversationResponseItem JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseFunctionCallOutputItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeResponseFunctionCallOutputItem)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeResponseFunctionCallOutputItem(document.RootElement, options);
        }

        internal static InternalRealtimeResponseFunctionCallOutputItem DeserializeInternalRealtimeResponseFunctionCallOutputItem(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalRealtimeConversationResponseItemObject @object = default;
            InternalRealtimeItemType @type = default;
            string id = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            string callId = default;
            string output = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("object"u8))
                {
                    @object = new InternalRealtimeConversationResponseItemObject(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("type"u8))
                {
                    @type = new InternalRealtimeItemType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("id"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        id = null;
                        continue;
                    }
                    id = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("call_id"u8))
                {
                    callId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("output"u8))
                {
                    output = prop.Value.GetString();
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalRealtimeResponseFunctionCallOutputItem(
                @object,
                @type,
                id,
                additionalBinaryDataProperties,
                callId,
                output);
        }

        BinaryData IPersistableModel<InternalRealtimeResponseFunctionCallOutputItem>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseFunctionCallOutputItem>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeResponseFunctionCallOutputItem)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeResponseFunctionCallOutputItem IPersistableModel<InternalRealtimeResponseFunctionCallOutputItem>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalRealtimeResponseFunctionCallOutputItem)PersistableModelCreateCore(data, options);

        protected override InternalRealtimeConversationResponseItem PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseFunctionCallOutputItem>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRealtimeResponseFunctionCallOutputItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeResponseFunctionCallOutputItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeResponseFunctionCallOutputItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalRealtimeResponseFunctionCallOutputItem internalRealtimeResponseFunctionCallOutputItem)
        {
            if (internalRealtimeResponseFunctionCallOutputItem == null)
            {
                return null;
            }
            return BinaryContent.Create(internalRealtimeResponseFunctionCallOutputItem, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalRealtimeResponseFunctionCallOutputItem(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRealtimeResponseFunctionCallOutputItem(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
