
using System;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the SearchClientsMerchantModel model.
    /// </summary>
    public class SearchClientsMerchantModel 
    {
        
    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid? ClientId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ClientName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? ClientIsDeleted { get; set; }

    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid? ServiceId { get; set; }

    /// <summary>
    /// Retrieves or assigns the service's name.
    /// </summary>
    /// <value>This property holds the name of the service, which is crucial for identifying and managing the service within the TIB Finance system.</value>
    public string ServiceName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? ServiceIsDeleted { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Represents the merchant's unique name.
    /// </summary>
    /// <value>This property holds a string value that uniquely identifies the merchant by name.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? MerchantIsDeleted { get; set; }

    }
}