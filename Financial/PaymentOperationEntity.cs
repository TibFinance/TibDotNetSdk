
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
    /// The ISO 4217 three‑letter code of the currency in which the transfer was executed.
    /// </summary>
    /// <value>One of the supported CurrencyEnum values (e.g., USD, EUR, GBP), always uppercase; matches the currency of the source and destination accounts and is required for all transfer responses.</value>
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
    /// Indicates the result of the ListTransfers request
    /// </summary>
    /// <value>Integer status code where 0 = success; non‑zero values represent specific error conditions as defined in the API error code table.</value>
    public int OperationStatus { get; set; }

    /// <summary>
    /// The merchant name associated with an overload transfer.
    /// </summary>
    /// <value>String, up to 100 characters; may be null when no overload applies.</value>
    public string OverloadMerchantName { get; set; }

    }
}