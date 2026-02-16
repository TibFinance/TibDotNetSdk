
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the GetTransactionsByProviderTransactionGroupIdArgs model.
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