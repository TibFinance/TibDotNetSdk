
using System;
using System.Collections.Generic;
using Tib.Api.Financial;
using Tib.Api.Common;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ProcessTransferArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Gets or sets the transfer informations.
    /// </summary>
    /// <value>The transfer informations.</value>
    public List<ProcessTransferEntity> TransferInformations { get; set; }

    /// <summary>
    /// Gets or sets the mailing information.
    /// </summary>
    /// <value>The mailing information.</value>
    public TransactionMailingInfo MailingInfo { get; set; }

    /// <summary>
    /// Gets or sets the provider credentials.
    /// </summary>
    /// <value>The provider credentials.</value>
    public List<ProviderAccount> ProviderCredentials { get; set; }

    }
}