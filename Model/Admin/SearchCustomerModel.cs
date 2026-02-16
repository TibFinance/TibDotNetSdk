
using System;
using System.Collections.Generic;
using Tib.Api.Model.Admin;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the SearchCustomerModel model.
    /// </summary>
    public class SearchCustomerModel 
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
    /// 
    /// </summary>
    /// <value></value>
    public List<SearchCustomerRelatedMerchantModel> FoundUpMerchants { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<SearchCustomerRelatedPaymentMethodModel> RelatedPaymentMethods { get; set; }

    /// <summary>
    /// Serves as a unique identifier for each customer within the system.
    /// </summary>
    /// <value>The 'CustomerId' is a unique, non-duplicable identifier that is assigned to each customer upon their creation. It functions as a primary key for all operations related to a specific customer.</value>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// This property represents the full name of the customer in the system.
    /// </summary>
    /// <value>The 'CustomerName' is a string attribute that holds the complete name of the customer as registered in the system.</value>
    public string CustomerName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? IsCustomerDeleted { get; set; }

    }
}