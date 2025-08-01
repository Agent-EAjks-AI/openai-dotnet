// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Images
{
    public partial class GeneratedImageCollection : IJsonModel<GeneratedImageCollection>
    {
        void IJsonModel<GeneratedImageCollection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        [Experimental("OPENAI001")]
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<GeneratedImageCollection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GeneratedImageCollection)} does not support writing '{format}' format.");
            }
            if (Optional.IsCollectionDefined(Data) && _additionalBinaryDataProperties?.ContainsKey("data") != true)
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (GeneratedImage item in Data)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Usage) && _additionalBinaryDataProperties?.ContainsKey("usage") != true)
            {
                writer.WritePropertyName("usage"u8);
                writer.WriteObjectValue(Usage, options);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("created") != true)
            {
                writer.WritePropertyName("created"u8);
                writer.WriteNumberValue(CreatedAt, "U");
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

        GeneratedImageCollection IJsonModel<GeneratedImageCollection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        [Experimental("OPENAI001")]
        protected virtual GeneratedImageCollection JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<GeneratedImageCollection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GeneratedImageCollection)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGeneratedImageCollection(document.RootElement, options);
        }

        internal static GeneratedImageCollection DeserializeGeneratedImageCollection(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<GeneratedImage> data = default;
            ImageTokenUsage usage = default;
            DateTimeOffset createdAt = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("data"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GeneratedImage> array = new List<GeneratedImage>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(GeneratedImage.DeserializeGeneratedImage(item, options));
                    }
                    data = array;
                    continue;
                }
                if (prop.NameEquals("usage"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usage = ImageTokenUsage.DeserializeImageTokenUsage(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("created"u8))
                {
                    createdAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new GeneratedImageCollection(data ?? new ChangeTrackingList<GeneratedImage>(), usage, createdAt, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<GeneratedImageCollection>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        [Experimental("OPENAI001")]
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<GeneratedImageCollection>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(GeneratedImageCollection)} does not support writing '{options.Format}' format.");
            }
        }

        GeneratedImageCollection IPersistableModel<GeneratedImageCollection>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        [Experimental("OPENAI001")]
        protected virtual GeneratedImageCollection PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<GeneratedImageCollection>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeGeneratedImageCollection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GeneratedImageCollection)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GeneratedImageCollection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
