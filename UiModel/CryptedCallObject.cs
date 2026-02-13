using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tib.Api.UiModel
{
    public class CryptedCallObject
    {
        public string CallNode { get; set; }
        public Guid KeyToken { get; set; }
        public string Base64IV { get; set; }
        public string Base64CryptedData { get; set; }
    }
}
