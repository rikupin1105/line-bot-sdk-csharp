namespace LineMessagingAPI.Webhook
{
    public class DeliveryContext
    {
        public DeliveryContext(bool isRedelivery)
        {
            IsRedelivery = isRedelivery;
        }
        public bool IsRedelivery { get; }
    }
}
