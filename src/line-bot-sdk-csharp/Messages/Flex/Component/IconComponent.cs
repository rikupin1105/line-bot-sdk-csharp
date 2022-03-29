namespace LineMessagingAPI
{
    public class IconComponent : IFlexComponent
    {
        public FlexComponentType Type => FlexComponentType.Icon;

        /// <summary>
        /// image URL(Max: 2000 characters)
        /// HTTPS
        /// JPEG PNG
        /// Max: 1024 x 1024
        /// Max: 1 MB
        /// /// <summary>
        public string Url { get; set; }
        public string Margin { get; set; }
        public Position? Position { get; set; }
        public string OffsetTop { get; set; }
        public string OffsetBottom { get; set; }
        public string OffsetStart { get; set; }
        public string OffsetEnd { get; set; }
        public string Size { get; set; }
        public string AspectRatio { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="url">
        /// image URL(Max: 2000 characters)
        /// HTTPS
        /// JPEG PNG
        /// Max: 1024 x 1024
        /// Max: 1 MB
        /// </param>
        public IconComponent(string url)
        {
            Url = url;
        }
        public IconComponent()
        {

        }
    }
}
