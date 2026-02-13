using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tib.Api.CryptedService
{
    public class BaseCryptedServiceArgs : BaseServiceArgs
    {
        private byte[] CryptedSelf { get; set; }
        private Guid? KeyToken { get; set; }
        private byte[] IV { get; set; }
    }
}
