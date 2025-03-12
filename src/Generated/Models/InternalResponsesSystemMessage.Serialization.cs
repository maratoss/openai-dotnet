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
    internal partial class InternalResponsesSystemMessage : IJsonModel<InternalResponsesSystemMessage>
    {
        internal InternalResponsesSystemMessage()
        {
        }

        void IJsonModel<InternalResponsesSystemMessage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesSystemMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesSystemMessage)} does not support writing '{format}' format.");
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

        InternalResponsesSystemMessage IJsonModel<InternalResponsesSystemMessage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalResponsesSystemMessage)JsonModelCreateCore(ref reader, options);

        protected override ResponseItem JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesSystemMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesSystemMessage)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalResponsesSystemMessage(document.RootElement, options);
        }

        internal static InternalResponsesSystemMessage DeserializeInternalResponsesSystemMessage(JsonElement element, ModelReaderWriterOptions options)
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
            return new InternalResponsesSystemMessage(
                @type,
                id,
                additionalBinaryDataProperties,
                status,
                role,
                internalContent);
        }

        BinaryData IPersistableModel<InternalResponsesSystemMessage>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesSystemMessage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesSystemMessage)} does not support writing '{options.Format}' format.");
            }
        }

        InternalResponsesSystemMessage IPersistableModel<InternalResponsesSystemMessage>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalResponsesSystemMessage)PersistableModelCreateCore(data, options);

        protected override ResponseItem PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesSystemMessage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalResponsesSystemMessage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesSystemMessage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalResponsesSystemMessage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalResponsesSystemMessage internalResponsesSystemMessage)
        {
            if (internalResponsesSystemMessage == null)
            {
                return null;
            }
            return BinaryContent.Create(internalResponsesSystemMessage, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalResponsesSystemMessage(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalResponsesSystemMessage(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
