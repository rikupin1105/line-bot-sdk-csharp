namespace LineMessagingAPI
{
    /// <summary>
    /// Sender.
    /// </summary>
    public class MessageSender
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// IconUrl
        /// </summary>
        public string IconUrl { get; set; }

        public MessageSender(string name = null, string iconUrl = null)
        {
            Name = name;
            IconUrl = iconUrl;
        }
    }
}

