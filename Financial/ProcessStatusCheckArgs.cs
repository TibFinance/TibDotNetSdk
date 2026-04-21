
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
    /// A list of transfer records returned by the ListTransfers call.
    /// </summary>
    /// <value>Contains zero or more TransactionCommon objects, ordered by most recent transfer first; each object includes the standard transaction fields (id, amount, currency, status, timestamps, etc.). The list size respects the request's pagination limits and may be empty if no transfers match the query.</value>
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