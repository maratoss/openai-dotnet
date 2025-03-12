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
    internal partial class InternalResponsesTextFormatJsonObject : IJsonModel<InternalResponsesTextFormatJsonObject>
    {
        void IJsonModel<InternalResponsesTextFormatJsonObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesTextFormatJsonObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesTextFormatJsonObject)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
        }

        InternalResponsesTextFormatJsonObject IJsonModel<InternalResponsesTextFormatJsonObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalResponsesTextFormatJsonObject)JsonModelCreateCore(ref reader, options);

        protected override ResponseTextFormat JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesTextFormatJsonObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesTextFormatJsonObject)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalResponsesTextFormatJsonObject(document.RootElement, options);
        }

        internal static InternalResponsesTextFormatJsonObject DeserializeInternalResponsesTextFormatJsonObject(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalResponsesTextFormatType @type = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    @type = new InternalResponsesTextFormatType(prop.Value.GetString());
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalResponsesTextFormatJsonObject(@type, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalResponsesTextFormatJsonObject>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesTextFormatJsonObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesTextFormatJsonObject)} does not support writing '{options.Format}' format.");
            }
        }

        InternalResponsesTextFormatJsonObject IPersistableModel<InternalResponsesTextFormatJsonObject>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalResponsesTextFormatJsonObject)PersistableModelCreateCore(data, options);

        protected override ResponseTextFormat PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesTextFormatJsonObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalResponsesTextFormatJsonObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesTextFormatJsonObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalResponsesTextFormatJsonObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalResponsesTextFormatJsonObject internalResponsesTextFormatJsonObject)
        {
            if (internalResponsesTextFormatJsonObject == null)
            {
                return null;
            }
            return BinaryContent.Create(internalResponsesTextFormatJsonObject, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalResponsesTextFormatJsonObject(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalResponsesTextFormatJsonObject(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
