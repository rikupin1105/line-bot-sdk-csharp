using LineMessagingAPI.Webhook;

namespace LineMessagingAPI.Webhook.Event
{
    /// <summary>
    /// Indicates that a LINE Things-compatible device has been unlinked from LINE by a user operation. For more information, see Receiving device unlink events via webhook.
    /// </summary>
    public class DeviceUnlinkEvent : DeviceEvent
    {
        public DeviceUnlinkEvent(WebhookEventSource source, long timestamp, Things things, string mode, string webhookEventId, DeliveryContext deliveryContext) : base(source, timestamp, things, mode, webhookEventId, deliveryContext)
        {
        }
    }

}
