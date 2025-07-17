using JetBrains.Annotations;

namespace SharpCord.Core.Types.Enums;

[PublicAPI]
public enum NsfwLevel
{
    Default,
    Explicit,
    Safe,
    AgeRestricted
}