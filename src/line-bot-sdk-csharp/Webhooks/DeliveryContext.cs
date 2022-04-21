namespace LineMessagingAPI
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
