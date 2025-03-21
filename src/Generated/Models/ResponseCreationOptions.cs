// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Responses
{
    public partial class ResponseCreationOptions
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ResponseCreationOptions(IDictionary<string, string> metadata, float? temperature, float? topP, string previousResponseId, string instructions, IList<ResponseTool> tools, BinaryData toolChoice, IList<InternalCreateResponsesRequestIncludable> include, InternalCreateResponsesRequestModel model, IList<ResponseItem> input, bool? stream, string endUserId, ResponseReasoningOptions reasoningOptions, int? maxOutputTokenCount, ResponseTextOptions textOptions, ResponseTruncationMode? truncationMode, bool? allowParallelToolCalls, bool? storedOutputEnabled, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Metadata = metadata;
            Temperature = temperature;
            TopP = topP;
            PreviousResponseId = previousResponseId;
            Instructions = instructions;
            Tools = tools;
            ToolChoice = toolChoice;
            Include = include;
            Model = model;
            Input = input;
            Stream = stream;
            EndUserId = endUserId;
            ReasoningOptions = reasoningOptions;
            MaxOutputTokenCount = maxOutputTokenCount;
            TextOptions = textOptions;
            TruncationMode = truncationMode;
            AllowParallelToolCalls = allowParallelToolCalls;
            StoredOutputEnabled = storedOutputEnabled;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public IDictionary<string, string> Metadata { get; }

        public float? Temperature { get; set; }

        public float? TopP { get; set; }

        public string PreviousResponseId { get; set; }

        public string Instructions { get; set; }

        public IList<ResponseTool> Tools { get; set; }

        public BinaryData ToolChoice { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
