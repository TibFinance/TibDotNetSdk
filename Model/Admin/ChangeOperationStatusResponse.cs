
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the ChangeOperationStatusResponse model.
    /// </summary>
    public class ChangeOperationStatusResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid OperationId { get; set; }

    /// <summary>
    /// Retrieves the numeric status code of an operation.
    /// </summary>
    /// <value>The property holds an integer that identifies the current status of the operation.</value>
    public int OperationStatus { get; set; }

    }
}