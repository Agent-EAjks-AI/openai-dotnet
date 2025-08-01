// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Assistants
{
    [PersistableModelProxy(typeof(UnknownRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputsObject))]
    public partial class RunStepUpdateCodeInterpreterOutput : IJsonModel<RunStepUpdateCodeInterpreterOutput>
    {
        internal RunStepUpdateCodeInterpreterOutput()
        {
        }

        void IJsonModel<RunStepUpdateCodeInterpreterOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<RunStepUpdateCodeInterpreterOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepUpdateCodeInterpreterOutput)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Kind.ToString());
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

        RunStepUpdateCodeInterpreterOutput IJsonModel<RunStepUpdateCodeInterpreterOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual RunStepUpdateCodeInterpreterOutput JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<RunStepUpdateCodeInterpreterOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepUpdateCodeInterpreterOutput)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunStepUpdateCodeInterpreterOutput(document.RootElement, options);
        }

        internal static RunStepUpdateCodeInterpreterOutput DeserializeRunStepUpdateCodeInterpreterOutput(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type"u8, out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "logs":
                        return InternalRunStepDeltaStepDetailsToolCallsCodeOutputLogsObject.DeserializeInternalRunStepDeltaStepDetailsToolCallsCodeOutputLogsObject(element, options);
                    case "image":
                        return InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObject.DeserializeInternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObject(element, options);
                }
            }
            return UnknownRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputsObject.DeserializeUnknownRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputsObject(element, options);
        }

        BinaryData IPersistableModel<RunStepUpdateCodeInterpreterOutput>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<RunStepUpdateCodeInterpreterOutput>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(RunStepUpdateCodeInterpreterOutput)} does not support writing '{options.Format}' format.");
            }
        }

        RunStepUpdateCodeInterpreterOutput IPersistableModel<RunStepUpdateCodeInterpreterOutput>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual RunStepUpdateCodeInterpreterOutput PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<RunStepUpdateCodeInterpreterOutput>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeRunStepUpdateCodeInterpreterOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunStepUpdateCodeInterpreterOutput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunStepUpdateCodeInterpreterOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
