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
    public partial class ComputerCallSafetyCheck : IJsonModel<ComputerCallSafetyCheck>
    {
        internal ComputerCallSafetyCheck()
        {
        }

        void IJsonModel<ComputerCallSafetyCheck>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ComputerCallSafetyCheck>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputerCallSafetyCheck)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("id") != true)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("code") != true)
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("message") != true)
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
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

        ComputerCallSafetyCheck IJsonModel<ComputerCallSafetyCheck>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual ComputerCallSafetyCheck JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ComputerCallSafetyCheck>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputerCallSafetyCheck)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputerCallSafetyCheck(document.RootElement, options);
        }

        internal static ComputerCallSafetyCheck DeserializeComputerCallSafetyCheck(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string code = default;
            string message = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("id"u8))
                {
                    id = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("code"u8))
                {
                    code = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("message"u8))
                {
                    message = prop.Value.GetString();
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new ComputerCallSafetyCheck(id, code, message, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ComputerCallSafetyCheck>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ComputerCallSafetyCheck>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputerCallSafetyCheck)} does not support writing '{options.Format}' format.");
            }
        }

        ComputerCallSafetyCheck IPersistableModel<ComputerCallSafetyCheck>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual ComputerCallSafetyCheck PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ComputerCallSafetyCheck>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeComputerCallSafetyCheck(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputerCallSafetyCheck)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputerCallSafetyCheck>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(ComputerCallSafetyCheck computerCallSafetyCheck)
        {
            if (computerCallSafetyCheck == null)
            {
                return null;
            }
            return BinaryContent.Create(computerCallSafetyCheck, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator ComputerCallSafetyCheck(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeComputerCallSafetyCheck(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
