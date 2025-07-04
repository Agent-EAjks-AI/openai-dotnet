// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using OpenAI;
using OpenAI.Responses;

namespace OpenAI.VectorStores
{
    public partial class StaticFileChunkingStrategy : IJsonModel<StaticFileChunkingStrategy>
    {
        internal StaticFileChunkingStrategy() : this(InternalDotNetCombinedChunkingStrategyParamType2.Static, null, null)
        {
        }

        void IJsonModel<StaticFileChunkingStrategy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        [Experimental("OPENAI001")]
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StaticFileChunkingStrategy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticFileChunkingStrategy)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("static") != true)
            {
                writer.WritePropertyName("static"u8);
                writer.WriteObjectValue(_internalDetails, options);
            }
        }

        StaticFileChunkingStrategy IJsonModel<StaticFileChunkingStrategy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (StaticFileChunkingStrategy)JsonModelCreateCore(ref reader, options);

        [Experimental("OPENAI001")]
        protected override FileChunkingStrategy JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StaticFileChunkingStrategy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticFileChunkingStrategy)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStaticFileChunkingStrategy(document.RootElement, options);
        }

        internal static StaticFileChunkingStrategy DeserializeStaticFileChunkingStrategy(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalDotNetCombinedChunkingStrategyParamType2 kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            InternalStaticChunkingStrategy internalDetails = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new InternalDotNetCombinedChunkingStrategyParamType2(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("static"u8))
                {
                    internalDetails = InternalStaticChunkingStrategy.DeserializeInternalStaticChunkingStrategy(prop.Value, options);
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new StaticFileChunkingStrategy(kind, additionalBinaryDataProperties, internalDetails);
        }

        BinaryData IPersistableModel<StaticFileChunkingStrategy>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        [Experimental("OPENAI001")]
        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StaticFileChunkingStrategy>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(StaticFileChunkingStrategy)} does not support writing '{options.Format}' format.");
            }
        }

        StaticFileChunkingStrategy IPersistableModel<StaticFileChunkingStrategy>.Create(BinaryData data, ModelReaderWriterOptions options) => (StaticFileChunkingStrategy)PersistableModelCreateCore(data, options);

        [Experimental("OPENAI001")]
        protected override FileChunkingStrategy PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StaticFileChunkingStrategy>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeStaticFileChunkingStrategy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StaticFileChunkingStrategy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StaticFileChunkingStrategy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
