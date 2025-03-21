// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeResponseMessageItem : InternalRealtimeConversationResponseItem
    {
        internal InternalRealtimeResponseMessageItem(string id, ConversationItemStatus status, ConversationMessageRole role) : base(InternalRealtimeItemType.Message, id)
        {
            Status = status;
            Role = role;
            Content = new ChangeTrackingList<ConversationContentPart>();
        }

        internal InternalRealtimeResponseMessageItem(InternalRealtimeConversationResponseItemObject @object, InternalRealtimeItemType @type, string id, IDictionary<string, BinaryData> additionalBinaryDataProperties, ConversationItemStatus status, ConversationMessageRole role, IReadOnlyList<ConversationContentPart> content) : base(@object, @type, id, additionalBinaryDataProperties)
        {
            Status = status;
            Role = role;
            Content = content;
        }

        public ConversationItemStatus Status { get; }
    }
}
