// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepDeltaStepDetailsToolCallsObject : InternalRunStepDeltaStepDetails
    {
        internal InternalRunStepDeltaStepDetailsToolCallsObject() : this(InternalRunStepDetailsType.ToolCalls, null, null)
        {
        }

        internal InternalRunStepDeltaStepDetailsToolCallsObject(InternalRunStepDetailsType kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, IList<InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject> toolCalls) : base(kind, additionalBinaryDataProperties)
        {
            // Plugin customization: ensure initialization of collections
            ToolCalls = toolCalls ?? new ChangeTrackingList<InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject>();
        }

        internal IList<InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject> ToolCalls { get; }
    }
}
