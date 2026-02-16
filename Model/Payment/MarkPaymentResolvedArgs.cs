
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the MarkPaymentResolvedArgs model.
    /// </summary>
    public class MarkPaymentResolvedArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// List of payment to mark resolved
    /// </summary>
    /// <value>The list of payment.</value>
    public List<Guid> ListOfPayment { get; set; }

    }
}