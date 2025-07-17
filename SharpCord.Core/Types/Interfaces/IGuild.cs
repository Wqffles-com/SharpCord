using System.Text.Json.Serialization;
using JetBrains.Annotations;
using SharpCord.Core.Types.Enums;

namespace SharpCord.Core.Types.Interfaces;

/// <summary>
/// Represents a Discord guild.
/// </summary>
[PublicAPI]
public interface IGuild : IHasSnowflake
{
    /// <summary>
    /// guild name (2-100 characters, excluding trailing and leading whitespace)
    /// </summary>
    public string Name { get; }
    /// <summary>
    /// icon hash
    /// </summary>
    public string? Icon { get; }
    /// <summary>
    /// icon hash, returned when in the template object
    /// </summary>
    public string? IconHash { get; }
    /// <summary>
    /// splash hash
    /// </summary>
    public string? SplashHash { get; }
    /// <summary>
    /// discovery splash hash; only present for guilds with the "DISCOVERABLE" feature
    /// </summary>
    public string? DiscoverySplashHash { get; }
    /// id of owner
    public ulong OwnerId { get; }
    /// <summary>
    /// id of afk channel
    /// </summary>
    public ulong? AfkChannelId { get; }
    /// <summary>
    /// afk timeout in seconds
    /// </summary>
    public int AfkTimeout { get; }
    /// <summary>
    /// true if the server widget is enabled
    /// </summary>
    public bool WidgetEnabled { get; }
    /// <summary>
    /// the channel id that the widget will generate an invite to, or null if set to no invite
    /// </summary>
    public ulong? WidgetChannelId { get; }
    /// <summary>
    /// verification level required for the guild
    /// </summary>
    public GuildVerificationLevel VerificationLevel { get; }
    /// <summary>
    /// The guild's default message notification level.
    /// </summary>
    public MessageNotificationLevel DefaultMessageNotificationLevel { get; }
    /// <summary>
    ///	explicit content filter level
    /// </summary>
    public ExplicitContentFilterLevel ExplicitContentFilter { get; }
    //TODO: Roles
    //TODO: Emojis
    /// <summary>
    /// enabled guild features
    /// </summary>
    public List<string> Features { get; }
    /// <summary>
    /// required MFA level for the guild
    /// </summary>
    public MfaLevel MfaLevel { get; }
    /// <summary>
    /// application id of the guild creator if it is bot-created
    /// </summary>
    public ulong? ApplicationId { get; }
    /// <summary>
    /// the id of the channel where guild notices such as welcome messages and boost events are posted
    /// </summary>
    public ulong? SystemChannelId { get; }
    /// <summary>
    /// system channel flags
    /// </summary>
    [JsonPropertyName("system_channel_flags")]
    public int SystemChannelFlagsRaw { get; }
    /// <summary>
    /// the id of the channel where Community guilds can display rules and/or guidelines
    /// </summary>
    public ulong? RulesChannelId { get; }
    /// <summary>
    /// the maximum number of presences for the guild (null is always returned, apart from the largest of guilds)
    /// </summary>
    public int? MaxPresences { get; }
    /// <summary>
    ///	the maximum number of members for the guild
    /// </summary>
    public int MaxMembers { get; }
    /// <summary>
    /// the vanity url code for the guild
    /// </summary>
    [JsonPropertyName("vanity_url_code")]
    public string? VanityUrl { get; }
    /// <summary>
    /// the description of a guild
    /// </summary>
    public string? Description { get; }
    /// <summary>
    /// banner hash
    /// </summary>
    [JsonPropertyName("banner")]
    public string? BannerHash { get; }
    /// <summary>
    /// premium tier (Server Boost level)
    /// </summary>
    public byte BoostLevel { get; }
    /// <summary>
    ///	the number of boosts this guild currently has
    /// </summary>
    public int Boosts { get; }
    /// <summary>
    /// the preferred locale of a Community guild; used in server discovery and notices from Discord, and sent in interactions; defaults to "en-US"
    /// </summary>
    public string PreferredLocale { get; }
    /// <summary>
    ///	the id of the channel where admins and moderators of Community guilds receive notices from Discord
    /// </summary>
    public ulong? PublicUpdatesChannelId { get; }
    /// <summary>
    /// the maximum amount of users in a video channel
    /// </summary>
    public int MaxVideoChannelUsers { get; }
    /// <summary>
    /// the maximum amount of users in a stage video channel
    /// </summary>
    public int MaxStageVideoChannelUsers { get; }
    /// <summary>
    /// approximate number of members in this guild, returned from the GET /guilds/{id} and /users/@me/guilds endpoints when with_counts is true
    /// </summary>
    public int? ApproximateMemberCount { get; }
    /// <summary>
    /// approximate number of non-offline members in this guild, returned from the GET /guilds/{id} and /users/@me/guilds endpoints when with_counts is true
    /// </summary>
    public int ApproximatePresenceCount { get; }
    //TODO: Welcome Screen
    /// <summary>
    /// guild NSFW level
    /// </summary>
    public NsfwLevel NsfwLevel { get; }
    //TODO: Stickers
    /// <summary>
    /// whether the guild has the boost progress bar enabled
    /// </summary>
    public bool PremiumProgressBarEnabled { get; }
    /// <summary>
    /// the id of the channel where admins and moderators of Community guilds receive safety alerts from Discord
    /// </summary>
    public ulong? SafetyAlertsChannelId { get; }
    //TODO: Incidents Data
}