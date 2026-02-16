
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.FreeModeOperation
{
    /// <summary>
    /// Represents the CreateDirectInteracTransactionResponse model.
    /// </summary>
    public class CreateDirectInteracTransactionResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Identifies the specific transfer operation that needs to be reverted.
    /// </summary>
    /// <value>This identifier is used to specify which failed transfer operation should be targeted for a retry process.</value>
    public Guid TransferId { get; set; }

    }
}