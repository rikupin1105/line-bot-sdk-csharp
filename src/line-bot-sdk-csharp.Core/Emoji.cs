namespace LineMessagingAPI.Core
{
    public class Emoji
    {
        public Emoji(int index, string productId, string emojiId)
        {
            Index = index;
            ProductId = productId;
            EmojiId = emojiId;
        }
        /// <summary>
        /// The index position for $ indicating the placeholder for LINE emojis in text, with the first character being at position 0. See the text message example for details.
        /// Note: If you specify a position that doesn't match the position of $, the API returns HTTP 400 Bad request.
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// Product ID for a set of LINE emoji. For more information on product IDs, see List of available LINE emojis.
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// Emoji ID. For more information on emoji IDs for LINE emojis that are sendable with the Messaging API, see List of available LINE emojis.
        /// </summary>
        public string EmojiId { get; set; }
    }
}