// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalFunctionToolCallItemParam : InternalItemParam
    {
        public InternalFunctionToolCallItemParam(string callId, string name, string arguments) : base(InternalItemType.FunctionCall)
        {
            Argument.AssertNotNull(callId, nameof(callId));
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(arguments, nameof(arguments));

            CallId = callId;
            Name = name;
            Arguments = arguments;
        }

        internal InternalFunctionToolCallItemParam(InternalItemType kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, string callId, string name, string arguments) : base(kind, additionalBinaryDataProperties)
        {
            CallId = callId;
            Name = name;
            Arguments = arguments;
        }

        public string CallId { get; }

        public string Name { get; }

        public string Arguments { get; }
    }
}
