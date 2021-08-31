using System;

namespace LineMessagingAPI
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#location-message
    /// https://developers.line.biz/en/reference/messaging-api/#location-message
    /// </summary>
    public class LocationMessage : ISendMessage
    {
        /// <summary>
        /// Location
        /// </summary>
        public MessageType Type { get; } = MessageType.Location;
        public QuickReply QuickReply { get; set; }
        public Sender Sender { get; set; }

        /// <summary>
        /// Title (Max: 100 characters)
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Address (Max: 100 characters)
        /// </summary>
        public string Address { get; }

        /// <summary>
        /// Latitude
        /// </summary>
        public decimal Latitude { get; }

        /// <summary>
        /// Longitude
        /// </summary>
        public decimal Longitude { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title"></param>
        /// <param name="address"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="quickReply"></param>
        /// <param name="sender"></param>
        public LocationMessage(string title, string address, decimal latitude, decimal longitude, QuickReply quickReply = null, Sender sender = null)
        {
            Title = title.Substring(0, Math.Min(title.Length, 100));
            Address = address.Substring(0, Math.Min(address.Length, 100));
            Latitude = latitude;
            Longitude = longitude;
            QuickReply = quickReply;
            Sender = sender;
        }
    }
}
