// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Audio
{
    public partial class AudioTranslation : IJsonModel<AudioTranslation>
    {
        internal AudioTranslation() : this(null, null, null, null, default, null)
        {
        }

        void IJsonModel<AudioTranslation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        [Experimental("OPENAI001")]
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<AudioTranslation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AudioTranslation)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("language") != true)
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("text") != true)
            {
                writer.WritePropertyName("text"u8);
                writer.WriteStringValue(Text);
            }
            // Plugin customization: remove options.Format != "W" check
            if (Optional.IsCollectionDefined(Segments) && _additionalBinaryDataProperties?.ContainsKey("segments") != true)
            {
                writer.WritePropertyName("segments"u8);
                writer.WriteStartArray();
                foreach (TranscribedSegment item in Segments)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (_additionalBinaryDataProperties?.ContainsKey("task") != true)
            {
                writer.WritePropertyName("task"u8);
                writer.WriteStringValue(Task);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("duration") != true)
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteNumberValue(Convert.ToDouble(Duration.Value.ToString("s\\.FFF")));
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

        AudioTranslation IJsonModel<AudioTranslation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        [Experimental("OPENAI001")]
        protected virtual AudioTranslation JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<AudioTranslation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AudioTranslation)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAudioTranslation(document.RootElement, options);
        }

        internal static AudioTranslation DeserializeAudioTranslation(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string language = default;
            string text = default;
            IReadOnlyList<TranscribedSegment> segments = default;
            string task = default;
            TimeSpan? duration = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("language"u8))
                {
                    language = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("text"u8))
                {
                    text = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("segments"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TranscribedSegment> array = new List<TranscribedSegment>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(TranscribedSegment.DeserializeTranscribedSegment(item, options));
                    }
                    segments = array;
                    continue;
                }
                if (prop.NameEquals("task"u8))
                {
                    task = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("duration"u8))
                {
                    duration = TimeSpan.FromSeconds(prop.Value.GetDouble());
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new AudioTranslation(
                language,
                text,
                segments ?? new ChangeTrackingList<TranscribedSegment>(),
                task,
                duration,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<AudioTranslation>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        [Experimental("OPENAI001")]
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<AudioTranslation>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AudioTranslation)} does not support writing '{options.Format}' format.");
            }
        }

        AudioTranslation IPersistableModel<AudioTranslation>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        [Experimental("OPENAI001")]
        protected virtual AudioTranslation PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<AudioTranslation>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeAudioTranslation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AudioTranslation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AudioTranslation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
