
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Gateway.Entities
{
    /// <summary>
    /// Represents the TransferValidationEntity model.
    /// </summary>
    public class TransferValidationEntity 
    {
        
    /// <summary>
    /// The monetary value of each recurring transfer.
    /// </summary>
    /// <value>Decimal amount in the account's currency, expressed with up to 2 decimal places; must be greater than zero.</value>
    public Decimal Amount { get; set; }

    /// <summary>
    /// The date and time when the recurring transfer was initially created.
    /// </summary>
    /// <value>ISO‑8601 UTC timestamp; always present, immutable, and cannot be null.</value>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// Gets or sets the acount number.
    /// </summary>
    /// <value>The acount number.</value>
    public string AcountNumber { get; set; }

    /// <summary>
    /// Gets or sets the external reference number.
    /// </summary>
    /// <value>The external reference number.</value>
    public string ExternalReferenceNumber { get; set; }

    /// <summary>
    /// Identifier of the payment group to which the payment belongs
    /// </summary>
    /// <value>String, required, non‑empty, max 36 characters, must be a valid UUID/GUID if the system uses GUIDs</value>
    public string GroupId { get; set; }

    /// <summary>
    /// Gets or sets the tib authorization.
    /// </summary>
    /// <value>The tib authorization.</value>
    public TibAuthorizationStatus TibAuthorization { get; set; }

    /// <summary>
    /// Gets or sets the tib authorization status string.
    /// </summary>
    /// <value>The tib authorization status string.</value>
    public string TibAuthorizationStatusStr { get; set; }

    /// <summary>
    /// Gets or sets the client authorization.
    /// </summary>
    /// <value>The client authorization.</value>
    public ClientAuthorizationStatus ClientAuthorization { get; set; }

    /// <summary>
    /// Gets or sets the client authorization status string.
    /// </summary>
    /// <value>The client authorization status string.</value>
    public string ClientAuthorizationStatusStr { get; set; }

    /// <summary>
    /// The name of the merchant associated with the transfer.
    /// </summary>
    /// <value>String, up to 100 characters; may be empty or null if the transfer has no merchant context.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// The full name of the customer who owns the recurring transfer.
    /// </summary>
    /// <value>String, up to 100 Unicode characters, may include spaces and hyphens; always present in the response.</value>
    public string CustomerName { get; set; }

    /// <summary>
    /// Specifies the bill identifier to filter transfers associated with that bill
    /// </summary>
    /// <value>String (or numeric) bill ID; must correspond to an existing bill in the system; optional – if omitted, transfers for all bills are returned</value>
    public string Bill { get; set; }

    /// <summary>
    /// Indicates the category of the recurring transfer (e.g., inbound, outbound, internal).
    /// </summary>
    /// <value>Enum TransferTypeEnum; possible values: INBOUND, OUTBOUND, INTERNAL. Returned in uppercase; null if not applicable.</value>
    public string TransferType { get; set; }

    /// <summary>
    /// Unique identifier of the wallet adjustment transaction
    /// </summary>
    /// <value>System‑generated GUID (UUID v4) returned in the response; immutable, required for tracking and correlation of the adjustment</value>
    public Guid TransferId { get; set; }

    /// <summary>
    /// Unique identifier of the customer owning the recurring transfers
    /// </summary>
    /// <value>A non‑null GUID that matches an existing customer record; used to correlate transfers with the correct account</value>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// The date by which the created payment must be settled.
    /// </summary>
    /// <value>ISO‑8601 DateTime (UTC). Must be a future date, not earlier than the current date, and cannot exceed the platform's maximum scheduling horizon.</value>
    public DateTime? DueDate { get; set; }

    }
}