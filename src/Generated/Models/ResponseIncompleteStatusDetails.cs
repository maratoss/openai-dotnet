// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Responses
{
    public partial class ResponseIncompleteStatusDetails
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ResponseIncompleteStatusDetails()
        {
        }

        internal ResponseIncompleteStatusDetails(ResponseIncompleteStatusReason? reason, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Reason = reason;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public ResponseIncompleteStatusReason? Reason { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
