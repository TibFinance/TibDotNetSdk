
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the SaveProviderMerchantArgs model.
    /// </summary>
    public class SaveProviderMerchantArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ProviderMerchantId { get; set; }

    /// <summary>
    /// Represents the unique identifier for the boarding information of a merchant. This ID is crucial for tracking and referencing the boarding status within the system.
    /// </summary>
    /// <value>This property holds a GUID that uniquely identifies the boarding information associated with a merchant.</value>
    public Guid BoardingInformationId { get; set; }

    }
}