
using System;
using System.Collections.Generic;
using Tib.Api.Financial;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the ProviderAccount model.
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
    /// The payment method type employed for the transfer.
    /// </summary>
    /// <value>A value from the PaymentMethodTypeEnum (e.g., CARD, BANK_ACCOUNT, WALLET). It identifies the source/destination method, is always present in the response, and must match one of the defined enum members.</value>
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
    /// The ISO 4217 three‑letter code of the currency in which the transfer was executed.
    /// </summary>
    /// <value>One of the supported CurrencyEnum values (e.g., USD, EUR, GBP), always uppercase; matches the currency of the source and destination accounts and is required for all transfer responses.</value>
    public CurrencyEnum Currency { get; set; }

    }
}