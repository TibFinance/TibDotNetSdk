using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tib.Api.UiModel
{
    public class KeyExchangeReturnedKey
    {
        public Guid FullSymetricKeyToken { get; set; }
        public string SymetricHostHalfKey { get; set; }
    }
}
