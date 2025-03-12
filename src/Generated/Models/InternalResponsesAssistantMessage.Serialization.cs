// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalResponsesAssistantMessage : IJsonModel<InternalResponsesAssistantMessage>
    {
        internal InternalResponsesAssistantMessage()
        {
        }

        void IJsonModel<InternalResponsesAssistantMessage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesAssistantMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesAssistantMessage)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("content") != true)
            {
                writer.WritePropertyName("content"u8);
                writer.WriteStartArray();
                foreach (ResponseContentPart item in InternalContent)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        InternalResponsesAssistantMessage IJsonModel<InternalResponsesAssistantMessage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalResponsesAssistantMessage)JsonModelCreateCore(ref reader, options);

        protected override ResponseItem JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesAssistantMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesAssistantMessage)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalResponsesAssistantMessage(document.RootElement, options);
        }

        internal static InternalResponsesAssistantMessage DeserializeInternalResponsesAssistantMessage(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalResponsesItemType @type = default;
            string id = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            MessageStatus? status = default;
            MessageRole role = default;
            IList<ResponseContentPart> internalContent = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    @type = new InternalResponsesItemType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("id"u8))
                {
                    id = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("status"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = prop.Value.GetString().ToMessageStatus();
                    continue;
                }
                if (prop.NameEquals("role"u8))
                {
                    role = new MessageRole(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("content"u8))
                {
                    List<ResponseContentPart> array = new List<ResponseContentPart>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(ResponseContentPart.DeserializeResponseContentPart(item, options));
                    }
                    internalContent = array;
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalResponsesAssistantMessage(
                @type,
                id,
                additionalBinaryDataProperties,
                status,
                role,
                internalContent);
        }

        BinaryData IPersistableModel<InternalResponsesAssistantMessage>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesAssistantMessage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesAssistantMessage)} does not support writing '{options.Format}' format.");
            }
        }

        InternalResponsesAssistantMessage IPersistableModel<InternalResponsesAssistantMessage>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalResponsesAssistantMessage)PersistableModelCreateCore(data, options);

        protected override ResponseItem PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesAssistantMessage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalResponsesAssistantMessage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesAssistantMessage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalResponsesAssistantMessage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalResponsesAssistantMessage internalResponsesAssistantMessage)
        {
            if (internalResponsesAssistantMessage == null)
            {
                return null;
            }
            return BinaryContent.Create(internalResponsesAssistantMessage, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalResponsesAssistantMessage(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalResponsesAssistantMessage(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
