namespace LineMessagingAPI.Webhook
{
    /// <summary>
    /// Content provider of media message
    /// </summary>
    public class ContentProvider
    {
        /// <summary>
        /// Content Provider Type
        /// </summary>
        public ContentProviderType Type { get; }

        /// <summary>
        /// URL of the media file. Only included when contentProvider.type is external.
        /// </summary>
        public string OriginalContentUrl { get; }

        /// <summary>
        /// URL of the preview image. Only included when contentProvider.type is external.
        /// </summary>
        public string PreviewImageUrl { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="originalContentUrl"></param>
        /// <param name="previewImageUrl"></param>
        public ContentProvider(ContentProviderType type, string originalContentUrl = null, string previewImageUrl = null)
        {
            Type = type;
            OriginalContentUrl = originalContentUrl;
            PreviewImageUrl = previewImageUrl;
        }
    }
}
