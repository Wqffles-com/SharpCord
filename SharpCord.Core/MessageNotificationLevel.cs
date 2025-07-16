using JetBrains.Annotations;

namespace SharpCord.Core;

[PublicAPI]
public enum MessageNotificationLevel
{
    /// <summary>
    /// members will receive notifications for all messages by default
    /// </summary>
    AllMessages,
    /// <summary>
    /// members will receive notifications only for messages that @mention them by default
    /// </summary>
    OnlyMentions
}