
using System;
using System.Collections.Generic;
using Tib.Api.Financial;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the GetTransactionsByProviderTransactionGroupIdResponse model.
    /// </summary>
    public class GetTransactionsByProviderTransactionGroupIdResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the collection of transaction details associated with the operation.
    /// </summary>
    /// <value>Represents the list of TransactionCommon objects that describe each transaction performed within the operation.</value>
    public List<TransactionCommonWithMeta> Transactions { get; set; }

    }
}