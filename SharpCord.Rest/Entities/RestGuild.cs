using JetBrains.Annotations;
using SharpCord.Core;

namespace SharpCord.Rest.Entities;

[PublicAPI]
public class RestGuild : IGuild, IRestEntity
{
    /// <inheritdoc/>
    public required ulong Id { get; set; }
    /// <inheritdoc/>
    public required string Name { get; set; }
    /// <inheritdoc/>
    public string? Icon { get; set; }
    /// <inheritdoc/>
    public required string? IconHash { get; set; }
    /// <inheritdoc/>
    public required string? SplashHash { get; set; }
    /// <inheritdoc/>
    public required string? DiscoverySplashHash { get; set; }

    /// <inheritdoc/>
    public required ulong OwnerId { get; set; }
    /// <inheritdoc/>
    public required ulong? AfkChannelId { get; set; }
    /// <inheritdoc/>
    public required int AfkTimeout { get; set; }
    /// <inheritdoc/>
    public required bool WidgetEnabled { get; set; }
    /// <inheritdoc/>
    public required ulong? WidgetChannelId { get; set; }
    /// <inheritdoc/>
    public required GuildVerificationLevel VerificationLevel { get; set; }
    /// <inheritdoc/>
    public required MessageNotificationLevel DefaultMessageNotificationLevel { get; set; }
    /// <inheritdoc/>
    public required ExplicitContentFilterLevel ExplicitContentFilter { get; set; }

    /// <inheritdoc/>
    public required List<string> Features { get; set; } = [];
    /// <inheritdoc/>
    public required MfaLevel MfaLevel { get; set; }
    /// <inheritdoc/>
    public required ulong? ApplicationId { get; set; }
    /// <inheritdoc/>
    public required ulong? SystemChannelId { get; set; }
    /// <inheritdoc/>
    public required int SystemChannelFlagsRaw { get; set; }

    /// <inheritdoc/>
    public required ulong? RulesChannelId { get; set; }
    /// <inheritdoc/>
    public required int? MaxPresences { get; set; }
    /// <inheritdoc/>
    public required int MaxMembers { get; set; }
    /// <inheritdoc/>
    public required string? VanityUrl { get; set; }
    /// <inheritdoc/>
    public required string? Description { get; set; }

    /// <inheritdoc/>
    public required string? BannerHash { get; set; }
    /// <inheritdoc/>
    public required byte BoostLevel { get; set; }
    /// <inheritdoc/>
    public required int Boosts { get; set; }
    /// <inheritdoc/>
    public required string PreferredLocale { get; set; } = "en-US";
    /// <inheritdoc/>
    public required ulong? PublicUpdatesChannelId { get; set; }
    /// <inheritdoc/>
    public required int MaxVideoChannelUsers { get; set; }
    /// <inheritdoc/>
    public required int MaxStageVideoChannelUsers { get; set; }
    /// <inheritdoc/>
    public required int? ApproximateMemberCount { get; set; }
    /// <inheritdoc/>
    public required int ApproximatePresenceCount { get; set; }
    /// <inheritdoc/>
    public required NsfwLevel NsfwLevel { get; set; }

    /// <inheritdoc/>
    public required bool PremiumProgressBarEnabled { get; set; }
    /// <inheritdoc/>
    public required ulong? SafetyAlertsChannelId { get; set; }
}