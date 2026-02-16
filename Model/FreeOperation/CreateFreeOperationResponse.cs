
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.FreeOperation
{
    /// <summary>
    /// Represents the CreateFreeOperationResponse model.
    /// </summary>
    public class CreateFreeOperationResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Retrieves or assigns the unique identifier for a payment.
    /// </summary>
    /// <value>Represents the unique identifier associated with a specific payment transaction.</value>
    public Guid PaymentId { get; set; }

    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid? ClientId { get; set; }

    }
}