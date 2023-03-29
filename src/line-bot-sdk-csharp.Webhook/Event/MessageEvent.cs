using LineMessagingAPI.Webhook;

namespace LineMessagingAPI.Webhook.Event
{
    /// <summary>
    /// Event object which contains the sent message. The message field contains a message object which corresponds with the message type. You can reply to message events.
    /// </summary>
    public class MessageEvent : ReplyableEvent
    {
        /// <summary>
        /// Contents of the message
        /// </summary>
        public EventMessage Message { get; }

        public MessageEvent(WebhookEventSource source, long timestamp, EventMessage message, string replyToken, string mode, string webhookEventId, DeliveryContext deliveryContext)
            : base(WebhookEventType.Message, source, timestamp, replyToken, mode, webhookEventId, deliveryContext)
        {
            Message = message;
        }
    }
}
