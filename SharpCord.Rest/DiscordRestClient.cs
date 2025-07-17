using System.Net.Http.Headers;
using System.Text.Json;
using JetBrains.Annotations;
using SharpCord.Core.Types.Interfaces;
using SharpCord.Rest.Entities;

namespace SharpCord.Rest;

[PublicAPI]
public class DiscordRestClient : IDisposable, IAsyncDisposable
{
    public static readonly Version Version = typeof(DiscordRestClient).Assembly.GetName().Version!;
    public static string LibraryUrl => "https://github.com/Wqffles-com/SharpCord";

    private readonly HttpClient _client = new();

    public bool LoggedIn { get; set; }
    public IUser? CurrentUser { get; set; }

    public DiscordRestClient()
    {
        _client.DefaultRequestHeaders.Add("User-Agent", $"DiscordBot ({LibraryUrl}, {Version.ToString(3)})");
    }

    public async Task<(bool success, Exception? exception)> TryLoginAsync(string token)
    {
        try
        {
            await LoginAsync(token);

            return (true, null);
        }
        catch (Exception ex)
        {
            return (false, ex);
        }
    }

    public async Task LoginAsync(string token)
    {
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bot", token);
        if (LoggedIn)
            throw new InvalidOperationException("This client is already logged in.");

        CurrentUser = await GetMeAsync();

        LoggedIn = true;
    }

    public async Task<T> GetAsync<T>(DiscordApiEndpoint endpoint)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
        var response = await _client.SendAsync(request);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsAsync<T>() ?? throw new JsonException("Failed to parse JSON.");
    }

    public async Task<(T? result, bool success, Exception? exception)> TryGetAsync<T>(DiscordApiEndpoint endpoint)
    {
        try
        {
            return (await GetAsync<T>(endpoint), true, null);
        }
        catch (Exception ex)
        {
            return (default, false, ex);
        }
    }

    public Task<RestUser> GetMeAsync() => GetAsync<RestUser>(DiscordApiEndpoint.GetSelfUser);

    public Task<(RestUser? entity, bool result, Exception? exception)> TryGetMe() => TryGetAsync<RestUser>(DiscordApiEndpoint.GetSelfUser);

    public Task<RestUser> GetUser(ulong id) => GetAsync<RestUser>(DiscordApiEndpoint.GetUser.WithParameters(id.ToString()));
    public Task<(RestUser? entity, bool result, Exception? exception)> TryGetUser(ulong id) => TryGetAsync<RestUser>(DiscordApiEndpoint.GetUser.WithParameters(id.ToString()));

    public Task<RestGuild> GetGuild(ulong id) => GetAsync<RestGuild>(DiscordApiEndpoint.GetGuild.WithParameters(id.ToString()));
    public Task<(RestGuild? entity, bool result, Exception? exception)> TryGetGuild(ulong id) => TryGetAsync<RestGuild>(DiscordApiEndpoint.GetGuild.WithParameters(id.ToString()));

    public void Dispose()
    {
        _client.Dispose();
    }

    public ValueTask DisposeAsync()
    {
        _client.Dispose();

        return ValueTask.CompletedTask;
    }
}