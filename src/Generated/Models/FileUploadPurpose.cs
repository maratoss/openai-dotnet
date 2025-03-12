// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Files
{
    public readonly partial struct FileUploadPurpose : IEquatable<FileUploadPurpose>
    {
        private readonly string _value;
        private const string AssistantsValue = "assistants";
        private const string BatchValue = "batch";
        private const string FineTuneValue = "fine-tune";
        private const string VisionValue = "vision";
        private const string UserDataValue = "user_data";
        private const string EvalsValue = "evals";

        public FileUploadPurpose(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static FileUploadPurpose Assistants { get; } = new FileUploadPurpose(AssistantsValue);

        public static FileUploadPurpose Batch { get; } = new FileUploadPurpose(BatchValue);

        public static FileUploadPurpose FineTune { get; } = new FileUploadPurpose(FineTuneValue);

        public static FileUploadPurpose Vision { get; } = new FileUploadPurpose(VisionValue);

        public static FileUploadPurpose UserData { get; } = new FileUploadPurpose(UserDataValue);

        public static bool operator ==(FileUploadPurpose left, FileUploadPurpose right) => left.Equals(right);

        public static bool operator !=(FileUploadPurpose left, FileUploadPurpose right) => !left.Equals(right);

        public static implicit operator FileUploadPurpose(string value) => new FileUploadPurpose(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FileUploadPurpose other && Equals(other);

        public bool Equals(FileUploadPurpose other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
