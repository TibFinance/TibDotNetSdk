
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the UpdateBoardingStatusResponse model.
    /// </summary>
    public class UpdateBoardingStatusResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Represents the unique identifier for the boarding information of a merchant. This ID is crucial for tracking and referencing the boarding status within the system.
    /// </summary>
    /// <value>This property holds a GUID that uniquely identifies the boarding information associated with a merchant.</value>
    public Guid BoardingInformationId { get; set; }

    /// <summary>
    /// Represents the current state of a transaction within the system.
    /// </summary>
    /// <value>The Status integer indicates the progress or outcome of a transaction, providing essential information for error handling and process monitoring.</value>
    public string Status { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int StatusCode { get; set; }

    }
}