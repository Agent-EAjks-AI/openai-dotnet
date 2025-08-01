// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Evals
{
    internal partial class InternalEvalRunOutputItemSampleInput
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalEvalRunOutputItemSampleInput(string role, string content)
        {
            Role = role;
            Content = content;
        }

        internal InternalEvalRunOutputItemSampleInput(string role, string content, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Role = role;
            Content = content;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Role { get; }

        public string Content { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
