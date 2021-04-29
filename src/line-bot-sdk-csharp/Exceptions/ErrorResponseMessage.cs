using System.Collections.Generic;

namespace LineMessagingAPI
{
    /// <summary>
    /// Error returned from LINE Platform
    /// https://developers.line.biz/ja/reference/messaging-api/#error-responses
    /// https://developers.line.biz/en/reference/messaging-api/#error-responses
    /// </summary>
    public class ErrorResponseMessage
    {
        /// <summary>
        /// Summary of the error
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Details of the error
        /// </summary>
        public IList<ErrorDetails> Details { get; set; }

        public override string ToString()
        {
            return (Details == null) ? Message : $"{Message},[{string.Join(",", Details)}]";
        }

        /// <summary>
        /// Details of the error
        /// </summary>
        public class ErrorDetails
        {
            /// <summary>
            /// Details of the error
            /// </summary>
            public string Message { get; set; }

            /// <summary>
            /// Location of where the error occurred
            /// </summary>
            public string Property { get; set; }

            public override string ToString()
            {
                return $"{{{Message}, {Property}}}";
            }
        }
    }
}
