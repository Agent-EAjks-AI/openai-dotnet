// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Evals
{
    internal partial class InternalEvalCompletionsRunDataSourceParamsInputMessages2
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalEvalCompletionsRunDataSourceParamsInputMessages2(string itemReference)
        {
            Argument.AssertNotNull(itemReference, nameof(itemReference));

            ItemReference = itemReference;
        }

        internal InternalEvalCompletionsRunDataSourceParamsInputMessages2(string kind, string itemReference, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Kind = kind;
            ItemReference = itemReference;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Kind { get; } = "item_reference";

        public string ItemReference { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
