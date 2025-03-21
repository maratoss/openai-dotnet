// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    public partial class RunTruncationStrategy
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal RunTruncationStrategy(int? lastMessages, InternalTruncationObjectType @type, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            LastMessages = lastMessages;
            _type = @type;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
