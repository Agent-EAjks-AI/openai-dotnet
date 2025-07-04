// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Realtime
{
    internal partial class InternalRealtimeToolChoiceFunctionObjectFunction
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalRealtimeToolChoiceFunctionObjectFunction(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        internal InternalRealtimeToolChoiceFunctionObjectFunction(string name, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Name = name;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Name { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
