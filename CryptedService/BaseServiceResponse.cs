using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tib.Api.CryptedService
{
    /// <summary>
    /// base Object for TibApi Calls Response.
    /// </summary>
    public class BaseServiceResponse
    {
        /// <summary>
        /// list of errors.
        /// </summary>
        public List<BaseServiceError> Errors { get; }

        /// <summary>
        /// Boolean to tell if the Api Action enconteredan exception.
        /// </summary>
        public bool HasError { get; }

        /// <summary>
        /// Message returned by the Api Exception.
        /// </summary>
        public string Messages { get; }
        //private string NodeAnswered { get; set; }
    }
}
