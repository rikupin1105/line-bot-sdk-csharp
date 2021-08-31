namespace LineMessagingAPI
{
    public class Video
    {
        /// <summary>
        /// URL of the video file (Max: 2000 characters)
        /// HTTPS HTTPS over TLS 1.2 or later
        /// mp4
        /// Max file size: 200 MB
        /// Note: A very wide or tall video may be cropped when played in some environments.
        /// </summary>
        public string OriginalContentUrl { get; }

        /// <summary>
        /// URL of the preview image (Max: 2000 characters)
        /// HTTPS over TLS 1.2 or later
        /// JPEN or PNG
        /// Max file size: 1 MB
        /// </summary>
        public string PreviewImageUrl { get; }

        /// <summary>
        /// Imagemap Area
        /// </summary>
        public Area Area { get; }

        /// <summary>
        /// Label. Displayed after the video is finished.
        /// And Webpage URL. Called when the label displayed after the video is tapped.
        /// </summary>
        public ExternalLink ExternalLink { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="originalContentUrl"></param>
        /// <param name="previewImageUrl"></param>
        /// <param name="area"></param>
        /// <param name="externalLink"></param>
        public Video(string originalContentUrl, string previewImageUrl, Area area, ExternalLink externalLink)
        {
            OriginalContentUrl = originalContentUrl;
            PreviewImageUrl = previewImageUrl;
            Area = area;
            ExternalLink = externalLink;
        }
    }
}
