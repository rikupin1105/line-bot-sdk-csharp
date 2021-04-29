namespace LineMessagingAPI
{
    public class Emoji
    {
        public Emoji(int index,int length,string productId,string emojiId)
        {
            Index = index;
            Length = length;
            ProductId = productId;
            EmojiId = emojiId;
        }
        public int Index { get; set; }
        public int Length { get; set; }
        public string ProductId { get; set; }
        public string EmojiId { get; set; }
    }
}
