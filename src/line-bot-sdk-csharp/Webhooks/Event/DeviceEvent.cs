namespace LineMessagingAPI.Webhooks
{
    public abstract class DeviceEvent : WebhookEvent
    {
        public Things Things { get; }
        public DeviceEvent(WebhookEventSource source, long timestamp, Things things, string mode, string webhookEventId, DeliveryContext deliveryContext)
            : base(WebhookEventType.Things, source, timestamp, mode, webhookEventId, deliveryContext)
        {
            Things = things;
        }

        public static DeviceEvent Create(WebhookEventSource source, long timestamp, Things things, string mode, string webhookEventId, DeliveryContext deliveryContext)
        {
            return (things.Type == ThingsType.Link)
                ? new DeviceLinkEvent(source, timestamp, things, mode, webhookEventId, deliveryContext) as DeviceEvent
                : new DeviceUnlinkEvent(source, timestamp, things, mode, webhookEventId, deliveryContext) as DeviceEvent;
        }
    }

}
