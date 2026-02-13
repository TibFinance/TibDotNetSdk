
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetTransactionsByProviderTransactionGroupIdArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Gets or sets the provider transaction group identifier.
    /// </summary>
    /// <value>The provider transaction group identifier.</value>
    public string ProviderTransactionGroupId { get; set; }

    }
}