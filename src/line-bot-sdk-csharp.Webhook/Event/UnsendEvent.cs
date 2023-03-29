namespace LineMessagingAPI.Webhook.Event
{
    /// <summary>
    /// Event object which contains the sent message. The message field contains a message object which corresponds with the message type. You can reply to message events.
    /// </summary>
    public class UnsendEvent : WebhookEvent
    {
        public Unsend Unsend;

        public UnsendEvent(WebhookEventSource source, long timestamp, string mode, Unsend unsend, string webhookEventId, DeliveryContext deliveryContext) : base(WebhookEventType.Unsend, source, timestamp, mode, webhookEventId, deliveryContext)
        {
            Unsend = unsend;
        }
    }
    public class Unsend
    {
        public Unsend(string messageId)
        {
            MessageId = messageId;
        }
        public string MessageId { get; }
    }
}
