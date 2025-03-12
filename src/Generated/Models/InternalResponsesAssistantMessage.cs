// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalResponsesAssistantMessage : MessageResponseItem
    {
        internal InternalResponsesAssistantMessage(InternalResponsesItemType @type, string id, IDictionary<string, BinaryData> additionalBinaryDataProperties, MessageStatus? status, MessageRole role, IList<ResponseContentPart> internalContent) : base(@type, id, additionalBinaryDataProperties, status, role)
        {
            // Plugin customization: ensure initialization of collection
            InternalContent = internalContent ?? new ChangeTrackingList<ResponseContentPart>();
        }
    }
}
