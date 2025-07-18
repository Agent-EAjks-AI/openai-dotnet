// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalTopLogProb : IJsonModel<InternalTopLogProb>
    {
        internal InternalTopLogProb() : this(null, default, null, null)
        {
        }

        void IJsonModel<InternalTopLogProb>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalTopLogProb>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalTopLogProb)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("token") != true)
            {
                writer.WritePropertyName("token"u8);
                writer.WriteStringValue(Token);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("logprob") != true)
            {
                writer.WritePropertyName("logprob"u8);
                writer.WriteNumberValue(Logprob);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("bytes") != true)
            {
                writer.WritePropertyName("bytes"u8);
                writer.WriteStartArray();
                foreach (int item in Bytes)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            // Plugin customization: remove options.Format != "W" check
            if (_additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        InternalTopLogProb IJsonModel<InternalTopLogProb>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalTopLogProb JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalTopLogProb>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalTopLogProb)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalTopLogProb(document.RootElement, options);
        }

        internal static InternalTopLogProb DeserializeInternalTopLogProb(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string token = default;
            float logprob = default;
            IList<int> bytes = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("token"u8))
                {
                    token = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("logprob"u8))
                {
                    logprob = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("bytes"u8))
                {
                    List<int> array = new List<int>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    bytes = array;
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalTopLogProb(token, logprob, bytes, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalTopLogProb>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalTopLogProb>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalTopLogProb)} does not support writing '{options.Format}' format.");
            }
        }

        InternalTopLogProb IPersistableModel<InternalTopLogProb>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalTopLogProb PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalTopLogProb>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalTopLogProb(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalTopLogProb)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalTopLogProb>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
