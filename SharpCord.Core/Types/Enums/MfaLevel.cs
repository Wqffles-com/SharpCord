using JetBrains.Annotations;

namespace SharpCord.Core.Types.Enums;

[PublicAPI]
public enum MfaLevel
{
    /// <summary>
    /// guild has no MFA/2FA requirement for moderation actions
    /// </summary>
    None,
    /// <summary>
    /// guild has a 2FA requirement for moderation actions
    /// </summary>
    Elevated
}