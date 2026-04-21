
using System;
using System.Collections.Generic;
using Tib.Api.Financial;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the GetPaymentInvoiceArgs model.
    /// </summary>
    public class GetPaymentInvoiceArgs : ClientCallBaseArgs
    {
        
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
    /// The start date-time for the transfer search window.
    /// </summary>
    /// <value>ISO‑8601 DateTime (UTC). Must be earlier than or equal to ToDate and cannot be set in the future.</value>
    public DateTime FromDate { get; set; }

    /// <summary>
    /// Upper bound of the transfer creation date range for the query
    /// </summary>
    /// <value>ISO‑8601 UTC DateTime; inclusive; must be ≥ FromDate; cannot exceed current server time; typical max range 90 days</value>
    public DateTime ToDate { get; set; }

    }
}