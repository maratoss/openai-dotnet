// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Responses
{
    public partial class ResponseContentPart
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        private protected ResponseContentPart(ResponseContentPartKind kind)
        {
            Kind = kind;
        }

        internal ResponseContentPart(ResponseContentPartKind kind, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Kind = kind;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
