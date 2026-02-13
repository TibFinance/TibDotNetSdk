
using System;
using Tib.Api.Financial;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ProcessTransferCreditCardEntity : ProcessTransferEntity
    {
        
    /// <summary>
    /// Gets or sets the card information.
    /// </summary>
    /// <value>The card information.</value>
    public CreditCardModel CardInformation { get; set; }

    /// <summary>
    /// Determine if the card is new in the system.
    /// </summary>
    /// <value></value>
    public bool NeedValidation { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ProviderGivenIdentification { get; set; }

    }
}