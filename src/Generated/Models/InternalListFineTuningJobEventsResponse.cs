// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.FineTuning
{
    internal partial class InternalListFineTuningJobEventsResponse
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalListFineTuningJobEventsResponse(IEnumerable<FineTuningJobEvent> data, bool hasMore)
        {
            Data = data.ToList();
            HasMore = hasMore;
        }

        internal InternalListFineTuningJobEventsResponse(IList<FineTuningJobEvent> data, InternalListFineTuningJobEventsResponseObject @object, bool hasMore, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Data = data;
            Object = @object;
            HasMore = hasMore;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public IList<FineTuningJobEvent> Data { get; }

        public InternalListFineTuningJobEventsResponseObject Object { get; } = "list";

        public bool HasMore { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
