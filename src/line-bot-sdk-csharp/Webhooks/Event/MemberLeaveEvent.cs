using System.Collections.Generic;

namespace LineMessagingAPI.Webhooks
{
    /// <summary>
    /// Event object for when a user leaves a group or room that the bot is in.
    /// </summary>
    public class MemberLeaveEvent : WebhookEvent
    {
        /// <summary>
        /// User ID of users who left
        /// </summary>
        public Moved Left { get; }

        public MemberLeaveEvent(WebhookEventSource source, long timestamp, IList<WebhookEventSource> members,string mode)
            : base(WebhookEventType.MemberLeft, source, timestamp,mode)
        {
            Left = new Moved(members);
        }
    }


}
