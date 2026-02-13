
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ServiceFeeSettingsModel 
    {
        
    /// <summary>
    /// Gets or sets the credit card fee mode applied to transactions.
    /// </summary>
    /// <value>The fee mode defined by the FeeModeEnum, indicating how credit‑card fees are calculated.</value>
    public FeeModeEnum CreditCardFeeMode { get; set; }

    /// <summary>
    /// Gets or sets the percentage fee applied to credit‑card transactions. The value is expressed as a decimal (e.g., 0.025 for 2.5%).
    /// </summary>
    /// <value>The credit card percentage fee, represented as a decimal proportion of the transaction amount.</value>
    public decimal CreditCardPercentageFee { get; set; }

    /// <summary>
    /// Gets or sets the fixed absolute fee applied to credit‑card transactions. The fee is added to the transaction amount before calculating percentage fees.
    /// </summary>
    /// <value>Absolute fee amount for credit‑card payments, expressed in the merchant’s currency.</value>
    public decimal CreditCardAbsoluteFee { get; set; }

    /// <summary>
    /// Gets or sets the mode used to calculate debit fees for a service.
    /// </summary>
    /// <value>Specifies the fee calculation mode applied to debit transactions. Valid values are defined by the FeeModeEnum (e.g., 0 = None, 1 = Fixed, 2 = Percentage).</value>
    public FeeModeEnum DebitFeeMode { get; set; }

    /// <summary>
    /// Gets or sets the fee applied to debit transactions, expressed as a decimal percentage of the transaction amount. The value must be between 0 and 0.1 (up to 10%).
    /// </summary>
    /// <value>The percentage fee charged on debit operations, represented as a decimal (e.g., 0.025 for 2.5%).</value>
    public decimal DebitPercentageFee { get; set; }

    /// <summary>
    /// Gets or sets the absolute fee applied to debit transactions. The fee must be within the permitted range.
    /// </summary>
    /// <value>Absolute fee amount for debit operations, expressed in the account's currency.</value>
    public decimal DebitAbsoluteFee { get; set; }

    /// <summary>
    /// Gets or sets the fee mode applied to instant transfers.
    /// </summary>
    /// <value>Specifies the calculation method for the instant transfer fee. Valid values are defined by the FeeModeEnum (e.g., 0 = No fee, 1 = Fixed amount, 2 = Percentage).</value>
    public FeeModeEnum InstantTransferFeeMode { get; set; }

    /// <summary>
    /// Gets or sets the percentage fee applied to instant transfers. The value is expressed as a decimal fraction (e.g., 0.05 for 5%). Must be within the range 0 to 0.1 inclusive.
    /// </summary>
    /// <value>The fee percentage charged for each instant transfer, represented as a decimal fraction.</value>
    public decimal InstantTransferPercentageFee { get; set; }

    /// <summary>
    /// Gets or sets the absolute fee applied to an instant transfer.
    /// </summary>
    /// <value>Absolute fee amount (decimal) for instant transfers.</value>
    public decimal InstantTransferAbsoluteFee { get; set; }

    /// <summary>
    /// Gets or sets the convenient fee credit mode used to determine the credit‑fee calculation for a service.
    /// </summary>
    /// <value>Specifies the selected convenient fee credit mode.</value>
    public ConvenientFeeModeEnum ConvenientFeeCreditMode { get; set; }

    /// <summary>
    /// Gets or sets the percentage fee applied to convenient credit transactions.
    /// </summary>
    /// <value>The fee expressed as a decimal fraction (e.g., 0.05 for 5%).</value>
    public decimal ConvenientFeeCreditPercentageFee { get; set; }

    /// <summary>
    /// Gets or sets the absolute fee for credit convenient fee transactions.
    /// </summary>
    /// <value>The absolute fee amount (decimal) applied to credit convenient fees.</value>
    public decimal ConvenientFeeCreditAbsoluteFee { get; set; }

    /// <summary>
    /// Gets or sets the amount used to round up a convenient fee credit.
    /// </summary>
    /// <value>The decimal value that defines the round‑up amount applied to convenient fee credits.</value>
    public decimal ConvenientFeeCreditRoundUpValue { get; set; }

    /// <summary>
    /// Gets or sets the mode used to debit the convenient fee.
    /// </summary>
    /// <value>Specifies the mode used to debit the convenient fee.</value>
    public ConvenientFeeModeEnum ConvenientFeeDebitMode { get; set; }

    /// <summary>
    /// Gets or sets the percentage fee applied to convenient debit transactions.
    /// </summary>
    /// <value>The fee percentage expressed as a decimal (e.g., 0.05 for 5%).</value>
    public decimal ConvenientFeeDebitPercentageFee { get; set; }

    /// <summary>
    /// Gets or sets the absolute fee applied to a convenient fee debit operation.
    /// </summary>
    /// <value>The fixed amount charged for a convenient fee debit.</value>
    public decimal ConvenientFeeDebitAbsoluteFee { get; set; }

    /// <summary>
    /// Gets or sets the monetary value used to round up a convenient fee debit.
    /// </summary>
    /// <value>Specifies the round‑up amount applied to the convenient fee debit, expressed as a decimal.</value>
    public decimal ConvenientFeeDebitRoundUpValue { get; set; }

    /// <summary>
    /// The round-up amount applied to debit fees, expressed as a decimal value.
    /// </summary>
    /// <value>Decimal value representing the round-up amount for debit fees.</value>
    public decimal DebitFeeRoundUpValue { get; set; }

    /// <summary>
    /// Retrieves or assigns the rounding increment applied to credit‑card fees.
    /// </summary>
    /// <value>Decimal value representing the amount added to round up the calculated fee.</value>
    public decimal CreditCardFeeRoundUpValue { get; set; }

    /// <summary>
    /// Retrieves the round‑up value applied to the instant transfer fee.
    /// </summary>
    /// <value>The monetary amount used to round up the instant transfer fee, expressed as a decimal.</value>
    public decimal InstantTransferFeeRoundUpValue { get; set; }

    /// <summary>
    /// Gets the absolute fee amount that can be reverted for credit‑card transactions.
    /// </summary>
    /// <value>Decimal representing the reversible absolute fee in the transaction currency.</value>
    public decimal RevertCreditCardAbsoluteFees { get; set; }

    /// <summary>
    /// Retrieves the percentage fee that is applied when a credit‑card transaction is reverted.
    /// </summary>
    /// <value>The fee expressed as a decimal representing the percentage (e.g., 0.025 for 2.5%).</value>
    public decimal RevertCreditCardPercentageFees { get; set; }

    /// <summary>
    /// Gets or sets the absolute fee amount that is reverted from a debit operation.
    /// </summary>
    /// <value>The absolute fee, expressed as a decimal amount in the transaction currency.</value>
    public decimal RevertDebitAbsoluteFees { get; set; }

    /// <summary>
    /// Gets the percentage fee applied when a debit transaction is reverted.
    /// </summary>
    /// <value>Decimal value representing the fee percentage (e.g., 2.5 for 2.5%).</value>
    public decimal RevertDebitPercentageFees { get; set; }

    /// <summary>
    /// Retrieves the absolute fee charged for Interac transactions.
    /// </summary>
    /// <value>Decimal value representing the fee amount in the account's currency.</value>
    public decimal InteracFeeAbsolute { get; set; }

    /// <summary>
    /// Represents the fee percentage applied to Interac transactions.
    /// </summary>
    /// <value>Decimal value expressing the Interac fee as a proportion of the transaction amount (e.g., 0.025 for 2.5%).</value>
    public decimal InteracFeePercentage { get; set; }

    /// <summary>
    /// Gets the absolute Interac fee collected for a transaction.
    /// </summary>
    /// <value>The fee amount expressed as a decimal in the merchant's currency.</value>
    public decimal InteracFeeCollectAbsolute { get; set; }

    /// <summary>
    /// Specifies the percentage of the transaction amount that TIB Finance collects as a fee for Interac payments.
    /// </summary>
    /// <value>The fee percentage expressed as a decimal (e.g., 0.025 for 2.5%).</value>
    public decimal InteracFeeCollectPercentage { get; set; }

    /// <summary>
    /// Gets the fee amount charged for a debit transaction that fails due to non‑sufficient funds (NFS).
    /// </summary>
    /// <value>The fee expressed as a decimal value in the currency of the merchant account.</value>
    public decimal? DebitNFSFees { get; set; }

    /// <summary>
    /// Gets the fee amount applied to an NFS file transaction.
    /// </summary>
    /// <value>The fee value expressed in the currency of the merchant account.</value>
    public decimal? NFSFileFees { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? DataContext { get; set; }

    }
}