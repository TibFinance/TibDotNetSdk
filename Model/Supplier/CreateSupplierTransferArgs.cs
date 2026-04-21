
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the CreateSupplierTransferArgs model.
    /// </summary>
    public class CreateSupplierTransferArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// The monetary value of each recurring transfer.
    /// </summary>
    /// <value>Decimal amount in the account's currency, expressed with up to 2 decimal places; must be greater than zero.</value>
    public Decimal Amount { get; set; }

    /// <summary>
    /// Scheduled date for the supplier transfer to be processed.
    /// </summary>
    /// <value></value>
    public DateTime TransferDueDate { get; set; }

    /// <summary>
    /// The merchant receiving the money. Will be null when creating a new supplier.
    /// </summary>
    /// <value></value>
    public Guid TargetMerchantId { get; set; }

    /// <summary>
    /// The ISO 4217 three‑letter code of the currency in which the transfer was executed.
    /// </summary>
    /// <value>One of the supported CurrencyEnum values (e.g., USD, EUR, GBP), always uppercase; matches the currency of the source and destination accounts and is required for all transfer responses.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
    public LanguageEnum Language { get; set; }

    /// <summary>
    /// Specifies how often the payment should be executed.
    /// </summary>
    /// <value>Accepts a TransferFrequencyEnum value (e.g., ONE_TIME, DAILY, WEEKLY, MONTHLY, YEARLY). Required for recurring payments; defaults to ONE_TIME if omitted.</value>
    public TransferFrequencyEnum TransferFrequency { get; set; }

    /// <summary>
    /// End date for a recurring supplier transfer. Null means no end date.
    /// </summary>
    /// <value></value>
    public DateTime? RecurringEndDate { get; set; }

    /// <summary>
    /// Bill number or invoice number associated with this supplier transfer.
    /// </summary>
    /// <value></value>
    public string BillNumber { get; set; }

    /// <summary>
    /// The textual description of the bill associated with the transfer.
    /// </summary>
    /// <value>String, up to 255 characters; may be empty if no bill is linked. Returned as‑is from the originating system and used for display or reconciliation.</value>
    public string BillDescription { get; set; }

    /// <summary>
    /// The title or description of the bill linked to the transfer.
    /// </summary>
    /// <value>String, up to 255 characters; may include alphanumeric characters, spaces, and common punctuation; optional and present only when the transfer is associated with a bill.</value>
    public string BillTitle { get; set; }

    }
}