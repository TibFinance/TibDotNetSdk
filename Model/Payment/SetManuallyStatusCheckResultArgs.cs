
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the SetManuallyStatusCheckResultArgs model.
    /// </summary>
    public class SetManuallyStatusCheckResultArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Gets or sets the transaction identifier.
    /// </summary>
    /// <value>The transaction identifier.</value>
    public Guid TransactionId { get; set; }

    /// <summary>
    /// Retrieves the numeric status code of an operation.
    /// </summary>
    /// <value>The property holds an integer that identifies the current status of the operation.</value>
    public OperationStatusEnum OperationStatus { get; set; }

    }
}