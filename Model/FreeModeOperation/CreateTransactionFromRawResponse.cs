
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.FreeModeOperation
{
    /// <summary>
    /// Represents the CreateTransactionFromRawResponse model.
    /// </summary>
    public class CreateTransactionFromRawResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Retrieves or assigns the identifier for a group of transactions.
    /// </summary>
    /// <value>Represents the unique identifier for a group of transactions.</value>
    public string TransactionsGroupId { get; set; }

    }
}