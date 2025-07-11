// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using OpenAI;

namespace OpenAI.VectorStores
{
    internal partial class InternalVectorStoreSearchResultsPage
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalVectorStoreSearchResultsPage(IEnumerable<string> searchQuery, IEnumerable<InternalVectorStoreSearchResultItem> data, bool hasMore, string nextPage)
        {
            SearchQuery = searchQuery.ToList();
            Data = data.ToList();
            HasMore = hasMore;
            NextPage = nextPage;
        }

        internal InternalVectorStoreSearchResultsPage(string @object, IList<string> searchQuery, IList<InternalVectorStoreSearchResultItem> data, bool hasMore, string nextPage, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            // Plugin customization: ensure initialization of collections
            Object = @object;
            SearchQuery = searchQuery ?? new ChangeTrackingList<string>();
            Data = data ?? new ChangeTrackingList<InternalVectorStoreSearchResultItem>();
            HasMore = hasMore;
            NextPage = nextPage;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Object { get; } = "vector_store.search_results.page";

        public IList<string> SearchQuery { get; }

        internal IList<InternalVectorStoreSearchResultItem> Data { get; }

        public bool HasMore { get; }

        public string NextPage { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
