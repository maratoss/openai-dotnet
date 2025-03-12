// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Assistants
{
    internal static partial class MessageRoleExtensions
    {
        public static string ToSerialString(this MessageRole value) => value switch
        {
            MessageRole.User => "user",
            MessageRole.Assistant => "assistant",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MessageRole value.")
        };

        public static MessageRole ToMessageRole(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "user"))
            {
                return MessageRole.User;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "assistant"))
            {
                return MessageRole.Assistant;
            }
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MessageRole value.");
        }
    }
}
