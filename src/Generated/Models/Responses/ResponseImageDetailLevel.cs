// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using OpenAI;

namespace OpenAI.Responses
{
    [Experimental("OPENAI001")]
    public readonly partial struct ResponseImageDetailLevel : IEquatable<ResponseImageDetailLevel>
    {
        private readonly string _value;
        private const string LowValue = "low";
        private const string HighValue = "high";
        private const string AutoValue = "auto";

        public ResponseImageDetailLevel(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static ResponseImageDetailLevel Low { get; } = new ResponseImageDetailLevel(LowValue);

        public static ResponseImageDetailLevel High { get; } = new ResponseImageDetailLevel(HighValue);

        public static ResponseImageDetailLevel Auto { get; } = new ResponseImageDetailLevel(AutoValue);

        public static bool operator ==(ResponseImageDetailLevel left, ResponseImageDetailLevel right) => left.Equals(right);

        public static bool operator !=(ResponseImageDetailLevel left, ResponseImageDetailLevel right) => !left.Equals(right);

        public static implicit operator ResponseImageDetailLevel(string value) => new ResponseImageDetailLevel(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResponseImageDetailLevel other && Equals(other);

        public bool Equals(ResponseImageDetailLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
