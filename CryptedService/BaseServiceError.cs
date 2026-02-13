using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tib.Api.CryptedService
{
    public class BaseServiceError
    {
        public string ErrorMessage { get; set; }
        public int ErrorCode { get; set; }
    }
}
