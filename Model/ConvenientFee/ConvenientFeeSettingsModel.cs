
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.ConvenientFee
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ConvenientFeeSettingsModel 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? ConvenientFeeSettingId { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal Percentage { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal MinAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal MaxAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal FixedAmount { get; set; }

    /// <summary>
    /// Identifies the type of payment method linked to a specific account.
    /// </summary>
    /// <value>A unique identifier representing the type of the payment method.</value>
    public int PaymentMethodType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid TargetMerchantId { get; set; }

    /// <summary>
    /// Represents the current state of a transaction within the system.
    /// </summary>
    /// <value>The Status integer indicates the progress or outcome of a transaction, providing essential information for error handling and process monitoring.</value>
    public ConvenientFeeSettingStatusEnum Status { get; set; }

    }
}