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
    public partial class FunctionCallOutputResponseItem : IJsonModel<FunctionCallOutputResponseItem>
    {
        internal FunctionCallOutputResponseItem()
        {
        }

        void IJsonModel<FunctionCallOutputResponseItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FunctionCallOutputResponseItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionCallOutputResponseItem)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Status) && _additionalBinaryDataProperties?.ContainsKey("status") != true)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("call_id") != true)
            {
                writer.WritePropertyName("call_id"u8);
                writer.WriteStringValue(CallId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("output") != true)
            {
                writer.WritePropertyName("output"u8);
                writer.WriteStringValue(FunctionOutput);
            }
        }

        FunctionCallOutputResponseItem IJsonModel<FunctionCallOutputResponseItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (FunctionCallOutputResponseItem)JsonModelCreateCore(ref reader, options);

        protected override ResponseItem JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FunctionCallOutputResponseItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionCallOutputResponseItem)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFunctionCallOutputResponseItem(document.RootElement, options);
        }

        internal static FunctionCallOutputResponseItem DeserializeFunctionCallOutputResponseItem(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalResponsesItemType @type = default;
            string id = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            FunctionCallOutputStatus? status = default;
            string callId = default;
            string functionOutput = default;
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
                    status = prop.Value.GetString().ToFunctionCallOutputStatus();
                    continue;
                }
                if (prop.NameEquals("call_id"u8))
                {
                    callId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("output"u8))
                {
                    functionOutput = prop.Value.GetString();
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new FunctionCallOutputResponseItem(
                @type,
                id,
                additionalBinaryDataProperties,
                status,
                callId,
                functionOutput);
        }

        BinaryData IPersistableModel<FunctionCallOutputResponseItem>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FunctionCallOutputResponseItem>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FunctionCallOutputResponseItem)} does not support writing '{options.Format}' format.");
            }
        }

        FunctionCallOutputResponseItem IPersistableModel<FunctionCallOutputResponseItem>.Create(BinaryData data, ModelReaderWriterOptions options) => (FunctionCallOutputResponseItem)PersistableModelCreateCore(data, options);

        protected override ResponseItem PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FunctionCallOutputResponseItem>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeFunctionCallOutputResponseItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FunctionCallOutputResponseItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FunctionCallOutputResponseItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(FunctionCallOutputResponseItem functionCallOutputResponseItem)
        {
            if (functionCallOutputResponseItem == null)
            {
                return null;
            }
            return BinaryContent.Create(functionCallOutputResponseItem, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator FunctionCallOutputResponseItem(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeFunctionCallOutputResponseItem(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
