// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Responses
{
    internal readonly partial struct InternalItemType : IEquatable<InternalItemType>
    {
        private readonly string _value;
        private const string MessageValue = "message";
        private const string FileSearchCallValue = "file_search_call";
        private const string FunctionCallValue = "function_call";
        private const string FunctionCallOutputValue = "function_call_output";
        private const string ComputerCallValue = "computer_call";
        private const string ComputerCallOutputValue = "computer_call_output";
        private const string WebSearchCallValue = "web_search_call";
        private const string ReasoningValue = "reasoning";
        private const string ItemReferenceValue = "item_reference";
        private const string ImageGenerationCallValue = "image_generation_call";
        private const string CodeInterpreterCallValue = "code_interpreter_call";
        private const string LocalShellCallValue = "local_shell_call";
        private const string LocalShellCallOutputValue = "local_shell_call_output";
        private const string McpListToolsValue = "mcp_list_tools";
        private const string McpApprovalRequestValue = "mcp_approval_request";
        private const string McpApprovalResponseValue = "mcp_approval_response";
        private const string McpCallValue = "mcp_call";

        public InternalItemType(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        internal static InternalItemType Message { get; } = new InternalItemType(MessageValue);

        internal static InternalItemType FileSearchCall { get; } = new InternalItemType(FileSearchCallValue);

        internal static InternalItemType FunctionCall { get; } = new InternalItemType(FunctionCallValue);

        internal static InternalItemType FunctionCallOutput { get; } = new InternalItemType(FunctionCallOutputValue);

        internal static InternalItemType ComputerCall { get; } = new InternalItemType(ComputerCallValue);

        internal static InternalItemType ComputerCallOutput { get; } = new InternalItemType(ComputerCallOutputValue);

        internal static InternalItemType WebSearchCall { get; } = new InternalItemType(WebSearchCallValue);

        internal static InternalItemType Reasoning { get; } = new InternalItemType(ReasoningValue);

        internal static InternalItemType ItemReference { get; } = new InternalItemType(ItemReferenceValue);

        internal static InternalItemType ImageGenerationCall { get; } = new InternalItemType(ImageGenerationCallValue);

        internal static InternalItemType CodeInterpreterCall { get; } = new InternalItemType(CodeInterpreterCallValue);

        internal static InternalItemType LocalShellCall { get; } = new InternalItemType(LocalShellCallValue);

        internal static InternalItemType LocalShellCallOutput { get; } = new InternalItemType(LocalShellCallOutputValue);

        internal static InternalItemType McpListTools { get; } = new InternalItemType(McpListToolsValue);

        internal static InternalItemType McpApprovalRequest { get; } = new InternalItemType(McpApprovalRequestValue);

        internal static InternalItemType McpApprovalResponse { get; } = new InternalItemType(McpApprovalResponseValue);

        internal static InternalItemType McpCall { get; } = new InternalItemType(McpCallValue);

        public static bool operator ==(InternalItemType left, InternalItemType right) => left.Equals(right);

        public static bool operator !=(InternalItemType left, InternalItemType right) => !left.Equals(right);

        public static implicit operator InternalItemType(string value) => new InternalItemType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalItemType other && Equals(other);

        public bool Equals(InternalItemType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
