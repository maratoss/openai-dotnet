// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter : IJsonModel<InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter>
    {
        internal InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter()
        {
        }

        void IJsonModel<InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("input") != true)
            {
                writer.WritePropertyName("input"u8);
                writer.WriteStringValue(Input);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("outputs") != true)
            {
                writer.WritePropertyName("outputs"u8);
                writer.WriteStartArray();
                foreach (RunStepCodeInterpreterOutput item in Outputs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter IJsonModel<InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRunStepDetailsToolCallsCodeObjectCodeInterpreter(document.RootElement, options);
        }

        internal static InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter DeserializeInternalRunStepDetailsToolCallsCodeObjectCodeInterpreter(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string input = default;
            IReadOnlyList<RunStepCodeInterpreterOutput> outputs = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("input"u8))
                {
                    input = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("outputs"u8))
                {
                    List<RunStepCodeInterpreterOutput> array = new List<RunStepCodeInterpreterOutput>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(RunStepCodeInterpreterOutput.DeserializeRunStepCodeInterpreterOutput(item, options));
                    }
                    outputs = array;
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter(input, outputs, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter IPersistableModel<InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRunStepDetailsToolCallsCodeObjectCodeInterpreter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter internalRunStepDetailsToolCallsCodeObjectCodeInterpreter)
        {
            if (internalRunStepDetailsToolCallsCodeObjectCodeInterpreter == null)
            {
                return null;
            }
            return BinaryContent.Create(internalRunStepDetailsToolCallsCodeObjectCodeInterpreter, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRunStepDetailsToolCallsCodeObjectCodeInterpreter(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
