
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Model.Admin;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the WalletModel model.
    /// </summary>
    public class WalletModel 
    {
        
    /// <summary>
    /// Unique identifier of the wallet returned by the service
    /// </summary>
    /// <value>A valid System.Guid; immutable, globally unique across all wallets</value>
    public Guid WalletId { get; set; }

    /// <summary>
    /// Indicates the category of reference used to identify the wallet in the response
    /// </summary>
    /// <value>Enum values (e.g., IBAN, INTERNAL_ID, EXTERNAL_REF). Determines which reference field is populated; exactly one value is returned per wallet.</value>
    public ReferenceTypeEnum ReferenceType { get; set; }

    /// <summary>
    /// Unique identifier of the wallet information record returned by the service
    /// </summary>
    /// <value>A GUID that uniquely correlates the response to the request; must be a valid UUID format and remains constant for the lifetime of the record</value>
    public Guid ReferenceId { get; set; }

    /// <summary>
    /// The total amount of funds available in the wallet for the requested service.
    /// </summary>
    /// <value>Decimal value representing the balance in the service's base currency; non‑negative, up to 8 decimal places, reflects settled and available funds at query time.</value>
    public decimal Balance { get; set; }

    /// <summary>
    /// The total amount currently available for withdrawal from the wallet for the requested service.
    /// </summary>
    /// <value>Decimal in the wallet's base currency, excludes pending, locked or reserved funds; may be zero; precision up to the currency's smallest unit.</value>
    public decimal WithdrawableAmount { get; set; }

    /// <summary>
    /// The recurrence pattern that defines when the wallet will be automatically refilled.
    /// </summary>
    /// <value>String representing a schedule (ISO‑8601 repeating interval or cron expression). Empty string if no schedule. Max length 100 characters.</value>
    public string WalletRefillSchedule { get; set; }

    /// <summary>
    /// Indicates whether the wallet information request is still being processed
    /// </summary>
    /// <value>True = processing, False = processing completed, Null = status unknown or not applicable; may be omitted when null</value>
    public bool IsProcessing { get; set; }

    /// <summary>
    /// Specifies the category of the wallet returned in the response
    /// </summary>
    /// <value>Corresponds to WalletTypeEnum (e.g., PERSONAL, CORPORATE, CUSTODIAL, EXTERNAL). Read‑only, always present, and determines applicable features and limits.</value>
    public WalletTypeEnum WalletType { get; set; }

    /// <summary>
    /// A collection of wallet holder records associated with the requested service.
    /// </summary>
    /// <value>List of WalletHolderModel objects, each containing holder identifier, wallet address, balance, and status. May be empty if no holders exist. Order is not guaranteed. Maximum list size is limited by the service's holder count.</value>
    public List<WalletHolderModel> WalletHolders { get; set; }

    /// <summary>
    /// The name of the reference type that categorizes the wallet (e.g., "Customer", "Merchant").
    /// </summary>
    /// <value>String, up to 50 characters, must match one of the platform's predefined reference type names; case‑sensitive and never null.</value>
    public string ReferenceTypeName { get; set; }

    /// <summary>
    /// The display name of the wallet’s type returned by the service.
    /// </summary>
    /// <value>String; matches a predefined wallet type (e.g., "Cash", "Savings"). Case‑sensitive, max length 50 characters, never null.</value>
    public string WalletTypeName { get; set; }

    /// <summary>
    /// The display name of the wallet combination type associated with the wallet.
    /// </summary>
    /// <value>String matching a predefined combination type (e.g., "Standard", "Premium"); max length 50 characters; may be null if not applicable.</value>
    public string WalletCombinationTypeName { get; set; }

    /// <summary>
    /// A textual description of the wallet associated with the service
    /// </summary>
    /// <value>String up to 256 characters; may be empty but never null; reflects the user‑defined label for the wallet</value>
    public string WalletDescription { get; set; }

    /// <summary>
    /// Indicates whether the wallet feature is currently active for the requested service.
    /// </summary>
    /// <value>True means the wallet can be used (transactions, balance queries, etc.); false means the feature is disabled or unavailable. Defaults to false when not explicitly enabled.</value>
    public bool WalletFeatureIsActive { get; set; }

    }
}