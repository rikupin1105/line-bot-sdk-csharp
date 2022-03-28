using System.Collections.Generic;

namespace LineMessagingAPI
{
    public class VideoComponent : IFlexComponent
    {
        public FlexComponentType Type => FlexComponentType.Video;
        public string Url { get; set; }
        public string PreviewUrl { get; set; }
        public IFlexComponent AltContent { get; set; }
        public string AspectRatio { get; set; }
        public ITemplateAction Action { get; set; }
        public VideoComponent(string url)
        {
            Url = url;
        }
    }
}
