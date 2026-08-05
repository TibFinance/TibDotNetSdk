
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
    /// Identifier of the transaction group created from the raw file import.
    /// </summary>
    public string TransactionsGroupId { get; set; }

    }
}