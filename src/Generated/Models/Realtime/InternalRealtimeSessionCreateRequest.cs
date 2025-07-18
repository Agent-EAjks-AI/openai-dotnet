// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;
using OpenAI.Internal;

namespace OpenAI.Realtime
{
    internal partial class InternalRealtimeSessionCreateRequest
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalRealtimeSessionCreateRequest() : this(null, default, null, default, default, default, null, null, null, default, null, null, null, default, null, null, null)
        {
        }

        internal InternalRealtimeSessionCreateRequest(IList<InternalRealtimeRequestSessionModality> modalities, InternalRealtimeSessionCreateRequestModel? model, string instructions, InternalVoiceIdsShared? voice, RealtimeAudioFormat? inputAudioFormat, RealtimeAudioFormat? outputAudioFormat, InternalRealtimeSessionCreateRequestInputAudioTranscription inputAudioTranscription, InternalRealtimeSessionCreateRequestTurnDetection turnDetection, InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1 inputAudioNoiseReduction, float? speed, BinaryData tracing, IList<ConversationTool> tools, string toolChoice, float? temperature, BinaryData maxResponseOutputTokens, InternalRealtimeSessionCreateRequestClientSecret clientSecret, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            // Plugin customization: ensure initialization of collections
            Modalities = modalities ?? new ChangeTrackingList<InternalRealtimeRequestSessionModality>();
            Model = model;
            Instructions = instructions;
            Voice = voice;
            InputAudioFormat = inputAudioFormat;
            OutputAudioFormat = outputAudioFormat;
            InputAudioTranscription = inputAudioTranscription;
            TurnDetection = turnDetection;
            InputAudioNoiseReduction = inputAudioNoiseReduction;
            Speed = speed;
            Tracing = tracing;
            Tools = tools ?? new ChangeTrackingList<ConversationTool>();
            ToolChoice = toolChoice;
            Temperature = temperature;
            MaxResponseOutputTokens = maxResponseOutputTokens;
            ClientSecret = clientSecret;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        internal IList<InternalRealtimeRequestSessionModality> Modalities { get; }

        internal InternalRealtimeSessionCreateRequestModel? Model { get; set; }

        public string Instructions { get; set; }

        internal InternalVoiceIdsShared? Voice { get; set; }

        public RealtimeAudioFormat? InputAudioFormat { get; set; }

        public RealtimeAudioFormat? OutputAudioFormat { get; set; }

        internal InternalRealtimeSessionCreateRequestInputAudioTranscription InputAudioTranscription { get; set; }

        internal InternalRealtimeSessionCreateRequestTurnDetection TurnDetection { get; set; }

        internal InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1 InputAudioNoiseReduction { get; set; }

        public float? Speed { get; set; }

        public BinaryData Tracing { get; set; }

        public IList<ConversationTool> Tools { get; }

        public string ToolChoice { get; set; }

        public float? Temperature { get; set; }

        public BinaryData MaxResponseOutputTokens { get; set; }

        internal InternalRealtimeSessionCreateRequestClientSecret ClientSecret { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
