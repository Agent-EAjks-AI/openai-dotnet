// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Evals
{
    internal partial class InternalEvalRunFileContentDataContentSourceContent
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalEvalRunFileContentDataContentSourceContent(IDictionary<string, BinaryData> item)
        {
            // Plugin customization: ensure initialization of collections
            Argument.AssertNotNull(item, nameof(item));

            Item = item ?? new ChangeTrackingDictionary<string, BinaryData>();
            Sample = new ChangeTrackingDictionary<string, BinaryData>();
        }

        internal InternalEvalRunFileContentDataContentSourceContent(IDictionary<string, BinaryData> item, IDictionary<string, BinaryData> sample, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            // Plugin customization: ensure initialization of collections
            Item = item ?? new ChangeTrackingDictionary<string, BinaryData>();
            Sample = sample ?? new ChangeTrackingDictionary<string, BinaryData>();
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public IDictionary<string, BinaryData> Item { get; }

        public IDictionary<string, BinaryData> Sample { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
