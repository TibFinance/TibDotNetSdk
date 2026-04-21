
using System;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the BoardingServiceMerchant model.
    /// </summary>
    public class BoardingServiceMerchant 
    {
        
    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Identifier of the boarding information linked to the merchant
    /// </summary>
    /// <value>A valid GUID referencing the merchant's boarding information record; included only when such data exists</value>
    public Guid BoardingInformationId { get; set; }

    /// <summary>
    /// Indicates the current onboarding state of the merchant identified by the external ID
    /// </summary>
    /// <value>String value such as "Pending", "InReview", "Completed" or "Failed"; reflects the merchant's progress through TIB Finance's boarding workflow and is case‑sensitive.</value>
    public string BoardingStatus { get; set; }

    }
}