using System.Collections.Generic;

namespace LineMessagingAPI.Webhook.Event
{
    /// <summary>
    /// Event object for when a user joins a group or room that the bot is in.
    /// </summary>
    public class MemberJoinEvent : ReplyableEvent
    {
        /// <summary>
        /// User ID of users who joined
        /// </summary>
        public Moved Joined { get; }

        public MemberJoinEvent(WebhookEventSource source, long timestamp, string replyToken, IList<WebhookEventSource> members, string mode, string webhookEventId, DeliveryContext deliveryContext)
            : base(WebhookEventType.MemberJoined, source, timestamp, replyToken, mode, webhookEventId, deliveryContext)
        {
            Joined = new Moved(members);
        }
    }

}
