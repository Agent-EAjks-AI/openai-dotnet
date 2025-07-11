using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Responses;

// CUSTOM:
// - Added Experimental attribute.
// - Renamed.
[Experimental("OPENAI001")]
[CodeGenType("ResponseOutputItemDoneEvent")]
public partial class StreamingResponseOutputItemDoneUpdate : StreamingResponseUpdate
{
}