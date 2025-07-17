using JetBrains.Annotations;

namespace SharpCord.Core.Types.Enums;

[PublicAPI]
public enum GuildVerificationLevel
{
    /// <summary>
    /// unrestricted
    /// </summary>
    None,
    /// <summary>
    /// must have verified email on account
    /// </summary>
    Low,
    /// <summary>
    /// must be registered on Discord for longer than 5 minutes
    /// </summary>
    Medium,
    /// <summary>
    /// must be a member of the server for longer than 10 minutes
    /// </summary>
    High,
    /// <summary>
    /// must have a verified phone number
    /// </summary>
    VeryHigh
}