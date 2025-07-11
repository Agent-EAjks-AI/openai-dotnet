// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Responses
{
    internal partial class InternalResponsesMessageItemParam : InternalItemParam
    {
        internal InternalResponsesMessageItemParam(InternalResponsesMessageRole role) : base(InternalItemType.Message)
        {
            Role = role;
        }

        internal InternalResponsesMessageItemParam(InternalItemType kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, InternalResponsesMessageRole role) : base(kind, additionalBinaryDataProperties)
        {
            Role = role;
        }

        internal InternalResponsesMessageRole Role { get; set; }
    }
}
