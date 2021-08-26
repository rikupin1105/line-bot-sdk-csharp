namespace LineMessagingAPI
{
    public class ImageComponent : IFlexComponent
    {
        public FlexComponentType Type => FlexComponentType.Image;

        /// <summary>
        /// image URL (Max: 2000 characters)
        /// HTTPS
        /// JPEG PNG
        /// Max: 1024 x 1024
        /// Max: 10 MB
        /// </summary>
        public string Url { get; set; }
        public int? Flex { get; set; }
        public string Margin { get; set; }
        public Position Position { get; set; }
        public string OffsetTop { get; set; }
        public string OffsetBottom { get; set; }
        public string OffsetStart { get; set; }
        public string OffsetEnd { get; set; }
        public Align? Align { get; set; }
        public Gravity? Gravity { get; set; }
        public string Size { get; set; }
        public string AspectRatio { get; set; }
        public AspectMode? AspectMode { get; set; }
        public string BackgroundColor { get; set; }
        public ITemplateAction Action { get; set; }
        public bool Animated { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="url">
        /// image URL (Max: 2000 characters)
        /// HTTPS
        /// JPEG PNG
        /// Max: 1024 x 1024
        /// Max: 10 MB
        /// </param>
        public ImageComponent(string url)
        {
            Url = url;
        }
        public ImageComponent()
        {

        }

    }
}
