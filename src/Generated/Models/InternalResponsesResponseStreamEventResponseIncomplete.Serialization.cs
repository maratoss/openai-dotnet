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
    internal partial class InternalResponsesResponseStreamEventResponseIncomplete : IJsonModel<InternalResponsesResponseStreamEventResponseIncomplete>
    {
        internal InternalResponsesResponseStreamEventResponseIncomplete()
        {
        }

        void IJsonModel<InternalResponsesResponseStreamEventResponseIncomplete>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesResponseStreamEventResponseIncomplete>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesResponseStreamEventResponseIncomplete)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("response") != true)
            {
                writer.WritePropertyName("response"u8);
                writer.WriteObjectValue(Response, options);
            }
        }

        InternalResponsesResponseStreamEventResponseIncomplete IJsonModel<InternalResponsesResponseStreamEventResponseIncomplete>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalResponsesResponseStreamEventResponseIncomplete)JsonModelCreateCore(ref reader, options);

        protected override StreamingResponseUpdate JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesResponseStreamEventResponseIncomplete>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesResponseStreamEventResponseIncomplete)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalResponsesResponseStreamEventResponseIncomplete(document.RootElement, options);
        }

        internal static InternalResponsesResponseStreamEventResponseIncomplete DeserializeInternalResponsesResponseStreamEventResponseIncomplete(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StreamingResponseUpdateKind kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            OpenAIResponse response = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new StreamingResponseUpdateKind(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("response"u8))
                {
                    response = OpenAIResponse.DeserializeOpenAIResponse(prop.Value, options);
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalResponsesResponseStreamEventResponseIncomplete(kind, additionalBinaryDataProperties, response);
        }

        BinaryData IPersistableModel<InternalResponsesResponseStreamEventResponseIncomplete>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesResponseStreamEventResponseIncomplete>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesResponseStreamEventResponseIncomplete)} does not support writing '{options.Format}' format.");
            }
        }

        InternalResponsesResponseStreamEventResponseIncomplete IPersistableModel<InternalResponsesResponseStreamEventResponseIncomplete>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalResponsesResponseStreamEventResponseIncomplete)PersistableModelCreateCore(data, options);

        protected override StreamingResponseUpdate PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesResponseStreamEventResponseIncomplete>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalResponsesResponseStreamEventResponseIncomplete(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesResponseStreamEventResponseIncomplete)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalResponsesResponseStreamEventResponseIncomplete>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalResponsesResponseStreamEventResponseIncomplete internalResponsesResponseStreamEventResponseIncomplete)
        {
            if (internalResponsesResponseStreamEventResponseIncomplete == null)
            {
                return null;
            }
            return BinaryContent.Create(internalResponsesResponseStreamEventResponseIncomplete, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalResponsesResponseStreamEventResponseIncomplete(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalResponsesResponseStreamEventResponseIncomplete(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
