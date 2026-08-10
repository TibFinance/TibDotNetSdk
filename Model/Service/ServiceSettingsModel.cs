
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
    /// Maximum monetary amount that can be collected for the service request.
    /// </summary>
    /// <value>Decimal value in the account's base currency, typically limited to two fractional digits; represents the upper bound of collectable funds for this operation.</value>
    public decimal CollectionLimit { get; set; }

    /// <summary>
    /// The maximum total amount that can be collected for the service each day.
    /// </summary>
    /// <value>Decimal value (currency) representing the daily collection cap; zero or null indicates no limit. Rounded to two decimal places.</value>
    public decimal CollectionLimitDaily { get; set; }

    /// <summary>
    /// Maximum deposit amount allowed for the requested service.
    /// </summary>
    /// <value>Decimal value in the account's currency (up to 2 decimal places). Zero means no limit; null if the limit is not applicable.</value>
    public decimal DepositLimit { get; set; }

    /// <summary>
    /// The maximum total amount a user may deposit in a single day.
    /// </summary>
    /// <value>Decimal value in the account's base currency (e.g., 2 decimal places). Zero indicates no daily limit. Returned only when the GetService call succeeds.</value>
    public decimal DepositLimitDaily { get; set; }

    /// <summary>
    /// The amount of buffer reserved to cover service execution delays.
    /// </summary>
    /// <value>Decimal, non‑negative, expressed in the account's base currency; precision up to 4 decimal places.</value>
    public decimal DelayBufferAmount { get; set; }

    /// <summary>
    /// The remaining monetary amount available for the requested service.
    /// </summary>
    /// <value>Decimal, non‑negative, expressed in the service’s currency, up to two decimal places; zero indicates no balance left.</value>
    public decimal RemainingAmount { get; set; }

    /// <summary>
    /// Current available balance of the wallet in the account's base currency.
    /// </summary>
    /// <value>Decimal with up to 2 decimal places, non‑negative; reflects settled funds only (pending transactions are excluded).</value>
    public decimal WalletBalance { get; set; }

    /// <summary>
    /// Indicates whether the wallet feature is enabled for the requested service.
    /// </summary>
    /// <value>True when the service supports wallet operations, false otherwise; read‑only boolean returned in the GetService response.</value>
    public bool IsWalletFeatureActive { get; set; }

    /// <summary>
    /// Wallet withdrawal mode, as the numeric value of WalletTypeEnum: 1 = Schedule (withdrawals run on a set schedule), 2 = Manual (withdrawals require an explicit request), 3 = Automatic (withdrawals run automatically when the threshold is reached).
    /// </summary>
    public int WalletType { get; set; }

    /// <summary>
    /// The reserved cash buffer amount used to cover potential non‑sufficient‑funds (NSF) exposures.
    /// </summary>
    /// <value>Decimal value in the account's base currency, non‑negative, typically with two decimal places; zero indicates no buffer.</value>
    public decimal NsfBuffer { get; set; }

    /// <summary>
    /// Maximum total amount that can be collected from a single bank account in one day.
    /// </summary>
    /// <value>Decimal in the platform's base currency, up to two decimal places; includes pending collections; may be null if no daily limit is set; subject to regulatory caps.</value>
    public decimal CollectionLimitPerBankAccountDaily { get; set; }

    /// <summary>
    /// Maximum monetary amount that can be collected from a single bank account during a delay period.
    /// </summary>
    /// <value>Decimal value (currency of the account) representing the per‑account collection cap for each delay interval; typically limited to two decimal places and may be null to indicate no limit.</value>
    public decimal CollectionLimitPerBankAccountPerDelays { get; set; }

    /// <summary>
    /// Maximum number of hours to delay further collection attempts after reaching the per‑bank‑account collection limit.
    /// </summary>
    /// <value>Integer ≥ 0; defines the cooldown period (in hours) applied per bank account when the collection limit is hit.</value>
    public int CollectionLimitPerBankAccountHoursDelays { get; set; }

    /// <summary>
    /// Maximum monetary threshold for aggregating client warnings in the service response.
    /// </summary>
    /// <value>Decimal (up to two decimal places) representing the limit in the account's base currency; must be non‑negative. Exceeding this value triggers a client warning.</value>
    public decimal ClientWarningCollectionLimit { get; set; }

    /// <summary>
    /// Maximum number of collection transactions allowed per bank account each day.
    /// </summary>
    /// <value>Integer ≥ 0; resets at midnight UTC; reflects the daily limit configured for the service.</value>
    public int NumberOfCollectionPerBankAccountDaily { get; set; }

    /// <summary>
    /// The total count of collection attempts scheduled for each bank within a given delay interval.
    /// </summary>
    /// <value>Integer, &gt;= 0. Represents how many times the system will retry collecting payments from a specific bank after a delay period. No upper limit defined by the API, but typical implementations cap at a reasonable maximum (e.g., 10).</value>
    public int NumberOfCollectionPerBankPerDelays { get; set; }

    /// <summary>
    /// Maximum total amount that can be deposited to a single bank account in one day.
    /// </summary>
    /// <value>Decimal value in the account's currency; applies per bank account per calendar day; may be null if no limit is set.</value>
    public decimal DepositLimitPerBankAccountDaily { get; set; }

    /// <summary>
    /// Maximum total deposit amount allowed for a single bank account within the configured delay interval.
    /// </summary>
    /// <value>Decimal value representing the limit in the account's currency; applies per bank account per delay period (e.g., per day). Zero or null indicates no limit. Must be non‑negative.</value>
    public decimal DepositLimitPerBankAccountPerDelays { get; set; }

    /// <summary>
    /// The number of hours a user must wait before making another deposit to the same bank account.
    /// </summary>
    /// <value>Integer, non‑negative. 0 disables the delay; typical values range from 1 to 48 hours. Enforced per‑account deposit throttling.</value>
    public int DepositLimitPerBankAccountHoursDelays { get; set; }

    /// <summary>
    /// The deposit amount threshold that triggers a client warning.
    /// </summary>
    /// <value>Decimal value in the account's base currency; a warning is issued when a deposit exceeds this limit. Must be non‑negative.</value>
    public decimal ClientWarningDepositLimit { get; set; }

    /// <summary>
    /// The total count of deposit transactions made on a bank account during the current day.
    /// </summary>
    /// <value>Integer value, resets to 0 at midnight (UTC); reflects only successful deposits; maximum defined by account limits; range: 0‑2147483647.</value>
    public int NumberOfDepositPerBankAccountDaily { get; set; }

    /// <summary>
    /// The total count of deposit transactions for each bank within the specified delay intervals.
    /// </summary>
    /// <value>Integer ≥ 0; reflects per‑bank deposit volume per delay category in the GetService response. Upper bound limited by 32‑bit signed int.</value>
    public int NumberOfDepositPerBankPerDelays { get; set; }

    /// <summary>
    /// Number of days the platform waits before depositing funds into the merchant's account
    /// </summary>
    /// <value>Integer ≥ 0; 0 indicates immediate deposit, typical range 0‑30 days depending on settlement settings</value>
    public int MerchantAccountDepositDelay { get; set; }

    /// <summary>
    /// Allowlist of the payment methods permitted for collections on this service, as an AutorizedPaymentMethodFlags bitmask (CreditCard = 1, DirectAccount = 2, Interac = 16). A value of 0 means no restriction; any other value permits only the rails whose bits are set, and a collection on any other rail is refused.
    /// </summary>
    public int CollectAllowedPaymentMethods { get; set; }

    /// <summary>
    /// Allowlist of the payment methods permitted for deposits on this service, as an AutorizedPaymentMethodFlags bitmask (DirectAccount = 2, Interac = 16). A value of 0 means no restriction. Credit card is never valid for deposits.
    /// </summary>
    public int DepositAllowedPaymentMethods { get; set; }

    /// <summary>
    /// Whether free deposits are blocked for this service. When true, free deposit operations on this service are refused. This applies regardless of the payment method used.
    /// </summary>
    public bool DenyFreeDeposits { get; set; }

    /// <summary>
    /// Whether supplier payments are blocked for this service. When true, supplier transfers paid by merchants of this service are refused.
    /// </summary>
    public bool DenySupplierPayments { get; set; }

    }
}