// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Responses
{
    internal partial class InternalResponsesResponseStreamEventResponseOutputItemAdded : StreamingResponseUpdate
    {
        internal InternalResponsesResponseStreamEventResponseOutputItemAdded(int outputIndex, ResponseItem item) : base(StreamingResponseUpdateKind.ResponseOutputItemAdded)
        {
            OutputIndex = outputIndex;
            Item = item;
        }

        internal InternalResponsesResponseStreamEventResponseOutputItemAdded(StreamingResponseUpdateKind kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, int outputIndex, ResponseItem item) : base(kind, additionalBinaryDataProperties)
        {
            OutputIndex = outputIndex;
            Item = item;
        }

        public int OutputIndex { get; }

        public ResponseItem Item { get; }
    }
}
