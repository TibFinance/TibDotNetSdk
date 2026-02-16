
using System;
using System.Collections.Generic;
using Tib.Api.Financial;
using Tib.Api.Common;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the ProcessStatusCheckArgs model.
    /// </summary>
    public class ProcessStatusCheckArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Gets or sets the collection of transaction details associated with the operation.
    /// </summary>
    /// <value>Represents the list of TransactionCommon objects that describe each transaction performed within the operation.</value>
    public List<TransactionIdentity> Transactions { get; set; }

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

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string TransactionsCompressed { get; set; }

    }
}