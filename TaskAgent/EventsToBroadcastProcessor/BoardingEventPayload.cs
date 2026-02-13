
using System;
using Tib.Api.TaskAgent.EventsToBroadcastProcessor;

namespace Tib.Api.TaskAgent.EventsToBroadcastProcessor
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BoardingEventPayload : BaseEventPayload
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Represents the status of the merchant boarding process within the system. This status is crucial for tracking the progress and completion of merchant onboarding.
    /// </summary>
    /// <value>The BoardingStatus does not require additional input parameters and is utilized within the standard API call structure to determine the current state of merchant onboarding.</value>
    public string BoardingStatus { get; set; }

    }
}