// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Responses
{
    internal static partial class ResponseMessageAnnotationKindExtensions
    {
        public static string ToSerialString(this ResponseMessageAnnotationKind value) => value switch
        {
            ResponseMessageAnnotationKind.FileCitation => "file_citation",
            ResponseMessageAnnotationKind.UriCitation => "url_citation",
            ResponseMessageAnnotationKind.FilePath => "file_path",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ResponseMessageAnnotationKind value.")
        };

        public static ResponseMessageAnnotationKind ToResponseMessageAnnotationKind(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "file_citation"))
            {
                return ResponseMessageAnnotationKind.FileCitation;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "url_citation"))
            {
                return ResponseMessageAnnotationKind.UriCitation;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "file_path"))
            {
                return ResponseMessageAnnotationKind.FilePath;
            }
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ResponseMessageAnnotationKind value.");
        }
    }
}
