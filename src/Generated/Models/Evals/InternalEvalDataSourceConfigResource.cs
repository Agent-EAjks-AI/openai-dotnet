// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Evals
{
    internal abstract partial class InternalEvalDataSourceConfigResource
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        private protected InternalEvalDataSourceConfigResource(InternalEvalDataSourceConfigType kind)
        {
            Kind = kind;
        }

        internal InternalEvalDataSourceConfigResource(InternalEvalDataSourceConfigType kind, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Kind = kind;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        internal InternalEvalDataSourceConfigType Kind { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
