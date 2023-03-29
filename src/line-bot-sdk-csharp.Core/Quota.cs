namespace LineMessagingAPI.Core
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#get-quota
    /// </summary>
    public class Quota
    {
        /// <summary>
        /// Type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        public int Value { get; set; }
    }
}
