// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionRequestMessageContentPartText : IJsonModel<InternalChatCompletionRequestMessageContentPartText>
    {
        void IJsonModel<InternalChatCompletionRequestMessageContentPartText>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionRequestMessageContentPartText>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatCompletionRequestMessageContentPartText)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
        }

        InternalChatCompletionRequestMessageContentPartText IJsonModel<InternalChatCompletionRequestMessageContentPartText>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalChatCompletionRequestMessageContentPartText)JsonModelCreateCore(ref reader, options);

        protected override ChatMessageContentPart JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionRequestMessageContentPartText>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatCompletionRequestMessageContentPartText)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalChatCompletionRequestMessageContentPartText(document.RootElement, options);
        }

        internal static InternalChatCompletionRequestMessageContentPartText DeserializeInternalChatCompletionRequestMessageContentPartText(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalChatCompletionRequestMessageContentPartText(additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalChatCompletionRequestMessageContentPartText>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionRequestMessageContentPartText>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalChatCompletionRequestMessageContentPartText)} does not support writing '{options.Format}' format.");
            }
        }

        InternalChatCompletionRequestMessageContentPartText IPersistableModel<InternalChatCompletionRequestMessageContentPartText>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalChatCompletionRequestMessageContentPartText)PersistableModelCreateCore(data, options);

        protected override ChatMessageContentPart PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionRequestMessageContentPartText>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalChatCompletionRequestMessageContentPartText(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalChatCompletionRequestMessageContentPartText)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalChatCompletionRequestMessageContentPartText>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
