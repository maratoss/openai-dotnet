// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;
using OpenAI.Chat;

namespace OpenAI.FineTuning
{
    internal partial class InternalFineTuneChatCompletionRequestAssistantMessage
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalFineTuneChatCompletionRequestAssistantMessage()
        {
            ToolCalls = new ChangeTrackingList<ChatToolCall>();
        }

        internal InternalFineTuneChatCompletionRequestAssistantMessage(InternalFineTuneChatCompletionRequestAssistantMessageWeight? weight, string refusal, InternalFineTuneChatCompletionRequestAssistantMessageRole role, string name, ChatOutputAudioReference audio, IList<ChatToolCall> toolCalls, ChatFunctionCall functionCall, ChatMessageContent content, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Weight = weight;
            Refusal = refusal;
            Role = role;
            Name = name;
            Audio = audio;
            ToolCalls = toolCalls;
            FunctionCall = functionCall;
            // Plugin customization: ensure initialization of collection
            Content = content ?? new ChatMessageContent();
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InternalFineTuneChatCompletionRequestAssistantMessageWeight? Weight { get; set; }

        public string Refusal { get; set; }

        public InternalFineTuneChatCompletionRequestAssistantMessageRole Role { get; } = "assistant";

        public string Name { get; set; }

        public ChatOutputAudioReference Audio { get; set; }

        public IList<ChatToolCall> ToolCalls { get; }

        public ChatFunctionCall FunctionCall { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
