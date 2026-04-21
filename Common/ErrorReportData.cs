
using System;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the ErrorReportData model.
    /// </summary>
    public class ErrorReportData 
    {
        
    /// <summary>
    /// Human‑readable description of the transfer
    /// </summary>
    /// <value>Free‑form UTF‑8 text describing the purpose or details of the transfer; optional, max length 255 characters</value>
    public String Description { get; set; }

    /// <summary>
    /// The display name of the account involved in the transfer.
    /// </summary>
    /// <value>String (max 100 chars); reflects the account's configured name, may include alphanumeric characters and spaces.</value>
    public String AccountName { get; set; }

    /// <summary>
    /// The name of the merchant associated with the transfer.
    /// </summary>
    /// <value>String, up to 100 characters; may be empty or null if the transfer has no merchant context.</value>
    public String MerchantName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public String ErrorDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime ErrorDate2 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime TransactionDate2 { get; set; }

    /// <summary>
    /// The date and time when the recurring transfer was initially created.
    /// </summary>
    /// <value>ISO‑8601 UTC timestamp; always present, immutable, and cannot be null.</value>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// The timestamp when the transfer was executed.
    /// </summary>
    /// <value>ISO‑8601 UTC datetime; present only for completed transfers, null for pending or failed ones.</value>
    public Nullable<DateTime> ExecutedDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public String TransactionDate { get; set; }

    /// <summary>
    /// The monetary value of each recurring transfer.
    /// </summary>
    /// <value>Decimal amount in the account's currency, expressed with up to 2 decimal places; must be greater than zero.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public String Context { get; set; }

    }
}