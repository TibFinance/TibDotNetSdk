using System.Collections.Generic;
using Tib.Api.CryptedService;

namespace Tib.Api.Common
{
    /// <summary>
    ///  the Base Object for Createing Response Objects .
    /// </summary>
    public class ClientBaseResponse
    {

        /// <summary>
        /// List Of Errors Returned by the APi.
        /// </summary>
        public List<BaseServiceError> Errors { get; set; }

        /// <summary>
        /// Boolean that tells if the Call went successfuly or not .
        /// </summary>
        public bool HasError { get; set; }

        /// <summary>
        /// the message that comes with the Error .
        /// </summary>
        public string Messages { get; set; }
        //public string NodeAnswered { get; set; }
    }
}
