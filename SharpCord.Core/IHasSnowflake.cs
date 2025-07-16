namespace SharpCord.Core;

/// <summary>
/// Represents any Discord entity that has a snowflake ID.
/// </summary>
public interface IHasSnowflake
{
    /// <summary>
    /// The entity's ID.
    /// </summary>
    public ulong Id { get; set; }
}