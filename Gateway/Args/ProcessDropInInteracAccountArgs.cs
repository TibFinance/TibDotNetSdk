
using System;
using Tib.Api.Financial;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the ProcessDropInInteracAccountArgs model.
    /// </summary>
    public class ProcessDropInInteracAccountArgs : BaseProcessDropInArgs
    {
        
    /// <summary>
    /// Details of the Interac e‑transfer payment method to be created.
    /// </summary>
    /// <value>Required InteracModel containing valid Canadian banking fields (bankAccountNumber, transitNumber, institutionNumber) and optional description; all values must conform to Canadian banking format and the object cannot be null.</value>
    public InteracModel InteracInformation { get; set; }

    }
}