
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the ServiceFeeSettingsModel model.
    /// </summary>
    public class ServiceFeeSettingsModel 
    {
        
    /// <summary>
    /// Specifies the fee calculation mode used for credit‑card transactions.
    /// </summary>
    /// <value>Enum values (Fixed, Percentage, Mixed) defined in FeeModeEnum; determines whether fees are a flat amount, a percentage of the transaction, or a combination. Present only when the credit‑card service is active.</value>
    public FeeModeEnum CreditCardFeeMode { get; set; }

    /// <summary>
    /// The percentage fee applied to credit‑card transactions for the service.
    /// </summary>
    /// <value>Decimal value (e.g., 2.5 = 2.5%). Up to two decimal places; may be null if the service does not support credit‑card payments.</value>
    public decimal CreditCardPercentageFee { get; set; }

    /// <summary>
    /// The fixed monetary fee applied to a credit‑card transaction.
    /// </summary>
    /// <value>Decimal value in the account's base currency, non‑negative, up to two decimal places; zero indicates no absolute fee.</value>
    public decimal CreditCardAbsoluteFee { get; set; }

    /// <summary>
    /// Specifies the fee calculation mode applied to debit transactions for the service.
    /// </summary>
    /// <value>Enum FeeModeEnum (e.g., NONE, FIXED, PERCENTAGE). Determines whether no fee, a fixed amount, or a percentage of the transaction amount is charged. Read‑only in the GetService response.</value>
    public FeeModeEnum DebitFeeMode { get; set; }

    /// <summary>
    /// The percentage fee applied to debit transactions for the requested service.
    /// </summary>
    /// <value>Decimal value representing a percent (e.g., 0.75 = 0.75%). May be null if no debit fee applies. Valid range: 0 – 100, typically limited to two decimal places.</value>
    public decimal DebitPercentageFee { get; set; }

    /// <summary>
    /// The fixed absolute fee applied to a debit transaction.
    /// </summary>
    /// <value>Decimal, non‑negative, expressed in the account's base currency; zero indicates no fee. Precision up to 4 decimal places.</value>
    public decimal DebitAbsoluteFee { get; set; }

    /// <summary>
    /// Indicates the fee calculation mode applied to an instant transfer.
    /// </summary>
    /// <value>Enum FeeModeEnum (e.g., Fixed, Percentage, None). Returned only for instant‑transfer services; null if fees are not applicable.</value>
    public FeeModeEnum InstantTransferFeeMode { get; set; }

    /// <summary>
    /// The percentage fee applied to an instant transfer, expressed as a decimal.
    /// </summary>
    /// <value>Decimal value (e.g., 0.015 = 1.5%). Represents the fee rate; must be ≥ 0 and ≤ 1 (0‑100%). Rounded to the platform's precision (typically 4 decimal places).</value>
    public decimal InstantTransferPercentageFee { get; set; }

    /// <summary>
    /// The fixed absolute fee applied to an instant transfer.
    /// </summary>
    /// <value>Decimal amount in the account's currency, non‑negative, returned with two decimal places; zero indicates no fee.</value>
    public decimal InstantTransferAbsoluteFee { get; set; }

    /// <summary>
    /// Specifies the fee‑crediting mode applied to the service request.
    /// </summary>
    /// <value>Enum ConvenientFeeModeEnum (e.g., Immediate, Deferred, None). Read‑only, present only when the service supports fee crediting and reflects the mode used for the transaction.</value>
    public ConvenientFeeModeEnum ConvenientFeeCreditMode { get; set; }

    /// <summary>
    /// The percentage fee charged on credit transactions for the Convenient Fee service.
    /// </summary>
    /// <value>Decimal value representing a percent (e.g., 0.75 = 0.75%). Typically limited to 0‑100 with up to two decimal places.</value>
    public decimal ConvenientFeeCreditPercentageFee { get; set; }

    /// <summary>
    /// The absolute fee amount charged for a convenient credit service.
    /// </summary>
    /// <value>Decimal, non‑negative, expressed in the account's base currency, typically with two decimal places; zero indicates no fee.</value>
    public decimal ConvenientFeeCreditAbsoluteFee { get; set; }

    /// <summary>
    /// The rounded‑up amount of the convenience fee credit applied to the transaction.
    /// </summary>
    /// <value>Decimal, non‑negative, two‑decimal precision, expressed in the transaction currency; zero if no credit was applied.</value>
    public decimal ConvenientFeeCreditRoundUpValue { get; set; }

    /// <summary>
    /// Specifies the mode used to debit the convenient fee for the transaction.
    /// </summary>
    /// <value>Enum ConvenientFeeModeEnum (e.g., PREPAID, POSTPAID, NONE). Determines whether the fee is charged upfront, after settlement, or not applied. Must match one of the defined enum values; omitted defaults to the platform's standard fee mode.</value>
    public ConvenientFeeModeEnum ConvenientFeeDebitMode { get; set; }

    /// <summary>
    /// The percentage fee applied to debit transactions for the convenient fee service.
    /// </summary>
    /// <value>Decimal representing a percentage (e.g., 0.75 = 0.75%). Must be between 0 and 100, typically with up to two decimal places. Null if the service does not charge a convenient fee.</value>
    public decimal ConvenientFeeDebitPercentageFee { get; set; }

    /// <summary>
    /// The absolute amount of the convenient fee charged for a debit transaction.
    /// </summary>
    /// <value>Decimal, non‑negative, expressed in the transaction's base currency; zero indicates no fee. Typically limited to two decimal places.</value>
    public decimal ConvenientFeeDebitAbsoluteFee { get; set; }

    /// <summary>
    /// The amount (decimal) to which a convenient fee debit is rounded up.
    /// </summary>
    /// <value>Non‑negative decimal, typically with two fractional digits; applied as the rounding increment for fee debits in the response.</value>
    public decimal ConvenientFeeDebitRoundUpValue { get; set; }

    /// <summary>
    /// The amount (in the account currency) to which debit fees are rounded up.
    /// </summary>
    /// <value>Decimal, non‑negative, typically two‑decimal precision; 0 means no rounding applied.</value>
    public decimal DebitFeeRoundUpValue { get; set; }

    /// <summary>
    /// The amount (in the transaction currency) to which credit‑card fees are rounded up.
    /// </summary>
    /// <value>Decimal, non‑negative, typically two‑decimal precision; applied after fee calculation before settlement.</value>
    public decimal CreditCardFeeRoundUpValue { get; set; }

    /// <summary>
    /// The rounded‑up fee amount applied to an instant transfer.
    /// </summary>
    /// <value>Decimal value in the account's base currency, rounded up to the smallest currency unit (e.g., cents). Zero indicates no instant‑transfer fee. Must be non‑negative.</value>
    public decimal InstantTransferFeeRoundUpValue { get; set; }

    /// <summary>
    /// The absolute fee amount charged for reverting a credit‑card transaction.
    /// </summary>
    /// <value>Decimal, non‑negative, expressed in the transaction’s currency, rounded to the smallest currency unit (typically two decimal places).</value>
    public decimal RevertCreditCardAbsoluteFees { get; set; }

    /// <summary>
    /// The percentage fee applied when a credit‑card transaction is reverted.
    /// </summary>
    /// <value>Decimal value representing the fee as a percent (e.g., 2.5 = 2.5%). Must be ≥ 0 and ≤ 100, typically with up to two decimal places. Returned as 0 if no reversal fee applies.</value>
    public decimal RevertCreditCardPercentageFees { get; set; }

    /// <summary>
    /// The absolute fee amount charged when a debit transaction is reverted.
    /// </summary>
    /// <value>Decimal, non‑negative, expressed in the account's currency, typically with two decimal places; omitted if no revert fee applies.</value>
    public decimal RevertDebitAbsoluteFees { get; set; }

    /// <summary>
    /// The percentage fee charged when a debit transaction is reverted.
    /// </summary>
    /// <value>Decimal value (0‑100) with up to two decimal places, representing the fee rate applied to the original debit amount.</value>
    public decimal RevertDebitPercentageFees { get; set; }

    /// <summary>
    /// The absolute Interac transaction fee charged, expressed as a decimal amount.
    /// </summary>
    /// <value>Returned in the account's base currency, non‑negative, typically with two decimal places; zero indicates no fee, null if not applicable.</value>
    public decimal InteracFeeAbsolute { get; set; }

    /// <summary>
    /// The percentage fee applied to Interac transactions.
    /// </summary>
    /// <value>Decimal value (e.g., 0.015 for 1.5%). Must be between 0 and 1 inclusive and reflects the fee portion of the transaction amount.</value>
    public decimal InteracFeePercentage { get; set; }

    /// <summary>
    /// The absolute Interac fee collected for the transaction, expressed as a decimal amount in CAD.
    /// </summary>
    /// <value>Returned as a decimal with up to two fractional digits; zero indicates no fee. Represents the exact fee amount charged, not a percentage.</value>
    public decimal InteracFeeCollectAbsolute { get; set; }

    /// <summary>
    /// The percentage of the Interac transaction fee that the platform collects.
    /// </summary>
    /// <value>Decimal value between 0 and 100 (inclusive), representing a percent (e.g., 0.75 = 0.75%). Up to two decimal places; required in the GetService response.</value>
    public decimal InteracFeeCollectPercentage { get; set; }

    /// <summary>
    /// The total amount of NFS debit fees applied to the transaction.
    /// </summary>
    /// <value>Decimal, non‑negative, up to two decimal places, expressed in the account's base currency; zero if no NFS fees were charged.</value>
    public decimal? DebitNFSFees { get; set; }

    /// <summary>
    /// The total fee amount charged for NFS file services in the response.
    /// </summary>
    /// <value>Decimal value representing the fee in the platform's base currency (e.g., USD), typically with two decimal places; may be zero if no fee applies.</value>
    public decimal? NFSFileFees { get; set; }

    /// <summary>
    /// Fee charged when a credit card charge attempt fails.
    /// </summary>
    /// <value></value>
    public decimal CreditCardFailedChargeFee { get; set; }

    /// <summary>
    /// Fee charged when a transaction is returned due to an opposition (chargeback).
    /// </summary>
    /// <value></value>
    public decimal OppositionReturnFees { get; set; }

    /// <summary>
    /// Fee charged when an Interac transaction is returned.
    /// </summary>
    /// <value></value>
    public decimal InteracReturnFee { get; set; }

    /// <summary>
    /// Identifier of the data context used for the service response
    /// </summary>
    /// <value>Integer ≥ 0 representing a predefined data context ID; must match one of the platform's configured context identifiers.</value>
    public int? DataContext { get; set; }

    }
}