// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.FineTuning
{
    internal partial class InternalListPaginatedFineTuningJobsResponse : IJsonModel<InternalListPaginatedFineTuningJobsResponse>
    {
        internal InternalListPaginatedFineTuningJobsResponse()
        {
        }

        void IJsonModel<InternalListPaginatedFineTuningJobsResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalListPaginatedFineTuningJobsResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalListPaginatedFineTuningJobsResponse)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("data") != true)
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (FineTuningJob item in Data)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (_additionalBinaryDataProperties?.ContainsKey("has_more") != true)
            {
                writer.WritePropertyName("has_more"u8);
                writer.WriteBooleanValue(HasMore);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("object") != true)
            {
                writer.WritePropertyName("object"u8);
                writer.WriteStringValue(Object.ToString());
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

        InternalListPaginatedFineTuningJobsResponse IJsonModel<InternalListPaginatedFineTuningJobsResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalListPaginatedFineTuningJobsResponse JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalListPaginatedFineTuningJobsResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalListPaginatedFineTuningJobsResponse)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalListPaginatedFineTuningJobsResponse(document.RootElement, options);
        }

        internal static InternalListPaginatedFineTuningJobsResponse DeserializeInternalListPaginatedFineTuningJobsResponse(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<FineTuningJob> data = default;
            bool hasMore = default;
            InternalListPaginatedFineTuningJobsResponseObject @object = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("data"u8))
                {
                    List<FineTuningJob> array = new List<FineTuningJob>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(FineTuningJob.DeserializeFineTuningJob(item, options));
                    }
                    data = array;
                    continue;
                }
                if (prop.NameEquals("has_more"u8))
                {
                    hasMore = prop.Value.GetBoolean();
                    continue;
                }
                if (prop.NameEquals("object"u8))
                {
                    @object = new InternalListPaginatedFineTuningJobsResponseObject(prop.Value.GetString());
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalListPaginatedFineTuningJobsResponse(data, hasMore, @object, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalListPaginatedFineTuningJobsResponse>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalListPaginatedFineTuningJobsResponse>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalListPaginatedFineTuningJobsResponse)} does not support writing '{options.Format}' format.");
            }
        }

        InternalListPaginatedFineTuningJobsResponse IPersistableModel<InternalListPaginatedFineTuningJobsResponse>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalListPaginatedFineTuningJobsResponse PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalListPaginatedFineTuningJobsResponse>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalListPaginatedFineTuningJobsResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalListPaginatedFineTuningJobsResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalListPaginatedFineTuningJobsResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalListPaginatedFineTuningJobsResponse internalListPaginatedFineTuningJobsResponse)
        {
            if (internalListPaginatedFineTuningJobsResponse == null)
            {
                return null;
            }
            return BinaryContent.Create(internalListPaginatedFineTuningJobsResponse, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalListPaginatedFineTuningJobsResponse(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalListPaginatedFineTuningJobsResponse(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
