using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tib.Api.CryptedService
{
    public class BaseCryptedServiceResponse : BaseServiceResponse
    {
        private byte[] CryptedSelf { get; set; }
        private byte[] IV { get; set; }
    }
}
