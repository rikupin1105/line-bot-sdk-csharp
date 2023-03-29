using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Core.Exceptions
{
    public class ErrorDetail
    {
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