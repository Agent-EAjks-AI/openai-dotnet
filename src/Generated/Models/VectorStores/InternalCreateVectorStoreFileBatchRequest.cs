// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using OpenAI;

namespace OpenAI.VectorStores
{
    internal partial class InternalCreateVectorStoreFileBatchRequest
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalCreateVectorStoreFileBatchRequest(IEnumerable<string> fileIds)
        {
            Argument.AssertNotNull(fileIds, nameof(fileIds));

            FileIds = fileIds.ToList();
            Attributes = new ChangeTrackingDictionary<string, BinaryData>();
        }

        internal InternalCreateVectorStoreFileBatchRequest(IList<string> fileIds, InternalChunkingStrategyRequestParam chunkingStrategy, IDictionary<string, BinaryData> attributes, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            // Plugin customization: ensure initialization of collections
            FileIds = fileIds ?? new ChangeTrackingList<string>();
            ChunkingStrategy = chunkingStrategy;
            Attributes = attributes ?? new ChangeTrackingDictionary<string, BinaryData>();
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public IList<string> FileIds { get; }

        internal InternalChunkingStrategyRequestParam ChunkingStrategy { get; set; }

        public IDictionary<string, BinaryData> Attributes { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
