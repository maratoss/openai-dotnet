// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    [PersistableModelProxy(typeof(UnknownResponsesReasoningItemSummaryElement))]
    internal abstract partial class InternalResponsesReasoningItemSummaryElement : IJsonModel<InternalResponsesReasoningItemSummaryElement>
    {
        internal InternalResponsesReasoningItemSummaryElement()
        {
        }

        void IJsonModel<InternalResponsesReasoningItemSummaryElement>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesReasoningItemSummaryElement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesReasoningItemSummaryElement)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.ToString());
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

        InternalResponsesReasoningItemSummaryElement IJsonModel<InternalResponsesReasoningItemSummaryElement>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalResponsesReasoningItemSummaryElement JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesReasoningItemSummaryElement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesReasoningItemSummaryElement)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalResponsesReasoningItemSummaryElement(document.RootElement, options);
        }

        internal static InternalResponsesReasoningItemSummaryElement DeserializeInternalResponsesReasoningItemSummaryElement(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type"u8, out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "summary_text":
                        return InternalResponsesReasoningItemSummaryElementSummaryText.DeserializeInternalResponsesReasoningItemSummaryElementSummaryText(element, options);
                }
            }
            return UnknownResponsesReasoningItemSummaryElement.DeserializeUnknownResponsesReasoningItemSummaryElement(element, options);
        }

        BinaryData IPersistableModel<InternalResponsesReasoningItemSummaryElement>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesReasoningItemSummaryElement>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesReasoningItemSummaryElement)} does not support writing '{options.Format}' format.");
            }
        }

        InternalResponsesReasoningItemSummaryElement IPersistableModel<InternalResponsesReasoningItemSummaryElement>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalResponsesReasoningItemSummaryElement PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesReasoningItemSummaryElement>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalResponsesReasoningItemSummaryElement(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesReasoningItemSummaryElement)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalResponsesReasoningItemSummaryElement>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalResponsesReasoningItemSummaryElement internalResponsesReasoningItemSummaryElement)
        {
            if (internalResponsesReasoningItemSummaryElement == null)
            {
                return null;
            }
            return BinaryContent.Create(internalResponsesReasoningItemSummaryElement, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalResponsesReasoningItemSummaryElement(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalResponsesReasoningItemSummaryElement(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
