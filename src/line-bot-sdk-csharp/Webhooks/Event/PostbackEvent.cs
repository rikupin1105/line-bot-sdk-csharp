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

        public PostbackEvent(WebhookEventSource source, long timestamp, string replyToken, Postback postback,string mode)
            : base(WebhookEventType.Postback, source, timestamp, replyToken, mode)
        {
            Postback = postback;
        }
    }
}
