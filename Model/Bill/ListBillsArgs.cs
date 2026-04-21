
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Represents the ListBillsArgs model.
    /// </summary>
    public class ListBillsArgs : ClientCallBaseArgs, IMerchantArgs
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
    /// The start of the date‑time range for which bills are returned.
    /// </summary>
    /// <value>Must be a valid ISO‑8601 DateTime (UTC preferred), inclusive, and cannot be later than the ToDateTime parameter.</value>
    public DateTime? FromDateTime { get; set; }

    /// <summary>
    /// Upper bound of the billing period for which bills are retrieved.
    /// </summary>
    /// <value>ISO‑8601 DateTime (UTC). Must be greater than or equal to FromDateTime; inclusive. If omitted defaults to the current date.</value>
    public DateTime? ToDateTime { get; set; }

    }
}