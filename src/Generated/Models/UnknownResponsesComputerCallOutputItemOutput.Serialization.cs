// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class UnknownResponsesComputerCallOutputItemOutput : IJsonModel<ComputerOutput>
    {
        internal UnknownResponsesComputerCallOutputItemOutput()
        {
        }

        void IJsonModel<ComputerOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ComputerOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputerOutput)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
        }

        ComputerOutput IJsonModel<ComputerOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected override ComputerOutput JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ComputerOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputerOutput)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputerOutput(document.RootElement, options);
        }

        internal static UnknownResponsesComputerCallOutputItemOutput DeserializeUnknownResponsesComputerCallOutputItemOutput(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalResponsesComputerCallOutputItemOutputType @type = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    @type = new InternalResponsesComputerCallOutputItemOutputType(prop.Value.GetString());
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new UnknownResponsesComputerCallOutputItemOutput(@type, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ComputerOutput>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ComputerOutput>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputerOutput)} does not support writing '{options.Format}' format.");
            }
        }

        ComputerOutput IPersistableModel<ComputerOutput>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected override ComputerOutput PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ComputerOutput>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeComputerOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputerOutput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputerOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
