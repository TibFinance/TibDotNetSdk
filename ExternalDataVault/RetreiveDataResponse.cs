
using System;
using Tib.Api.Common;

namespace Tib.Api.ExternalDataVault
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class RetreiveDataResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the data crypted base64.
    /// </summary>
    /// <value>The data crypted base64.</value>
    public string DataCryptedBase64 { get; set; }

    }
}