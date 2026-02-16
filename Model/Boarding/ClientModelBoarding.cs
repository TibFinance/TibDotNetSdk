
using System;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the ClientModelBoarding model.
    /// </summary>
    public class ClientModelBoarding 
    {
        
    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid ClientId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ClientName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ClientEmail { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ClientPhone { get; set; }

    }
}