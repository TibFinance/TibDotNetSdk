
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
    /// Indicates the current status of the transfer operation.
    /// </summary>
    /// <value>Read‑only enum (OperationStatusEnum) with values such as PENDING, COMPLETED, FAILED, CANCELED; reflects the final processing outcome of the transfer.</value>
    public int Status { get; set; }

    /// <summary>
    /// Unique identifier of the newly created payment
    /// </summary>
    /// <value>System‑generated GUID (36‑character string), immutable and required for all subsequent payment‑related operations</value>
    public Guid? PaymentId { get; set; }

    /// <summary>
    /// Merchant-defined reference number echoed back from the request.
    /// </summary>
    /// <value></value>
    public string ReferenceNumber { get; set; }

    /// <summary>
    /// Descriptive message with details about the batch item result.
    /// </summary>
    /// <value></value>
    public string Message { get; set; }

    /// <summary>
    /// Original request data echoed back for correlation.
    /// </summary>
    /// <value></value>
    public RequestDataResponse RequestDataResponse { get; set; }

    }
}