// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Realtime
{
    [Experimental("OPENAI002")]
    public partial class InputTranscriptionOptions
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InputTranscriptionOptions()
        {
        }

        internal InputTranscriptionOptions(InputTranscriptionModel? model, string language, string prompt, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Model = model;
            Language = language;
            Prompt = prompt;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InputTranscriptionModel? Model { get; set; }

        public string Language { get; set; }

        public string Prompt { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
