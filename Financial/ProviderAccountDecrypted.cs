
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Model.General;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the ProviderAccountDecrypted model.
    /// </summary>
    public class ProviderAccountDecrypted 
    {
        
    /// <summary>
    /// Gets or sets the name of the provider.
    /// </summary>
    /// <value>The name of the provider.</value>
    public Guid ProviderId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public String ProviderName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int OrderPriority { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsDefault { get; set; }

    /// <summary>
    /// The payment method type employed for the transfer.
    /// </summary>
    /// <value>A value from the PaymentMethodTypeEnum (e.g., CARD, BANK_ACCOUNT, WALLET). It identifies the source/destination method, is always present in the response, and must match one of the defined enum members.</value>
    public PaymentMethodTypeEnum PaymentMethodType { get; set; }

    /// <summary>
    /// The ISO 4217 three‑letter code of the currency in which the transfer was executed.
    /// </summary>
    /// <value>One of the supported CurrencyEnum values (e.g., USD, EUR, GBP), always uppercase; matches the currency of the source and destination accounts and is required for all transfer responses.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Identifies the category of the service provider for the requested service
    /// </summary>
    /// <value>Returns a ProviderEnum value (e.g., BANK, BROKER, PAYMENT_GATEWAY). Must be one of the defined enum members; case‑sensitive and always present in the GetService response.</value>
    public ProviderEnum ProviderType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public OwnerTypeEnum OwnerType { get; set; }

    /// <summary>
    /// Gets or sets the account.
    /// </summary>
    /// <value>The account.</value>
    public string AccountCollect { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AccountDeposit { get; set; }

    /// <summary>
    /// Gets or sets the password.
    /// </summary>
    /// <value>The password.</value>
    public string PasswordCollect { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string PasswordDeposit { get; set; }

    /// <summary>
    /// Gets or sets the questions.
    /// </summary>
    /// <value>The questions.</value>
    public List<QuestionAnswerDecrypted> Questions { get; set; }

    /// <summary>
    /// Gets or sets the addresses.
    /// </summary>
    /// <value>The addresses.</value>
    public List<ProviderAddressEntity> Addresses { get; set; }

    /// <summary>
    /// Gets or sets the credential values.
    /// </summary>
    /// <value>The credential values.</value>
    public Dictionary<string, string> CredentialValues { get; set; }

    /// <summary>
    /// List of specific CredentialValue for other Provider Credential. Example, RBC has Credential Value called "OrganizationNumber". So this property can be loaded with the Key "OrganizationNumber" and the values "RBC""Value2", "RBC2""Value2"
    /// </summary>
    /// <value></value>
    public Dictionary<string, Dictionary<string, string>> ProviderOtherCredentialValues { get; set; }

    /// <summary>
    /// List of specific MerchantCredentialValues for other Provider Credential.
    /// </summary>
    /// <value></value>
    public List<ProviderMerchantCredentialEntity> MerchantCredentialValues { get; set; }

    }
}