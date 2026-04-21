
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.DropIn
{
    /// <summary>
    /// Represents the GetDropInPublicTokenArgs model.
    /// </summary>
    public class GetDropInPublicTokenArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Unique identifier of the customer owning the recurring transfers
    /// </summary>
    /// <value>A non‑null GUID that matches an existing customer record; used to correlate transfers with the correct account</value>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// Unique identifier of the bill to be paid
    /// </summary>
    /// <value>Guid referencing an existing, unpaid bill; must be a valid, non‑empty GUID and belong to the requesting account</value>
    public Guid? BillId { get; set; }

    /// <summary>
    /// The monetary value of each recurring transfer.
    /// </summary>
    /// <value>Decimal amount in the account's currency, expressed with up to 2 decimal places; must be greater than zero.</value>
    public Decimal Amount { get; set; }

    /// <summary>
    /// Indicates the category of the recurring transfer (e.g., inbound, outbound, internal).
    /// </summary>
    /// <value>Enum TransferTypeEnum; possible values: INBOUND, OUTBOUND, INTERNAL. Returned in uppercase; null if not applicable.</value>
    public TransferTypeEnum TransferType { get; set; }

    /// <summary>
    /// Restrict which payment methods are available in the Drop-In interface.
    /// </summary>
    /// <value></value>
    public AutorizedPaymentMethodFlags DropInAuthorizedPaymentMethod { get; set; }

    /// <summary>
    /// External system reference number to associate with the Drop-In payment.
    /// </summary>
    /// <value></value>
    public string ExternalReferenceNumber { get; set; }

    /// <summary>
    /// Whether to display the customer's previously saved payment methods in the Drop-In.
    /// </summary>
    /// <value></value>
    public bool ShowCustomerExistingPaymentMethods { get; set; }

    /// <summary>
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
    public LanguageEnum Language { get; set; }

    /// <summary>
    /// Number of days before the Drop-In token expires.
    /// </summary>
    /// <value></value>
    public int ExpirationDays { get; set; }

    /// <summary>
    /// Title displayed on the Drop-In payment form.
    /// </summary>
    /// <value></value>
    public string Title { get; set; }

    /// <summary>
    /// Human‑readable description of the transfer
    /// </summary>
    /// <value>Free‑form UTF‑8 text describing the purpose or details of the transfer; optional, max length 255 characters</value>
    public string Description { get; set; }

    /// <summary>
    /// Scheduled due date for the payment created via Drop-In.
    /// </summary>
    /// <value></value>
    public DateTime? PaymentDueDate { get; set; }

    }
}