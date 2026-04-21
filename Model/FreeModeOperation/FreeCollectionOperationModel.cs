
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Financial;
using Tib.Api.Model.FreeModeOperation;

namespace Tib.Api.Model.FreeModeOperation
{
    /// <summary>
    /// Represents the FreeCollectionOperationModel model.
    /// </summary>
    public class FreeCollectionOperationModel 
    {
        
    /// <summary>
    /// Reference identifier for the operation type.
    /// </summary>
    /// <value></value>
    public string OperationTypeRef { get; set; }

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
    /// Identifier of the entity in the target financial system.
    /// </summary>
    /// <value></value>
    public Guid TargetSystemId { get; set; }

    /// <summary>
    /// A list of transfer records returned by the ListTransfers call.
    /// </summary>
    /// <value>Contains zero or more TransactionCommon objects, ordered by most recent transfer first; each object includes the standard transaction fields (id, amount, currency, status, timestamps, etc.). The list size respects the request's pagination limits and may be empty if no transfers match the query.</value>
    public List<TransactionCommon> Transactions { get; set; }

    /// <summary>
    /// Child collection operations in the hierarchy.
    /// </summary>
    /// <value></value>
    public List<FreeCollectionWithHierarchyModel> FreeCollectionList { get; set; }

    }
}