
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the ListMerchantsArgs model.
    /// </summary>
    public class ListMerchantsArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Whether to include the client's own primary merchant for the service in the results. Results are always scoped to the authenticated client; this flag does not widen visibility across clients.
    /// </summary>
    public bool IncludeClientMerchants { get; set; }

    }
}