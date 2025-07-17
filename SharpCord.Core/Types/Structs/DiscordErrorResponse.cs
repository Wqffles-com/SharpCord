namespace SharpCord.Core.Types.Structs;

/// <summary>
/// Represents Discord's response to a faulty request
/// </summary>
public class DiscordErrorResponse
{
    /// <summary>
    /// The request's code
    /// </summary>
    /// <remarks>
    /// This is not the HTTP status code.
    /// </remarks>
    public int Code { get; set; }
    /// <summary>
    /// The message Discord provided.
    /// </summary>
    public required string Message { get; set; }
    /// <summary>
    /// A list of all the errors Discord provided.
    /// </summary>
    public Dictionary<string, DiscordFieldError> Errors { get; set; } = [];
}