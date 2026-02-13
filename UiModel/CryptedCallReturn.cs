using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tib.Api.UiModel
{
    public class CryptedCallReturn
    {
        public string CryptedBase64Data { get; set; }
        public byte[] IV { get; set; }
    }
}
