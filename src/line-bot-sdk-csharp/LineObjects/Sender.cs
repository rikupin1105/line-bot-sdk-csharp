using System;

namespace LineMessagingAPI
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#icon-nickname-switch
    /// https://developers.line.biz/en/reference/messaging-api/#icon-nickname-switch
    /// </summary>
    public class Sender
    {
        /// <summary>
        /// Display name. Certain words such as LINE may not be used. (Max: 20 character)
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// URL of the image to display as an icon when sending a message
        /// HTTPS
        /// PNG
        /// 1:1
        /// Date size: 1MB
        /// </summary>
        public string? IconUrl { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="iconUrl"></param>
        public Sender(string? name = null, string? iconUrl = null)
        {
            Name = name?[..Math.Min(name.Length, 20)];
            IconUrl = iconUrl;
        }
    }
}