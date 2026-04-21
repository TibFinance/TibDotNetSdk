
using System;
using System.Collections.Generic;
using Tib.Api.Model.Payment;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the ListTransfersResponse model.
    /// </summary>
    public class ListTransfersResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// A collection of payment details for each transfer returned by ListTransfers
    /// </summary>
    /// <value>IEnumerable of PaymentModel objects, each containing amount, currency, status, timestamps, and identifiers. May be empty if no payments exist. Items are ordered chronologically by creation date. All fields follow the PaymentModel schema and are read‑only.</value>
    public IEnumerable<PaymentModel> Payments { get; set; }

    }
}