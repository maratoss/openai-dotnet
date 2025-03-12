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
    public partial class FileSearchRankingOptions : IJsonModel<FileSearchRankingOptions>
    {
        void IJsonModel<FileSearchRankingOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FileSearchRankingOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileSearchRankingOptions)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(Ranker) && _additionalBinaryDataProperties?.ContainsKey("ranker") != true)
            {
                writer.WritePropertyName("ranker"u8);
                writer.WriteStringValue(Ranker.Value.ToString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("score_threshold") != true)
            {
                writer.WritePropertyName("score_threshold"u8);
                writer.WriteNumberValue(_scoreThreshold);
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

        FileSearchRankingOptions IJsonModel<FileSearchRankingOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual FileSearchRankingOptions JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FileSearchRankingOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileSearchRankingOptions)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFileSearchRankingOptions(document.RootElement, options);
        }

        internal static FileSearchRankingOptions DeserializeFileSearchRankingOptions(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FileSearchRanker? ranker = default;
            float scoreThreshold = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("ranker"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ranker = new FileSearchRanker(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("score_threshold"u8))
                {
                    scoreThreshold = prop.Value.GetSingle();
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new FileSearchRankingOptions(ranker, scoreThreshold, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<FileSearchRankingOptions>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FileSearchRankingOptions>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FileSearchRankingOptions)} does not support writing '{options.Format}' format.");
            }
        }

        FileSearchRankingOptions IPersistableModel<FileSearchRankingOptions>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual FileSearchRankingOptions PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FileSearchRankingOptions>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeFileSearchRankingOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FileSearchRankingOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FileSearchRankingOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(FileSearchRankingOptions fileSearchRankingOptions)
        {
            if (fileSearchRankingOptions == null)
            {
                return null;
            }
            return BinaryContent.Create(fileSearchRankingOptions, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator FileSearchRankingOptions(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeFileSearchRankingOptions(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
