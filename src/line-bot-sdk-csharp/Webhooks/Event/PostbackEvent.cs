namespace LineMessagingAPI.Webhooks
{
    /// <summary>
    /// Event object for when a user performs an action on a template message which initiates a postback. You can reply to postback events.
    /// </summary>
    public class PostbackEvent : ReplyableEvent
    {
        /// <summary>
        /// Postback
        /// </summary>
        public Postback Postback { get; }

        public PostbackEvent(WebhookEventSource source, long timestamp, string replyToken, Postback postback, string mode, string webhookEventId, DeliveryContext deliveryContext)
            : base(WebhookEventType.Postback, source, timestamp, replyToken, mode, webhookEventId, deliveryContext)
        {
            Postback = postback;
        }
    }
}
