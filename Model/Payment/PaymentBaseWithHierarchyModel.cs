
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
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// The name of the service that processed the transfer
    /// </summary>
    /// <value>String, non‑empty, max length 64 characters; reflects the internal service identifier returned in the ListTransfers response</value>
    public string ServiceName { get; set; }

    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// The external system identifier assigned to the merchant.
    /// </summary>
    /// <value>String, unique per merchant, may be null if not configured; max length 64 characters, alphanumeric with optional hyphens/underscores.</value>
    public string MerchantExternalSystemId { get; set; }

    /// <summary>
    /// Identifier of the merchant's external system group associated with the transfer
    /// </summary>
    /// <value>String, typically a UUID or alphanumeric code; may be null if the transfer is not linked to an external system group; max length 36 characters</value>
    public string MerchantExternalSystemGroupId { get; set; }

    /// <summary>
    /// The name of the merchant associated with the transfer.
    /// </summary>
    /// <value>String, up to 100 characters; may be empty or null if the transfer has no merchant context.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// True when the fees for this payment are billed to a merchant the caller owns, under a fee-redirection configuration. Computed on GetPayment and GetSupplierTransfer; null on list endpoints.
    /// </summary>
    public bool? IsOverlodedMerchant { get; set; }

    /// <summary>
    /// Identifier of the merchant that pays for this transfer, when fee billing differs from the related merchant. Populated on GetPayment and GetSupplierTransfer; null on list endpoints. When null, the transfer's related merchant pays.
    /// </summary>
    public Guid? FeeMerchantId { get; set; }

    /// <summary>
    /// True when the caller is the fee-paying side of a supplier transfer — the caller does not own the transfer, but owns the merchant billed for it. Always false on ListTransfers, which does not compute it.
    /// </summary>
    public bool IsPayerView { get; set; }

    }
}