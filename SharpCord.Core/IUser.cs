using System.Text.Json.Serialization;

namespace SharpCord.Core;

/// <summary>
/// Represents a Discord user
/// </summary>
public interface IUser : IHasSnowflake
{
    /// <summary>
    /// the user's username
    /// </summary>
    public string Username { get; }
    /// <summary>
    /// the user's Discord-tag
    /// </summary>
    public string Discriminator { get; }
    /// <summary>
    /// the user's display name, if it is set. For bots, this is the application name
    /// </summary>
    public string? GlobalName { get; }
    /// <summary>
    /// the user's avatar hash
    /// </summary>
    public string? Avatar { get; }
    /// <summary>
    /// whether the user belongs to an OAuth2 application
    /// </summary>
    public bool Bot { get; }
    /// <summary>
    /// whether the user is an Official Discord System user (part of the urgent message system)
    /// </summary>
    public bool System { get; }
    /// <summary>
    /// whether the user has two factor enabled on their account
    /// </summary>
    public bool MfaEnabled { get; }
    /// <summary>
    /// the user's banner hash
    /// </summary>
    public string? Banner { get; }
    /// <summary>
    /// the user's banner color encoded as an integer representation of hexadecimal color code
    /// </summary>
    public int? AccentColor { get; }
    /// <summary>
    /// the user's chosen language option
    /// </summary>
    public string Locale { get; }
    /// <summary>
    /// whether the email on this account has been verified
    /// </summary>
    public bool EmailVerified { get; }
    /// <summary>
    /// the user's email
    /// </summary>
    public string? Email { get; }
    /// <summary>
    /// the flags on a user's account
    /// </summary>
    [JsonPropertyName("flags")]
    public int FlagsRaw { get; }
    /// <summary>
    /// the type of Nitro subscription on a user's account
    /// </summary>
    public PremiumType PremiumType { get; }
    /// <summary>
    /// the public flags on a user's account
    /// </summary>
    [JsonPropertyName("public_flags")]
    public int PublicFlagsRaw { get; }
}