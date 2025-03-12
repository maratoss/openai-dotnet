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
    internal partial class InternalChatResponseFormatJsonSchema : IJsonModel<InternalChatResponseFormatJsonSchema>
    {
        internal InternalChatResponseFormatJsonSchema()
        {
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatResponseFormatJsonSchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatResponseFormatJsonSchema)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("json_schema") != true)
            {
                writer.WritePropertyName("json_schema"u8);
                writer.WriteObjectValue(JsonSchema, options);
            }
        }

        InternalChatResponseFormatJsonSchema IJsonModel<InternalChatResponseFormatJsonSchema>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalChatResponseFormatJsonSchema)JsonModelCreateCore(ref reader, options);

        protected override ChatResponseFormat JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatResponseFormatJsonSchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatResponseFormatJsonSchema)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalChatResponseFormatJsonSchema(document.RootElement, options);
        }

        internal static InternalChatResponseFormatJsonSchema DeserializeInternalChatResponseFormatJsonSchema(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string @type = "json_schema";
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            InternalResponseFormatJsonSchemaJsonSchema jsonSchema = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    @type = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("json_schema"u8))
                {
                    jsonSchema = InternalResponseFormatJsonSchemaJsonSchema.DeserializeInternalResponseFormatJsonSchemaJsonSchema(prop.Value, options);
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalChatResponseFormatJsonSchema(@type, additionalBinaryDataProperties, jsonSchema);
        }

        BinaryData IPersistableModel<InternalChatResponseFormatJsonSchema>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatResponseFormatJsonSchema>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalChatResponseFormatJsonSchema)} does not support writing '{options.Format}' format.");
            }
        }

        InternalChatResponseFormatJsonSchema IPersistableModel<InternalChatResponseFormatJsonSchema>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalChatResponseFormatJsonSchema)PersistableModelCreateCore(data, options);

        protected override ChatResponseFormat PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatResponseFormatJsonSchema>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalChatResponseFormatJsonSchema(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalChatResponseFormatJsonSchema)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalChatResponseFormatJsonSchema>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalChatResponseFormatJsonSchema internalChatResponseFormatJsonSchema)
        {
            if (internalChatResponseFormatJsonSchema == null)
            {
                return null;
            }
            return BinaryContent.Create(internalChatResponseFormatJsonSchema, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalChatResponseFormatJsonSchema(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalChatResponseFormatJsonSchema(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
