// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Responses
{
    internal readonly partial struct InternalResponsesToolChoiceOption : IEquatable<InternalResponsesToolChoiceOption>
    {
        private readonly string _value;
        private const string NoneValue = "none";
        private const string AutoValue = "auto";
        private const string RequiredValue = "required";

        public InternalResponsesToolChoiceOption(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalResponsesToolChoiceOption None { get; } = new InternalResponsesToolChoiceOption(NoneValue);

        public static InternalResponsesToolChoiceOption Auto { get; } = new InternalResponsesToolChoiceOption(AutoValue);

        public static InternalResponsesToolChoiceOption Required { get; } = new InternalResponsesToolChoiceOption(RequiredValue);

        public static bool operator ==(InternalResponsesToolChoiceOption left, InternalResponsesToolChoiceOption right) => left.Equals(right);

        public static bool operator !=(InternalResponsesToolChoiceOption left, InternalResponsesToolChoiceOption right) => !left.Equals(right);

        public static implicit operator InternalResponsesToolChoiceOption(string value) => new InternalResponsesToolChoiceOption(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalResponsesToolChoiceOption other && Equals(other);

        public bool Equals(InternalResponsesToolChoiceOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
