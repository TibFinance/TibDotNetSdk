
using System;
using Tib.Api.Financial;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ProcessDropInCreditCardArgs : BaseProcessDropInArgs
    {
        
    /// <summary>
    /// Manages all operations associated with credit card data.
    /// </summary>
    /// <value>Represents a distinct numerical identifier that corresponds to a specific credit card in the system.</value>
    public CreditCardModel CreditCard { get; set; }

    }
}