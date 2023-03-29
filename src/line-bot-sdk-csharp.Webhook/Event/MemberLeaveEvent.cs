using System.Collections.Generic;

namespace LineMessagingAPI.Webhook.Event
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

        public MemberLeaveEvent(WebhookEventSource source, long timestamp, IList<WebhookEventSource> members, string mode, string webhookEventId, DeliveryContext deliveryContext)
            : base(WebhookEventType.MemberLeft, source, timestamp, mode, webhookEventId, deliveryContext)
        {
            Left = new Moved(members);
        }
    }


}
