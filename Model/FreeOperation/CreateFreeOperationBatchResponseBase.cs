
using System;
using Tib.Api.Model.FreeOperation;

namespace Tib.Api.Model.FreeOperation
{
    /// <summary>
    /// Represents the CreateFreeOperationBatchResponseBase model.
    /// </summary>
    public class CreateFreeOperationBatchResponseBase 
    {
        
    /// <summary>
    /// Represents the current state of a transaction within the system.
    /// </summary>
    /// <value>The Status integer indicates the progress or outcome of a transaction, providing essential information for error handling and process monitoring.</value>
    public int Status { get; set; }

    /// <summary>
    /// Retrieves or assigns the unique identifier for a payment.
    /// </summary>
    /// <value>Represents the unique identifier associated with a specific payment transaction.</value>
    public Guid? PaymentId { get; set; }

    /// <summary>
    /// Retrieves or assigns the reference number associated with a transaction or operation.
    /// </summary>
    /// <value>Represents the unique identifier for tracking and referencing a specific transaction.</value>
    public string ReferenceNumber { get; set; }

    /// <summary>
    /// Represents a textual message within the system, used for communication or logging purposes.
    /// </summary>
    /// <value>The 'Message' type is utilized to convey information, warnings, or errors throughout the application. It serves as a standard format for displaying or recording messages.</value>
    public string Message { get; set; }

    /// <summary>
    /// Represents the response received after a data request operation, encapsulating the details of the requested data.
    /// </summary>
    /// <value>This object is used to convey the results of a data request, including any pertinent information retrieved from the API.</value>
    public RequestDataResponse RequestDataResponse { get; set; }

    }
}