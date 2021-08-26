using System;

namespace LineMessagingAPI
{
    /// <summary>
    /// When sending a message from the LINE Official Account, you can specify the sender.name and the sender.iconUrl properties in Message objects.
    /// </summary>
    public class Sender
    {
        /// <summary>
        /// Display name. Certain words such as LINE may not be used. (Max: 20 character)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// URL of the image to display as an icon when sending a message
        /// HTTPS
        /// PNG
        /// 1:1
        /// 1MB
        /// </summary>
        public string IconUrl { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">
        /// Display name. Certain words such as LINE may not be used. (Max: 20 characters)
        /// </param>
        /// <param name="iconUrl">
        /// URL of the image to display as an icon when sending a message. (Max: 1000 characters)
        /// HTTPS
        /// PNG
        /// 1:1
        /// 1MB
        /// </param>
        public Sender(string name = null, string iconUrl = null)
        {
            Name = name.Substring(0, Math.Min(name.Length, 20));
            IconUrl = iconUrl;
        }
    }
}

