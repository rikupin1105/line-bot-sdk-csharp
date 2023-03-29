namespace LineMessagingAPI.Core
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#get-narrowcast-progress-status
    /// </summary>
    public class ProgressNarrowcast
    {
        public string Phase { get; set; }
        public int SuccessCount { get; set; }
        public int FailureCount { get; set; }
        public int TargetCount { get; set; }
        public string FailedDescription { get; set; }
        public int ErrorCode { get; set; }
        public string AccesptedTime { get; set; }
        public string CompletedTime { get; set; }
    }
}
