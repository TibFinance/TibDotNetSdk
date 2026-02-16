
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
    /// Identifies the type of payment method linked to a specific account.
    /// </summary>
    /// <value>A unique identifier representing the type of the payment method.</value>
    public PaymentMethodTypeEnum PaymentMethodType { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Gets or sets the type of the provider.
    /// </summary>
    /// <value>The type of the provider.</value>
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