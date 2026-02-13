using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tib.Api.UiModel
{
    public class KeyExchangeUiModel
    {
        public Guid KeyToken { get; set; }
        public string CallNode { get; set; }
        public string AsymetricClientPublicKeyAndClientSymetricXmlBase64 { get; set; }
    }
}
