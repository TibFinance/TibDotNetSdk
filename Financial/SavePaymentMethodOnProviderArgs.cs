
using System;
using System.Collections.Generic;
using Tib.Api.Financial;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the SavePaymentMethodOnProviderArgs model.
    /// </summary>
    public class SavePaymentMethodOnProviderArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string HostedPaymentToken { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<ProviderAccount> ProviderCredentials { get; set; }

    /// <summary>
    /// The ISO 4217 three‑letter code of the currency in which the transfer was executed.
    /// </summary>
    /// <value>One of the supported CurrencyEnum values (e.g., USD, EUR, GBP), always uppercase; matches the currency of the source and destination accounts and is required for all transfer responses.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CustomerFirstName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CustomerLastName { get; set; }

    /// <summary>
    /// Postal code of the cardholder's billing address
    /// </summary>
    /// <value>String, required; alphanumeric, up to 10 characters; must match the format expected by the issuing country (e.g., 5‑digit or ZIP+4 for US).</value>
    public string ZipCode { get; set; }

    }
}