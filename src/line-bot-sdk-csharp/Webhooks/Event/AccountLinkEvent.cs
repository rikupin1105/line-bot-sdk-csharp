namespace LineMessagingAPI.Webhooks
{
    /// <summary>
    /// Event object for when a user has linked his/her LINE account with a provider's service account. You can reply to account link events.
    /// If the link token has expired or has already been used, no webhook event will be sent and the user will be shown an error.
    /// </summary>
    public class AccountLinkEvent : ReplyableEvent
    {
        /// <summary>
        /// Link Object
        /// </summary>
        public Link Link { get; }

        public AccountLinkEvent(WebhookEventSource source, long timestamp, string replyToken, Link link, string mode, string webhookEventId, DeliveryContext deliveryContext)
            : base(WebhookEventType.AccountLink, source, timestamp, replyToken, mode, webhookEventId, deliveryContext)
        {
            Link = link;
        }
    }
}
