using JetBrains.Annotations;

namespace SharpCord.Core;

[PublicAPI]
public enum ExplicitContentFilterLevel
{
    /// <summary>
    /// media content will not be scanned
    /// </summary>
    Disabled,
    /// <summary>
    /// media content sent by members without roles will be scanned
    /// </summary>
    MembersWithoutRoles,
    /// <summary>
    /// media content sent by all members will be scanned
    /// </summary>
    AllMembers
}