
using System;
using Tib.Api.Model.Payment;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the PaymentBaseWithHierarchyModel model.
    /// </summary>
    public class PaymentBaseWithHierarchyModel : PaymentModelBase
    {
        
    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Retrieves or assigns the service's name.
    /// </summary>
    /// <value>This property holds the name of the service, which is crucial for identifying and managing the service within the TIB Finance system.</value>
    public string ServiceName { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Identifier of the merchant in an external system
    /// </summary>
    /// <value>A string that uniquely identifies the merchant within an external system.</value>
    public string MerchantExternalSystemId { get; set; }

    /// <summary>
    /// Identifier of the merchant's external system group.
    /// </summary>
    /// <value>A string that uniquely identifies the external system group associated with the merchant. It is required when linking the merchant to third‑party platforms.</value>
    public string MerchantExternalSystemGroupId { get; set; }

    /// <summary>
    /// Represents the merchant's unique name.
    /// </summary>
    /// <value>This property holds a string value that uniquely identifies the merchant by name.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// Gets a value indicating whether the merchant is overloaded.
    /// </summary>
    /// <value>True when the merchant has exceeded its allowed limits; otherwise false.</value>
    public bool? IsOverlodedMerchant { get; set; }

    }
}