
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.TransferBatch
{
    /// <summary>
    /// Represents the TransferBatchItemResult model.
    /// </summary>
    public class TransferBatchItemResult 
    {
        
    /// <summary>
    /// The item's 0-based position in Items.
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// The item's ReferenceNumber, at most its first 200 characters.
    /// </summary>
    public string ReferenceNumber { get; set; }

    /// <summary>
    /// What happened to the item. Accepted: in the reply, the item passed every check and is processed in the background; in GetTransferBatchResult, it is not processed yet.
    /// </summary>
    public TransferBatchItemOutcomeEnum Outcome { get; set; }

    /// <summary>
    /// The payment created, or the existing payment when Outcome is AlreadyCreated; empty for every other outcome, Accepted included.
    /// </summary>
    public Guid? PaymentId { get; set; }

    /// <summary>
    /// The customer of the item's CustomerExternalId; empty when no customer was saved or found for the item, such as when customer records are turned off, for a Refused item, a NotProcessed item that was not reached (2151), an AlreadyCreated or Valid item whose customer does not exist yet, and an Accepted item (GetTransferBatchResult gives it with the item's final outcome). Keep the latest value.
    /// </summary>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// What was done with the customer; None for an Accepted item, and for an item whose payment a later attempt found already created (the action was not recorded).
    /// </summary>
    public TransferBatchCustomerActionEnum CustomerAction { get; set; }

    /// <summary>
    /// True when the merchant already used this bank account, with the same numbers and holder name, for an earlier payment. In the reply: as checked when the request was sent. In GetTransferBatchResult: as checked when the item was processed; an item that was not processed (Accepted, NotProcessed 2151, or final in the reply), and an item whose payment a later attempt found already created, carries the value checked when the request was sent. Empty for Interac items, refused items, and items whose processing stopped after their customer was saved (NotProcessed 2135).
    /// </summary>
    public bool? BankAccountKnown { get; set; }

    /// <summary>
    /// Why the item was refused or not processed; 0 otherwise.
    /// </summary>
    public int ErrorCode { get; set; }

    /// <summary>
    /// Why the item was refused or not processed; a refusal names every field that failed. Empty otherwise.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Warnings for customer details that are not saved; a warning never stops the item. An Accepted item carries those found when the request was sent.
    /// </summary>
    public List<int> WarningCodes { get; set; }

    }
}