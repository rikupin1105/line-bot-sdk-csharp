namespace LineMessagingAPI.Webhook
{
    public class ImageSet
    {
        public string Id { get; set; }
        public int Index { get; set; }
        public int Total { get; set; }

        public ImageSet(string id, int index, int total)
        {
            Id = id;
            Index = index;
            Total = total;
        }
    }
}
