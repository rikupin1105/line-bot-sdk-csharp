namespace LineMessagingAPI.Core
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#get-consumption
    /// https://developers.line.biz/en/reference/messaging-api/#get-consumption
    /// </summary>
    public class Consumption
    {
        /// <summary>
        /// The number of sent messages in the current month
        /// </summary>
        public int TotalUsage { get; set; }
    }
}