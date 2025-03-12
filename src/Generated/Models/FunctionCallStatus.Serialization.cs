// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Responses
{
    internal static partial class FunctionCallStatusExtensions
    {
        public static string ToSerialString(this FunctionCallStatus value) => value switch
        {
            FunctionCallStatus.InProgress => "in_progress",
            FunctionCallStatus.Completed => "completed",
            FunctionCallStatus.Incomplete => "incomplete",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FunctionCallStatus value.")
        };

        public static FunctionCallStatus ToFunctionCallStatus(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "in_progress"))
            {
                return FunctionCallStatus.InProgress;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "completed"))
            {
                return FunctionCallStatus.Completed;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "incomplete"))
            {
                return FunctionCallStatus.Incomplete;
            }
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FunctionCallStatus value.");
        }
    }
}
