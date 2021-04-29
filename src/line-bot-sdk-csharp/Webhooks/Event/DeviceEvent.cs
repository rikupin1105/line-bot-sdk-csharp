namespace LineMessagingAPI.Webhooks
{
    public abstract class DeviceEvent : WebhookEvent
    {
        public Things Things { get; }
        public DeviceEvent(WebhookEventSource source, long timestamp, Things things, string mode)
            : base(WebhookEventType.Things, source, timestamp, mode)
        {
            Things = things;
        }

        public static DeviceEvent Create(WebhookEventSource source, long timestamp, Things things,string mode)
        {
            return (things.Type == ThingsType.Link)
                ? new DeviceLinkEvent(source, timestamp, things,mode) as DeviceEvent
                : new DeviceUnlinkEvent(source, timestamp, things,mode) as DeviceEvent;
        }
    }

}
