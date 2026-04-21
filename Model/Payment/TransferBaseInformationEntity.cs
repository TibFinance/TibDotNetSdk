
using System;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the TransferBaseInformationEntity model.
    /// </summary>
    public class TransferBaseInformationEntity 
    {
        
    /// <summary>
    /// Unique identifier of the transfer record
    /// </summary>
    /// <value>A system‑generated GUID; always present, immutable, and used to reference the specific transfer</value>
    public Guid i { get; set; }

    /// <summary>
    /// The timestamp when the transfer was created.
    /// </summary>
    /// <value>ISO‑8601 UTC datetime string; precise to the second; always present in the response.</value>
    public DateTime cdt { get; set; }

    /// <summary>
    /// The timestamp of the transfer
    /// </summary>
    /// <value>ISO‑8601 UTC string indicating when the transfer was created, e.g., "2023-09-15T13:45:30Z"</value>
    public string t { get; set; }

    /// <summary>
    /// Unique integer identifier for the payment
    /// </summary>
    /// <value>System‑generated, non‑negative ID for the transfer; immutable and used to reference this payment in other API calls</value>
    public int pmt { get; set; }

    /// <summary>
    /// Transfer description
    /// </summary>
    /// <value>Free‑form text (string, up to 255 characters) describing the transfer; may be empty</value>
    public string d { get; set; }

    /// <summary>
    /// A human‑readable message or note associated with the transfer
    /// </summary>
    /// <value>String, up to 255 characters; may be empty; returned as‑is from the originating system</value>
    public string m { get; set; }

    /// <summary>
    /// The date and time when the transfer was created.
    /// </summary>
    /// <value>ISO‑8601 formatted UTC timestamp; always present in successful ListTransfersForBillFast responses.</value>
    public DateTime td { get; set; }

    /// <summary>
    /// The monetary amount of the transfer
    /// </summary>
    /// <value>Decimal value representing the transfer amount in the bill's currency, usually with two decimal places and non‑negative</value>
    public decimal a { get; set; }

    /// <summary>
    /// Total number of transfer entries returned
    /// </summary>
    /// <value>Non‑negative integer; reflects the count of items in the response list (max 1000).</value>
    public int s { get; set; }

    /// <summary>
    /// Timestamp of the transfer record
    /// </summary>
    /// <value>Integer Unix epoch time (seconds since 1970‑01‑01 UTC) indicating when the transfer was created</value>
    public int ts { get; set; }

    /// <summary>
    /// Identifier of the clearing/payment system used for the transfer
    /// </summary>
    /// <value>String, up to 10 alphanumeric characters; may be empty if the transfer does not involve a specific CPS</value>
    public string cps { get; set; }

    /// <summary>
    /// Total number of transfers returned by the request
    /// </summary>
    /// <value>Integer ≥ 0; reflects the count of transfer records in the response (may be zero if none match).</value>
    public int c { get; set; }

    /// <summary>
    /// The name of the counterparty involved in the transfer
    /// </summary>
    /// <value>String, up to 100 characters, may be empty if the counterparty is not identified</value>
    public string cn { get; set; }

    /// <summary>
    /// The unique identifier of the cash entry (CEM) associated with the transfer
    /// </summary>
    /// <value>String, up to 35 alphanumeric characters; may be empty if not applicable</value>
    public string cem { get; set; }

    /// <summary>
    /// Globally unique identifier of the transfer record
    /// </summary>
    /// <value>A valid GUID assigned by the system; immutable and used to reference the specific transfer in subsequent API calls</value>
    public Guid cid { get; set; }

    /// <summary>
    /// Unique identifier of the transfer returned by ListTransfersForBillFast
    /// </summary>
    /// <value>String, up to 64 alphanumeric characters; may be empty if the transfer has no assigned ID</value>
    public string trd { get; set; }

    /// <summary>
    /// Identifier of the managing entity for the transfer
    /// </summary>
    /// <value>String, up to 50 characters; may be empty if not applicable</value>
    public string man { get; set; }

    /// <summary>
    /// String identifier of the transfer mapping returned by ListTransfersForBillFast
    /// </summary>
    /// <value>A non‑null alphanumeric string that references the internal map linking the transfer to the bill; maximum length 64 characters.</value>
    public string map { get; set; }

    /// <summary>
    /// The end date and time of the transfer period returned by ListTransfersForBillFast.
    /// </summary>
    /// <value>ISO‑8601 UTC timestamp (e.g., 2023-12-31T23:59:59Z); must be later than the start date (if provided) and defines the inclusive upper bound for the queried transfers.</value>
    public DateTime ed { get; set; }

    /// <summary>
    /// The timestamp indicating when the transfer was completed
    /// </summary>
    /// <value>ISO‑8601 UTC datetime string; always present in the response</value>
    public DateTime ed2 { get; set; }

    /// <summary>
    /// Indicates whether any transfer in the list has an error
    /// </summary>
    /// <value>Boolean; true if at least one transfer returned by ListTransfersForBillFast contains an error, false otherwise. Always present in the response.</value>
    public bool he { get; set; }

    /// <summary>
    /// Indicates if the transfer record is marked as deleted
    /// </summary>
    /// <value>Boolean; true when the transfer has been deleted, false otherwise</value>
    public bool del { get; set; }

    /// <summary>
    /// The total monetary amount collected for the transfer operation.
    /// </summary>
    /// <value>Decimal, expressed in the bill's currency, non‑negative, typically with two fractional digits; reflects the sum actually transferred to the beneficiary.</value>
    public decimal CollectOperationAmount { get; set; }

    /// <summary>
    /// The monetary amount of the deposit operation associated with the BillFast transfer.
    /// </summary>
    /// <value>Decimal value (e.g., 1234.56) representing the transfer amount in the account's currency; must be non‑negative and typically limited to two fractional digits.</value>
    public decimal DepositOperationAmount { get; set; }

    /// <summary>
    /// The fee amount applied to the transfer under the Convenient Fees scheme.
    /// </summary>
    /// <value>Decimal, non‑negative, expressed in the bill's currency with up to two decimal places. Represents the total convenient‑fees charge for the listed transfer; zero if no convenient fees apply.</value>
    public decimal ConvenientFeesOperationAmount { get; set; }

    /// <summary>
    /// The total fee amount applied to the transfer operation.
    /// </summary>
    /// <value>Decimal, non‑negative, expressed in the transaction currency with up to two decimal places; zero when no fees are charged.</value>
    public decimal FeesOperationAmount { get; set; }

    /// <summary>
    /// Indicates the transfer direction relative to the biller
    /// </summary>
    /// <value>0 = outgoing (sent from the account), 1 = incoming (received by the account); only these integer values are returned</value>
    public int Direction { get; set; }

    /// <summary>
    /// Indicates whether the listed transfer has been refunded.
    /// </summary>
    /// <value>True if the transfer was fully refunded, false otherwise; only relevant for completed transfers and may be omitted when no refund occurred.</value>
    public bool Refunded { get; set; }

    /// <summary>
    /// The monetary amount transferred for the BillFast transaction.
    /// </summary>
    /// <value>Decimal (up to 2 decimal places) in the transaction currency; must be non‑negative and not exceed the bill's total amount.</value>
    public decimal TransferAmount { get; set; }

    /// <summary>
    /// Indicates whether the listed transfer is a supplier transfer.
    /// </summary>
    /// <value>Boolean flag returned in ListTransfersForBillFast; true when the transfer is to a supplier (BillFast payment), false otherwise. Always present and read‑only.</value>
    public bool IsSupplierTransfer { get; set; }

    /// <summary>
    /// The payer's custom alias for the supplier (from MerchantSuppliers.SupplierName). Only populated for supplier transfer list endpoints.
    /// </summary>
    /// <value></value>
    public string SupplierAlias { get; set; }

    /// <summary>
    /// The unique external reference number assigned to the transfer
    /// </summary>
    /// <value>String, alphanumeric, up to 64 characters; immutable and used for tracking the transfer in external systems</value>
    public string ern { get; set; }

    }
}