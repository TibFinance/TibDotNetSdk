
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Financial;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the PaymentOperationEntity model.
    /// </summary>
    public class PaymentOperationEntity 
    {
        
    /// <summary>
    /// The monetary value of each recurring transfer.
    /// </summary>
    /// <value>Decimal amount in the account's currency, expressed with up to 2 decimal places; must be greater than zero.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// Currency of the operation (CAD or USD).
    /// </summary>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Specifies the destination entity of the transfer returned by ListTransfers
    /// </summary>
    /// <value>Enum values: ACCOUNT (internal account), WALLET (user wallet), EXTERNAL (outside TIB Finance). Always present; case‑sensitive; used to route subsequent actions.</value>
    public OperationTargetEnum OperationTarget { get; set; }

    /// <summary>
    /// Indicates whether the listed transfer is inbound to or outbound from the queried account
    /// </summary>
    /// <value>Enum TransferDirectionEnum; possible values: INBOUND, OUTBOUND. Read‑only field present in every ListTransfers response item.</value>
    public TransferDirectionEnum OperationDirection { get; set; }

    /// <summary>
    /// Specifies the category of the transfer operation returned by the API
    /// </summary>
    /// <value>One of the OperationKindEnum values (e.g., DEPOSIT, WITHDRAWAL, INTERNAL, EXTERNAL). Always present in the response and limited to the defined enum members.</value>
    public OperationKindEnum OperationKind { get; set; }

    /// <summary>
    /// The date and time when the recurring transfer was initially created.
    /// </summary>
    /// <value>ISO‑8601 UTC timestamp; always present, immutable, and cannot be null.</value>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// The timestamp when the transfer was executed.
    /// </summary>
    /// <value>ISO‑8601 UTC datetime; present only for completed transfers, null for pending or failed ones.</value>
    public DateTime? ExecutedDate { get; set; }

    /// <summary>
    /// A list of transfer records returned by the ListTransfers call.
    /// </summary>
    /// <value>Contains zero or more TransactionCommon objects, ordered by most recent transfer first; each object includes the standard transaction fields (id, amount, currency, status, timestamps, etc.). The list size respects the request's pagination limits and may be empty if no transfers match the query.</value>
    public List<TransactionCommon> Transactions { get; set; }

    /// <summary>
    /// Numeric status code indicating the current state of this operation — the integer value of the TibOperationStatus enum. Note that 0 is NotSet, not success; a successful operation reads 5 (Success).
    /// </summary>
    public TibOperationStatus OperationStatus { get; set; }

    /// <summary>
    /// Display name of the merchant billed for this operation's fees when fee billing has been redirected. Empty when fees are billed normally, and on list endpoints, which do not compute it.
    /// </summary>
    public string OverloadMerchantName { get; set; }

    }
}