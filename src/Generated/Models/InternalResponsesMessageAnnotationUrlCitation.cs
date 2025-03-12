// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalResponsesMessageAnnotationUrlCitation : ResponseMessageAnnotation
    {
        public InternalResponsesMessageAnnotationUrlCitation(string url, string title, int startIndex, int endIndex) : base(ResponseMessageAnnotationKind.UriCitation)
        {
            Argument.AssertNotNull(url, nameof(url));
            Argument.AssertNotNull(title, nameof(title));

            Url = url;
            Title = title;
            StartIndex = startIndex;
            EndIndex = endIndex;
        }

        internal InternalResponsesMessageAnnotationUrlCitation(ResponseMessageAnnotationKind kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, string url, string title, int startIndex, int endIndex) : base(kind, additionalBinaryDataProperties)
        {
            Url = url;
            Title = title;
            StartIndex = startIndex;
            EndIndex = endIndex;
        }

        public string Url { get; set; }

        public string Title { get; set; }

        public int StartIndex { get; set; }

        public int EndIndex { get; set; }
    }
}
