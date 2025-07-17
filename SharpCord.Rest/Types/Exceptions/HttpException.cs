using System.Net;
using SharpCord.Core.Types.Structs;

namespace SharpCord.Rest.Types.Exceptions;

/// <summary>
/// Thrown when Discord produces an erroneous response.
/// </summary>
/// <param name="statusCode">The HTTP Status Code Discord responded with.</param>
/// <param name="endpoint">The endpoint </param>
/// <param name="errors"></param>
public class HttpException(HttpStatusCode statusCode, DiscordApiEndpoint endpoint, DiscordErrorResponse errors) : Exception
{
    public HttpStatusCode StatusCode => statusCode;
    public DiscordApiEndpoint Endpoint => endpoint;
    public DiscordErrorResponse ErrorResponse => errors;
}