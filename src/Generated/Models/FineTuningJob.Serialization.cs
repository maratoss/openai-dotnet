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
    internal partial class FineTuningJob : IJsonModel<FineTuningJob>
    {
        internal FineTuningJob()
        {
        }

        void IJsonModel<FineTuningJob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FineTuningJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FineTuningJob)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(UserProvidedSuffix) && _additionalBinaryDataProperties?.ContainsKey("user_provided_suffix") != true)
            {
                writer.WritePropertyName("user_provided_suffix"u8);
                writer.WriteStringValue(UserProvidedSuffix);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("id") != true)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("created_at") != true)
            {
                writer.WritePropertyName("created_at"u8);
                writer.WriteNumberValue(CreatedAt, "U");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("error") != true)
            {
                if (Optional.IsDefined(Error))
                {
                    writer.WritePropertyName("error"u8);
                    writer.WriteObjectValue(Error, options);
                }
                else
                {
                    writer.WriteNull("error"u8);
                }
            }
            if (_additionalBinaryDataProperties?.ContainsKey("fine_tuned_model") != true)
            {
                if (Optional.IsDefined(FineTunedModel))
                {
                    writer.WritePropertyName("fine_tuned_model"u8);
                    writer.WriteStringValue(FineTunedModel);
                }
                else
                {
                    writer.WriteNull("fine_tuned_model"u8);
                }
            }
            if (_additionalBinaryDataProperties?.ContainsKey("finished_at") != true)
            {
                if (Optional.IsDefined(FinishedAt))
                {
                    writer.WritePropertyName("finished_at"u8);
                    writer.WriteNumberValue(FinishedAt.Value, "U");
                }
                else
                {
                    writer.WriteNull("finished_at"u8);
                }
            }
            if (_additionalBinaryDataProperties?.ContainsKey("hyperparameters") != true)
            {
                writer.WritePropertyName("hyperparameters"u8);
                writer.WriteObjectValue(Hyperparameters, options);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("model") != true)
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("object") != true)
            {
                writer.WritePropertyName("object"u8);
                writer.WriteStringValue(Object.ToString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("organization_id") != true)
            {
                writer.WritePropertyName("organization_id"u8);
                writer.WriteStringValue(OrganizationId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("result_files") != true)
            {
                writer.WritePropertyName("result_files"u8);
                writer.WriteStartArray();
                foreach (string item in ResultFiles)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (_additionalBinaryDataProperties?.ContainsKey("status") != true)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.ToString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("trained_tokens") != true)
            {
                if (Optional.IsDefined(TrainedTokens))
                {
                    writer.WritePropertyName("trained_tokens"u8);
                    writer.WriteNumberValue(TrainedTokens.Value);
                }
                else
                {
                    writer.WriteNull("trained_tokens"u8);
                }
            }
            if (_additionalBinaryDataProperties?.ContainsKey("training_file") != true)
            {
                writer.WritePropertyName("training_file"u8);
                writer.WriteStringValue(TrainingFile);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("validation_file") != true)
            {
                if (Optional.IsDefined(ValidationFile))
                {
                    writer.WritePropertyName("validation_file"u8);
                    writer.WriteStringValue(ValidationFile);
                }
                else
                {
                    writer.WriteNull("validation_file"u8);
                }
            }
            if (Optional.IsCollectionDefined(Integrations) && _additionalBinaryDataProperties?.ContainsKey("integrations") != true)
            {
                writer.WritePropertyName("integrations"u8);
                writer.WriteStartArray();
                foreach (InternalFineTuningIntegration item in Integrations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (_additionalBinaryDataProperties?.ContainsKey("seed") != true)
            {
                writer.WritePropertyName("seed"u8);
                writer.WriteNumberValue(Seed);
            }
            if (Optional.IsDefined(EstimatedFinish) && _additionalBinaryDataProperties?.ContainsKey("estimated_finish") != true)
            {
                writer.WritePropertyName("estimated_finish"u8);
                writer.WriteNumberValue(EstimatedFinish.Value, "U");
            }
            if (Optional.IsDefined(Method) && _additionalBinaryDataProperties?.ContainsKey("method") != true)
            {
                writer.WritePropertyName("method"u8);
                writer.WriteObjectValue(Method, options);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("metadata") != true)
            {
                if (Optional.IsCollectionDefined(Metadata))
                {
                    writer.WritePropertyName("metadata"u8);
                    writer.WriteStartObject();
                    foreach (var item in Metadata)
                    {
                        writer.WritePropertyName(item.Key);
                        if (item.Value == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("metadata"u8);
                }
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

        FineTuningJob IJsonModel<FineTuningJob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual FineTuningJob JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FineTuningJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FineTuningJob)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFineTuningJob(document.RootElement, options);
        }

        internal static FineTuningJob DeserializeFineTuningJob(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string userProvidedSuffix = default;
            string id = default;
            DateTimeOffset createdAt = default;
            FineTuningJobError error = default;
            string fineTunedModel = default;
            DateTimeOffset? finishedAt = default;
            FineTuningJobHyperparameters hyperparameters = default;
            string model = default;
            InternalFineTuningJobObject @object = default;
            string organizationId = default;
            IList<string> resultFiles = default;
            FineTuningJobStatus status = default;
            int? trainedTokens = default;
            string trainingFile = default;
            string validationFile = default;
            IList<InternalFineTuningIntegration> integrations = default;
            int seed = default;
            DateTimeOffset? estimatedFinish = default;
            InternalTodoFineTuneMethod @method = default;
            IDictionary<string, string> metadata = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("user_provided_suffix"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        userProvidedSuffix = null;
                        continue;
                    }
                    userProvidedSuffix = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("id"u8))
                {
                    id = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("created_at"u8))
                {
                    createdAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("error"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        error = null;
                        continue;
                    }
                    error = FineTuningJobError.DeserializeFineTuningJobError(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("fine_tuned_model"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        fineTunedModel = null;
                        continue;
                    }
                    fineTunedModel = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("finished_at"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        finishedAt = null;
                        continue;
                    }
                    finishedAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("hyperparameters"u8))
                {
                    hyperparameters = FineTuningJobHyperparameters.DeserializeFineTuningJobHyperparameters(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("model"u8))
                {
                    model = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("object"u8))
                {
                    @object = new InternalFineTuningJobObject(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("organization_id"u8))
                {
                    organizationId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("result_files"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    resultFiles = array;
                    continue;
                }
                if (prop.NameEquals("status"u8))
                {
                    status = new FineTuningJobStatus(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("trained_tokens"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        trainedTokens = null;
                        continue;
                    }
                    trainedTokens = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("training_file"u8))
                {
                    trainingFile = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("validation_file"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationFile = null;
                        continue;
                    }
                    validationFile = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("integrations"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InternalFineTuningIntegration> array = new List<InternalFineTuningIntegration>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(InternalFineTuningIntegration.DeserializeInternalFineTuningIntegration(item, options));
                    }
                    integrations = array;
                    continue;
                }
                if (prop.NameEquals("seed"u8))
                {
                    seed = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("estimated_finish"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        estimatedFinish = null;
                        continue;
                    }
                    estimatedFinish = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("method"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @method = InternalTodoFineTuneMethod.DeserializeInternalTodoFineTuneMethod(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("metadata"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        metadata = new ChangeTrackingDictionary<string, string>();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var prop0 in prop.Value.EnumerateObject())
                    {
                        if (prop0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(prop0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(prop0.Name, prop0.Value.GetString());
                        }
                    }
                    metadata = dictionary;
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new FineTuningJob(
                userProvidedSuffix,
                id,
                createdAt,
                error,
                fineTunedModel,
                finishedAt,
                hyperparameters,
                model,
                @object,
                organizationId,
                resultFiles,
                status,
                trainedTokens,
                trainingFile,
                validationFile,
                integrations ?? new ChangeTrackingList<InternalFineTuningIntegration>(),
                seed,
                estimatedFinish,
                @method,
                metadata,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<FineTuningJob>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FineTuningJob>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FineTuningJob)} does not support writing '{options.Format}' format.");
            }
        }

        FineTuningJob IPersistableModel<FineTuningJob>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual FineTuningJob PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FineTuningJob>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeFineTuningJob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FineTuningJob)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FineTuningJob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(FineTuningJob fineTuningJob)
        {
            if (fineTuningJob == null)
            {
                return null;
            }
            return BinaryContent.Create(fineTuningJob, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator FineTuningJob(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeFineTuningJob(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
