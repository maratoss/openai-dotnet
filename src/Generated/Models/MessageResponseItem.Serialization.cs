// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    public partial class MessageResponseItem : IJsonModel<MessageResponseItem>
    {
        internal MessageResponseItem()
        {
        }

        void IJsonModel<MessageResponseItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<MessageResponseItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageResponseItem)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Status) && _additionalBinaryDataProperties?.ContainsKey("status") != true)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("role") != true)
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.ToString());
            }
        }

        MessageResponseItem IJsonModel<MessageResponseItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (MessageResponseItem)JsonModelCreateCore(ref reader, options);

        protected override ResponseItem JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<MessageResponseItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageResponseItem)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMessageResponseItem(document.RootElement, options);
        }

        internal static MessageResponseItem DeserializeMessageResponseItem(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("role"u8, out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "user":
                        return InternalResponsesUserMessage.DeserializeInternalResponsesUserMessage(element, options);
                    case "system":
                        return InternalResponsesSystemMessage.DeserializeInternalResponsesSystemMessage(element, options);
                    case "developer":
                        return InternalResponsesDeveloperMessage.DeserializeInternalResponsesDeveloperMessage(element, options);
                    case "assistant":
                        return InternalResponsesAssistantMessage.DeserializeInternalResponsesAssistantMessage(element, options);
                }
            }
            return InternalUnknownResponsesMessage.DeserializeInternalUnknownResponsesMessage(element, options);
        }

        BinaryData IPersistableModel<MessageResponseItem>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<MessageResponseItem>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MessageResponseItem)} does not support writing '{options.Format}' format.");
            }
        }

        MessageResponseItem IPersistableModel<MessageResponseItem>.Create(BinaryData data, ModelReaderWriterOptions options) => (MessageResponseItem)PersistableModelCreateCore(data, options);

        protected override ResponseItem PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<MessageResponseItem>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeMessageResponseItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MessageResponseItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MessageResponseItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(MessageResponseItem messageResponseItem)
        {
            if (messageResponseItem == null)
            {
                return null;
            }
            return BinaryContent.Create(messageResponseItem, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator MessageResponseItem(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeMessageResponseItem(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
