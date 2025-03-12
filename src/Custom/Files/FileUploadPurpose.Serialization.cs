// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Files
{
    internal static partial class FilePurposeExtensions
    {
        public static FilePurpose ToFilePurpose(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "assistants"))
            {
                return FilePurpose.Assistants;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "assistants_output"))
            {
                return FilePurpose.AssistantsOutput;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "batch"))
            {
                return FilePurpose.Batch;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "batch_output"))
            {
                return FilePurpose.BatchOutput;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "fine-tune"))
            {
                return FilePurpose.FineTune;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "fine-tune-results"))
            {
                return FilePurpose.FineTuneResults;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "vision"))
            {
                return FilePurpose.Vision;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "user_data"))
            {
                return FilePurpose.UserData;
            }
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FilePurpose value.");
        }
    }
}
