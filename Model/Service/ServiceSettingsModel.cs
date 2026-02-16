
using System;
using Tib.Api.Model.Service;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the ServiceSettingsModel model.
    /// </summary>
    public class ServiceSettingsModel : IClientWarningLimits
    {
        
    /// <summary>
    /// Retrieves or assigns the monetary collection limit associated with a service contract. This limit defines the maximum amount that can be collected in a single operation and is expressed in the merchant's currency.
    /// </summary>
    /// <value>The collection limit amount. Must be a decimal value within the permitted range.</value>
    public decimal CollectionLimit { get; set; }

    /// <summary>
    /// Gets or sets the daily collection limit applied to the service contract.
    /// </summary>
    /// <value>The maximum total amount that can be collected in a single day. The value must be between 100 and 100,000,000.</value>
    public decimal CollectionLimitDaily { get; set; }

    /// <summary>
    /// Gets or sets the deposit limit for the service contract, expressed as a decimal amount.
    /// </summary>
    /// <value>Specifies the monetary limit applied to deposit operations.</value>
    public decimal DepositLimit { get; set; }

    /// <summary>
    /// Gets or sets the maximum amount that can be deposited in a single day for the client’s service contract.
    /// </summary>
    /// <value>Daily deposit ceiling expressed as a decimal value in the account’s currency.</value>
    public decimal DepositLimitDaily { get; set; }

    /// <summary>
    /// Gets or sets the delay buffer amount used to define the monetary buffer applied to transaction timing delays.
    /// </summary>
    /// <value>The monetary amount representing the buffer applied to delay calculations.</value>
    public decimal DelayBufferAmount { get; set; }

    /// <summary>
    /// Gets or sets the remaining monetary amount for the current transaction or operation, expressed as a decimal value.
    /// </summary>
    /// <value>The remaining amount, represented as a decimal (typically with two fractional digits) in the transaction currency.</value>
    public decimal RemainingAmount { get; set; }

    /// <summary>
    /// Gets or sets the current wallet balance for the client.
    /// </summary>
    /// <value>Current wallet balance expressed as a decimal amount in the account's base currency.</value>
    public decimal WalletBalance { get; set; }

    /// <summary>
    /// Indicates whether the wallet feature is enabled for the client.
    /// </summary>
    /// <value>True when the wallet feature is active; otherwise, false.</value>
    public bool IsWalletFeatureActive { get; set; }

    /// <summary>
    /// Gets or sets the wallet type identifier used by the TIB Finance API to select the appropriate wallet configuration.
    /// </summary>
    /// <value>Integer representing the wallet type. Valid values correspond to predefined wallet categories defined by TIB Finance.</value>
    public int WalletType { get; set; }

    /// <summary>
    /// Gets or sets the NSF (Non‑Sufficient Funds) buffer amount applied to transactions.
    /// </summary>
    /// <value>Decimal representing the NSF buffer that is used when processing deposits or collections.</value>
    public decimal NsfBuffer { get; set; }

    /// <summary>
    /// Retrieves or assigns the maximum amount that can be collected from a single bank account in one calendar day.
    /// </summary>
    /// <value>The daily collection limit per bank account, represented as a decimal value.</value>
    public decimal CollectionLimitPerBankAccountDaily { get; set; }

    /// <summary>
    /// Gets or sets the maximum collection amount allowed for a specific bank account during a given delay interval.
    /// </summary>
    /// <value>Decimal value representing the per‑account collection limit for each delay period.</value>
    public decimal CollectionLimitPerBankAccountPerDelays { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of hours that a collection operation may be delayed for a specific bank account.
    /// </summary>
    /// <value>An integer representing the allowed delay in hours for collections per bank account.</value>
    public int CollectionLimitPerBankAccountHoursDelays { get; set; }

    /// <summary>
    /// Gets or sets the warning collection limit for a client. This limit defines the monetary threshold at which the system raises a warning for client collection activities.
    /// </summary>
    /// <value>The decimal value representing the client’s warning collection threshold.</value>
    public decimal ClientWarningCollectionLimit { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of collection transactions that can be processed per bank account each day.
    /// </summary>
    /// <value>Daily limit of collection operations permitted for a single bank account.</value>
    public int NumberOfCollectionPerBankAccountDaily { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of collection attempts allowed for a specific bank within a single delay interval.
    /// </summary>
    /// <value>Integer that represents how many collection attempts can be performed for the bank before the delay period expires.</value>
    public int NumberOfCollectionPerBankPerDelays { get; set; }

    /// <summary>
    /// Gets or sets the maximum total amount that can be deposited to a single bank account per day.
    /// </summary>
    /// <value>The current daily deposit limit for the specified bank account.</value>
    public decimal DepositLimitPerBankAccountDaily { get; set; }

    /// <summary>
    /// Gets or sets the maximum deposit amount allowed for a single bank account within a defined delay interval.
    /// </summary>
    /// <value>Maximum deposit limit (decimal) applicable to each bank account for the specified delay period.</value>
    public decimal DepositLimitPerBankAccountPerDelays { get; set; }

    /// <summary>
    /// Gets or sets the number of hour delays applied to the deposit limit for a specific bank account.
    /// </summary>
    /// <value>Number of hour delays that affect the deposit limit per bank account.</value>
    public int DepositLimitPerBankAccountHoursDelays { get; set; }

    /// <summary>
    /// Retrieves or updates the warning deposit limit configured for a client.
    /// </summary>
    /// <value>The monetary amount that triggers a warning when a client attempts to deposit more than this value. Represented as a decimal amount in the account's currency.</value>
    public decimal ClientWarningDepositLimit { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of deposit transactions that can be performed per bank account each day.
    /// </summary>
    /// <value>Integer representing the daily deposit limit for a single bank account.</value>
    public int NumberOfDepositPerBankAccountDaily { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of deposit attempts allowed for a specific bank during a defined delay interval.
    /// </summary>
    /// <value>The configured limit of deposit attempts per bank within each delay period.</value>
    public int NumberOfDepositPerBankPerDelays { get; set; }

    /// <summary>
    /// Retrieves or updates the warning collection limit applied to TIB operations. This limit defines the threshold at which a warning is triggered for collection activities.
    /// </summary>
    /// <value>Decimal value representing the warning collection limit. Must be non-negative and expressed in the contract currency.</value>
    public decimal TIBWarningCollectionLimit { get; set; }

    /// <summary>
    /// Gets or sets the daily warning collection limit for a bank account.
    /// </summary>
    /// <value>Daily limit (in the account's currency) that triggers a TIB warning when the total collection amount for the bank account exceeds this value.</value>
    public decimal TIBWarningCollectionLimitPerBankAccountDaily { get; set; }

    /// <summary>
    /// Gets or sets the warning collection limit applied to a bank account for each delay interval.
    /// </summary>
    /// <value>Specifies the maximum amount (in the account's currency) that can be collected as a warning for a single bank account within a given delay period.</value>
    public decimal TIBWarningCollectionLimitPerBankAccountPerDelays { get; set; }

    /// <summary>
    /// Gets or sets the daily collection warning limit for a bank account.
    /// </summary>
    /// <value>The warning threshold that defines the maximum number of collection attempts allowed per bank account each day.</value>
    public int TIBWarningNumberOfCollectionPerBankAccountDaily { get; set; }

    /// <summary>
    /// Gets or sets the warning threshold that defines the maximum number of collection attempts allowed for a single bank within a delay interval.
    /// </summary>
    /// <value>The warning threshold value for collection attempts per bank per delay period.</value>
    public int TIBWarningNumberOfCollectionPerBankPerDelays { get; set; }

    /// <summary>
    /// Gets or sets the daily warning collection limit for TIB services.
    /// </summary>
    /// <value>Daily warning collection limit expressed as a decimal amount.</value>
    public decimal TIBWarningCollectionLimitDaily { get; set; }

    /// <summary>
    /// Gets or sets the warning deposit limit for the TIB service. The limit defines the maximum deposit amount that triggers a warning in the system.
    /// </summary>
    /// <value>Decimal value representing the warning deposit limit in the account's currency.</value>
    public decimal TIBWarningDepositLimit { get; set; }

    /// <summary>
    /// Gets or sets the daily warning deposit limit applied to each bank account.
    /// </summary>
    /// <value>Decimal value representing the maximum total deposit amount for a single bank account in a day that triggers a warning.</value>
    public decimal TIBWarningDepositLimitPerBankAccountDaily { get; set; }

    /// <summary>
    /// Gets or sets the warning deposit limit applied to each bank account for a specific delay interval.
    /// </summary>
    /// <value>The monetary threshold, expressed as a decimal, that triggers a warning when the total deposits to a bank account exceed this limit within the defined delay period.</value>
    public decimal TIBWarningDepositLimitPerBankAccountPerDelays { get; set; }

    /// <summary>
    /// Gets or sets the daily warning threshold for the number of deposits allowed on a single bank account.
    /// </summary>
    /// <value>The daily warning threshold for deposit count per bank account.</value>
    public int TIBWarningNumberOfDepositPerBankAccountDaily { get; set; }

    /// <summary>
    /// Gets or sets the warning threshold that defines how many deposits a bank may process within the configured delay period.
    /// </summary>
    /// <value>The warning threshold for the number of deposits per bank per delay interval.</value>
    public int TIBWarningNumberOfDepositPerBankPerDelays { get; set; }

    /// <summary>
    /// Gets or sets the daily warning limit for deposits in the TIB Finance system. This limit triggers warning notifications when a deposit exceeds the configured daily threshold.
    /// </summary>
    /// <value>The daily warning deposit limit expressed as a decimal amount in the account's currency.</value>
    public decimal TIBWarningDepositLimitDaily { get; set; }

    /// <summary>
    /// Gets or sets the number of days the system waits before depositing funds into the merchant's bank account.
    /// </summary>
    /// <value>The delay, expressed in whole days, applied to deposit operations for the merchant account.</value>
    public int MerchantAccountDepositDelay { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int DataContext { get; set; }

    }
}