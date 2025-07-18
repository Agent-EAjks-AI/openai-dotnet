// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Chat
{
    [Experimental("OPENAI001")]
    public partial class ChatCompletionDeletionResult
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ChatCompletionDeletionResult(bool deleted, string chatCompletionId)
        {
            Deleted = deleted;
            ChatCompletionId = chatCompletionId;
        }

        internal ChatCompletionDeletionResult(bool deleted, string @object, string chatCompletionId, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Deleted = deleted;
            Object = @object;
            ChatCompletionId = chatCompletionId;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public bool Deleted { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
