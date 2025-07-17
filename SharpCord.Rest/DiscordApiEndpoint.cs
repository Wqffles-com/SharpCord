using JetBrains.Annotations;

namespace SharpCord.Rest;

[PublicAPI]
public class DiscordApiEndpoint
{
    #region Predefined endpoints

    public static DiscordApiEndpoint GetSelfUser => new("users/@me");
    public static DiscordApiEndpoint GetUser => new("users", 1);
    public static DiscordApiEndpoint GetGuild => new("guilds", 1);

    #endregion

    public Uri Endpoint { get; }
    public byte Version { get; }
    public Uri BaseUri => new($"https://discord.com/api/v{Version}/");
    public Uri FullUri => Build();
    public ushort RequiredParameters { get; }

    public List<string> Parameters { get; set; } = [];

    public DiscordApiEndpoint WithParameters(List<string> parameters)
    {
        if (parameters.Count != RequiredParameters)
            throw new ArgumentOutOfRangeException(nameof(parameters));

        Parameters = parameters;
        return this;
    }
    public DiscordApiEndpoint WithParameters(params string[] parameters) => WithParameters(parameters.ToList());
    public DiscordApiEndpoint AddParameters(List<string> parameters)
    {
        if (Parameters.Count + parameters.Count != RequiredParameters)
            throw new ArgumentOutOfRangeException(nameof(parameters));

        Parameters.AddRange(parameters);

        return this;
    }
    public DiscordApiEndpoint AddParameters(params string[] parameters) => AddParameters(parameters.ToList());

    public Uri Build()
    {
        if (Parameters.Count != RequiredParameters)
            throw new InvalidOperationException($"Missing required parameters. Given: {Parameters.Count}, expected: {RequiredParameters}");

        var endpoint = new Uri(BaseUri, Endpoint);
        var parameters = string.Join("/", Parameters);
        var complete = $"{endpoint.ToString().TrimEnd('/')}/{parameters.Trim('/')}";

        return new Uri(complete.TrimEnd('/'));
    }

    internal DiscordApiEndpoint(string endpoint, ushort requiredParameters = 0, byte version = 10)
    {
        Endpoint = new Uri(endpoint, UriKind.Relative);
        Version = version;
        RequiredParameters = requiredParameters;
    }

    public static implicit operator Uri(DiscordApiEndpoint endpoint) => endpoint.Build();
}