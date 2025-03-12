// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.FineTuning
{
    internal readonly partial struct InternalFineTuneChatCompletionRequestAssistantMessageWeight : IEquatable<InternalFineTuneChatCompletionRequestAssistantMessageWeight>
    {
        private readonly string _value;
        private const string _0Value = "0";
        private const string _1Value = "1";

        public InternalFineTuneChatCompletionRequestAssistantMessageWeight(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalFineTuneChatCompletionRequestAssistantMessageWeight _0 { get; } = new InternalFineTuneChatCompletionRequestAssistantMessageWeight(_0Value);

        public static InternalFineTuneChatCompletionRequestAssistantMessageWeight _1 { get; } = new InternalFineTuneChatCompletionRequestAssistantMessageWeight(_1Value);

        public static bool operator ==(InternalFineTuneChatCompletionRequestAssistantMessageWeight left, InternalFineTuneChatCompletionRequestAssistantMessageWeight right) => left.Equals(right);

        public static bool operator !=(InternalFineTuneChatCompletionRequestAssistantMessageWeight left, InternalFineTuneChatCompletionRequestAssistantMessageWeight right) => !left.Equals(right);

        public static implicit operator InternalFineTuneChatCompletionRequestAssistantMessageWeight(string value) => new InternalFineTuneChatCompletionRequestAssistantMessageWeight(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalFineTuneChatCompletionRequestAssistantMessageWeight other && Equals(other);

        public bool Equals(InternalFineTuneChatCompletionRequestAssistantMessageWeight other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
