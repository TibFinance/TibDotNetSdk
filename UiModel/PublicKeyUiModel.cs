using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tib.Api.UiModel
{
    public class PublicKeyUiModel
    {
        public Guid KeyToken { get; set; }
        public string PublicKeyXmlString { get; set; }
        public string PublicPEMKey { get; set; }
        public string NodeAnswered { get; set; }
    }
}
