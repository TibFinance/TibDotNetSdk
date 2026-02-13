
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Common
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ProcessWebHookResponse 
    {
        
    /// <summary>
    /// Represents the unique identifier for the boarding information of a merchant. This ID is crucial for tracking and referencing the boarding status within the system.
    /// </summary>
    /// <value>This property holds a GUID that uniquely identifies the boarding information associated with a merchant.</value>
    public Guid BoardingInformationId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string TransactionType { get; set; }

    /// <summary>
    /// Represents the status of the merchant boarding process within the system. This status is crucial for tracking the progress and completion of merchant onboarding.
    /// </summary>
    /// <value>The BoardingStatus does not require additional input parameters and is utilized within the standard API call structure to determine the current state of merchant onboarding.</value>
    public BoardingStatusEnum BoardingStatus { get; set; }

    }
}