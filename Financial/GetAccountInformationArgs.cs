
using System;
using System.Collections.Generic;
using Tib.Api.Financial;
using Tib.Api.Common;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetAccountInformationArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Gets or sets the providers to call.
    /// </summary>
    /// <value>The providers to call.</value>
    public List<ProviderAccount> ProvidersToCall { get; set; }

    }
}