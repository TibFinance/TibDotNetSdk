
using System;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the WalletHolderModel model.
    /// </summary>
    public class WalletHolderModel 
    {
        
    /// <summary>
    /// Unique identifier of the entity that owns the wallet
    /// </summary>
    /// <value>A valid System.Guid; immutable, globally unique across all wallet holders</value>
    public Guid WalletHolderId { get; set; }

    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// The name of the merchant associated with the transfer.
    /// </summary>
    /// <value>String, up to 100 characters; may be empty or null if the transfer has no merchant context.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// The total amount of funds available in the wallet for the requested service.
    /// </summary>
    /// <value>Decimal value representing the balance in the service's base currency; non‑negative, up to 8 decimal places, reflects settled and available funds at query time.</value>
    public decimal Balance { get; set; }

    /// <summary>
    /// Indicates whether the wallet information request is still being processed
    /// </summary>
    /// <value>True = processing, False = processing completed, Null = status unknown or not applicable; may be omitted when null</value>
    public Nullable<bool> IsProcessing { get; set; }

    /// <summary>
    /// Unique identifier of the wallet returned by the service
    /// </summary>
    /// <value>A valid System.Guid; immutable, globally unique across all wallets</value>
    public Guid WalletId { get; set; }

    /// <summary>
    /// The total amount of funds deposited into the wallet for the specified service.
    /// </summary>
    /// <value>Decimal, non‑negative, expressed in the service's currency with up to two fractional digits; reflects confirmed deposits only.</value>
    public decimal DepositAmount { get; set; }

    }
}