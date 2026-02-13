
using System;
using System.Collections.Generic;
using Tib.Api.Boarding;
using Tib.Api.Financial;
using Tib.Api.Common;

namespace Tib.Api.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class RetrieveDocumentArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Gets or sets the RetrieveDocumentEntity.
    /// </summary>
    /// <value>The RetrieveDocumentEntity.</value>
    public RetrieveDocumentEntity RetrieveDocumentEntity { get; set; }

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