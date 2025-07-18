// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Batch
{
    internal readonly partial struct InternalBatchStatus : IEquatable<InternalBatchStatus>
    {
        private readonly string _value;
        private const string ValidatingValue = "validating";
        private const string FailedValue = "failed";
        private const string InProgressValue = "in_progress";
        private const string FinalizingValue = "finalizing";
        private const string CompletedValue = "completed";
        private const string ExpiredValue = "expired";
        private const string CancellingValue = "cancelling";
        private const string CancelledValue = "cancelled";

        public InternalBatchStatus(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        internal static InternalBatchStatus Validating { get; } = new InternalBatchStatus(ValidatingValue);

        internal static InternalBatchStatus Failed { get; } = new InternalBatchStatus(FailedValue);

        internal static InternalBatchStatus InProgress { get; } = new InternalBatchStatus(InProgressValue);

        internal static InternalBatchStatus Finalizing { get; } = new InternalBatchStatus(FinalizingValue);

        internal static InternalBatchStatus Completed { get; } = new InternalBatchStatus(CompletedValue);

        internal static InternalBatchStatus Expired { get; } = new InternalBatchStatus(ExpiredValue);

        internal static InternalBatchStatus Cancelling { get; } = new InternalBatchStatus(CancellingValue);

        internal static InternalBatchStatus Cancelled { get; } = new InternalBatchStatus(CancelledValue);

        public static bool operator ==(InternalBatchStatus left, InternalBatchStatus right) => left.Equals(right);

        public static bool operator !=(InternalBatchStatus left, InternalBatchStatus right) => !left.Equals(right);

        public static implicit operator InternalBatchStatus(string value) => new InternalBatchStatus(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalBatchStatus other && Equals(other);

        public bool Equals(InternalBatchStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
