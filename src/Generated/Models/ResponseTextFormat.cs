// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Responses
{
    public partial class ResponseTextFormat
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        private protected ResponseTextFormat(InternalResponsesTextFormatType @type)
        {
            Type = @type;
        }

        internal ResponseTextFormat(InternalResponsesTextFormatType @type, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Type = @type;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        internal InternalResponsesTextFormatType Type { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
