using System.Text.Json;
using SharpCord.Rest;
using Xunit.Abstractions;

namespace SharpCord.Tests;

public class RestClientTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public RestClientTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        var config = File.ReadAllText("config.json");
        var parsed = JsonSerializer.Deserialize<JsonDocument>(config)!.RootElement;

        Token = parsed.GetProperty(nameof(Token)).GetString()!;
        AppId = parsed.GetProperty(nameof(AppId)).GetUInt64();
        Config = parsed;
    }

    public string Token { get; }
    public ulong AppId { get; }
    public JsonElement Config { get; }

    [Fact]
    public async Task TestLogin()
    {
        var client = new DiscordRestClient();

        await client.LoginAsync(Token);

        Assert.True(client.LoggedIn);
    }

    [Fact]
    public async Task TestSelfUser()
    {
        var client = new DiscordRestClient();

        await client.LoginAsync(Token);

        Assert.True(client.LoggedIn);
        Assert.Equal(AppId, client.CurrentUser?.Id);
    }

    [Fact]
    public async Task TestGetUser()
    {
        var client = new DiscordRestClient();
        await client.LoginAsync(Token);
        Assert.True(client.LoggedIn);

        var id = Config.GetProperty("UserId").GetUInt64();
        var user = await client.GetUser(id);
        Assert.Equal(id, user.Id);
    }

    [Fact]
    public async Task TestGetGuild()
    {
        var client = new DiscordRestClient();
        await client.LoginAsync(Token);
        Assert.True(client.LoggedIn);

        var id = Config.GetProperty("GuildId").GetUInt64();
        var guild = await client.GetGuild(id);
        Assert.Equal(id, guild.Id);
    }
}