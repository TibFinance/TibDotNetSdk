
using System;
using System.Collections.Generic;
using Tib.Api.Financial;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ProviderAccount : ProviderEntity
    {
        
    /// <summary>
    /// Gets or sets the crypted credentials.
    /// </summary>
    /// <value>The crypted credentials.</value>
    public List<CredentialValueType> CredentialValuesTypes { get; set; }

    /// <summary>
    /// Gets or sets the provider name.
    /// </summary>
    /// <value>The provider name.</value>
    public string ProviderName { get; set; }

    /// <summary>
    /// Identifies the type of payment method linked to a specific account.
    /// </summary>
    /// <value>A unique identifier representing the type of the payment method.</value>
    public PaymentMethodTypeEnum PaymentMethodType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Boolean IsDefault { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public OwnerTypeEnum OwnerType { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum Currency { get; set; }

    }
}