
using System;
using System.Collections.Generic;
using Tib.Api.Financial;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
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
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
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
    /// 
    /// </summary>
    /// <value></value>
    public string ZipCode { get; set; }

    }
}