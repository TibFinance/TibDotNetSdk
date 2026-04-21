
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the AdjustWalletArgs model.
    /// </summary>
    public class AdjustWalletArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// The monetary value of each recurring transfer.
    /// </summary>
    /// <value>Decimal amount in the account's currency, expressed with up to 2 decimal places; must be greater than zero.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// Specifies the type of wallet adjustment to perform
    /// </summary>
    /// <value>Accepts a WalletAdjustmentEnum value (e.g., Deposit, Withdrawal, Transfer); determines how the wallet balance is modified and must be a valid enum member for the request</value>
    public WalletAdjustmentEnum Mode { get; set; }

    /// <summary>
    /// Specifies whether the wallet adjustment should be processed via Interac.
    /// </summary>
    /// <value>Boolean; true enables Interac transfer (available only for Canadian accounts), false uses the default funding method. Must be set before the adjustment request; defaults to false.</value>
    public bool UseInterac { get; set; }

    }
}