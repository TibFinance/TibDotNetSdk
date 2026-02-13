
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateSupplierTransferArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public Decimal Amount { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the transfer must be completed.
    /// </summary>
    /// <value>The due date of the transfer represented as a UTC DateTime.</value>
    public DateTime TransferDueDate { get; set; }

    /// <summary>
    /// The merchant receiving the money. Will be null when creating a new supplier.
    /// </summary>
    /// <value></value>
    public Guid TargetMerchantId { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public LanguageEnum Language { get; set; }

    /// <summary>
    /// Defines the frequency at which transfers occur within the TIB Finance API.
    /// </summary>
    /// <value>This enumeration specifies the intervals for executing financial transfers, enabling precise scheduling and management of recurring transactions.</value>
    public TransferFrequencyEnum TransferFrequency { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BillNumber { get; set; }

    /// <summary>
    /// Provides a textual description of the bill associated with a payment.
    /// </summary>
    /// <value>A free‑form string that describes the purpose or details of the bill. The value is stored and returned as‑is.</value>
    public string BillDescription { get; set; }

    /// <summary>
    /// Represents the title of a bill associated with a payment.
    /// </summary>
    /// <value>This property holds the title of the bill. It is used to identify and describe the bill within the system.</value>
    public string BillTitle { get; set; }

    }
}