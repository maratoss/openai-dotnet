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
    internal partial class InternalResponsesMessageAnnotationUrlCitation : IJsonModel<InternalResponsesMessageAnnotationUrlCitation>
    {
        internal InternalResponsesMessageAnnotationUrlCitation()
        {
        }

        void IJsonModel<InternalResponsesMessageAnnotationUrlCitation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesMessageAnnotationUrlCitation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesMessageAnnotationUrlCitation)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("url") != true)
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Url);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("title") != true)
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("start_index") != true)
            {
                writer.WritePropertyName("start_index"u8);
                writer.WriteNumberValue(StartIndex);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("end_index") != true)
            {
                writer.WritePropertyName("end_index"u8);
                writer.WriteNumberValue(EndIndex);
            }
        }

        InternalResponsesMessageAnnotationUrlCitation IJsonModel<InternalResponsesMessageAnnotationUrlCitation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalResponsesMessageAnnotationUrlCitation)JsonModelCreateCore(ref reader, options);

        protected override ResponseMessageAnnotation JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesMessageAnnotationUrlCitation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesMessageAnnotationUrlCitation)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalResponsesMessageAnnotationUrlCitation(document.RootElement, options);
        }

        internal static InternalResponsesMessageAnnotationUrlCitation DeserializeInternalResponsesMessageAnnotationUrlCitation(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResponseMessageAnnotationKind kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            string url = default;
            string title = default;
            int startIndex = default;
            int endIndex = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = prop.Value.GetString().ToResponseMessageAnnotationKind();
                    continue;
                }
                if (prop.NameEquals("url"u8))
                {
                    url = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("title"u8))
                {
                    title = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("start_index"u8))
                {
                    startIndex = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("end_index"u8))
                {
                    endIndex = prop.Value.GetInt32();
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalResponsesMessageAnnotationUrlCitation(
                kind,
                additionalBinaryDataProperties,
                url,
                title,
                startIndex,
                endIndex);
        }

        BinaryData IPersistableModel<InternalResponsesMessageAnnotationUrlCitation>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesMessageAnnotationUrlCitation>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesMessageAnnotationUrlCitation)} does not support writing '{options.Format}' format.");
            }
        }

        InternalResponsesMessageAnnotationUrlCitation IPersistableModel<InternalResponsesMessageAnnotationUrlCitation>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalResponsesMessageAnnotationUrlCitation)PersistableModelCreateCore(data, options);

        protected override ResponseMessageAnnotation PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesMessageAnnotationUrlCitation>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalResponsesMessageAnnotationUrlCitation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesMessageAnnotationUrlCitation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalResponsesMessageAnnotationUrlCitation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalResponsesMessageAnnotationUrlCitation internalResponsesMessageAnnotationUrlCitation)
        {
            if (internalResponsesMessageAnnotationUrlCitation == null)
            {
                return null;
            }
            return BinaryContent.Create(internalResponsesMessageAnnotationUrlCitation, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalResponsesMessageAnnotationUrlCitation(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalResponsesMessageAnnotationUrlCitation(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
