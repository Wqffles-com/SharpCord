using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using SharpCord.Core;

namespace SharpCord.Rest.Entities;

[PublicAPI]
public class RestUser : IRestEntity, IUser
{
    /// <inheritdoc/>
    public required ulong Id { get; set; }
    /// <inheritdoc/>
    public required string Username { get; set; }
    /// <inheritdoc/>
    public required string Discriminator { get; set; }

    /// <inheritdoc/>
    [field: MaybeNull]
    public string GlobalName
    {
        get => field ?? Username;
        set;
    }

    /// <inheritdoc/>
    public required string? Avatar { get; set; }
    /// <inheritdoc/>
    public required bool Bot { get; set; }
    /// <inheritdoc/>
    public required bool System { get; set; }
    /// <inheritdoc/>
    public required bool MfaEnabled { get; set; }
    /// <inheritdoc/>
    public required string? Banner { get; set; }
    /// <inheritdoc/>
    public required int? AccentColor { get; set; }
    /// <inheritdoc/>
    public required string Locale { get; set; } = "en-US";
    /// <inheritdoc/>
    public required bool EmailVerified { get; set; }
    /// <inheritdoc/>
    public required string? Email { get; set; }
    /// <inheritdoc/>
    [JsonPropertyName("flags")]
    public required int FlagsRaw { get; set; }
    /// <inheritdoc/>
    public required PremiumType PremiumType { get; set; }
    /// <inheritdoc/>
    [JsonPropertyName("public_flags")]
    public required int PublicFlagsRaw { get; set; }
}