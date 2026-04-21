
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Represents the EditionRequest model.
    /// </summary>
    public class EditionRequest 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Content { get; set; }

    /// <summary>
    /// Indicates the current status of the transfer operation.
    /// </summary>
    /// <value>Read‑only enum (OperationStatusEnum) with values such as PENDING, COMPLETED, FAILED, CANCELED; reflects the final processing outcome of the transfer.</value>
    public ContractRequestStatusEnum Status { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CreationDate { get; set; }

    }
}