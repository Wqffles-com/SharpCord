using JetBrains.Annotations;

namespace SharpCord.Core.Types.Interfaces;

/// <summary>
/// Represents any Discord entity that has a snowflake ID.
/// </summary>
[PublicAPI]
public interface IHasSnowflake
{
    /// <summary>
    /// The entity's ID.
    /// </summary>
    public ulong Id { get; set; }
}