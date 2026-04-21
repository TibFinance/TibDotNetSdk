
using System;
using Tib.Api.Financial;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the ProcessTransferInteracEntity model.
    /// </summary>
    public class ProcessTransferInteracEntity : ProcessTransferEntity
    {
        
    /// <summary>
    /// Details of the Interac e‑transfer payment method to be created.
    /// </summary>
    /// <value>Required InteracModel containing valid Canadian banking fields (bankAccountNumber, transitNumber, institutionNumber) and optional description; all values must conform to Canadian banking format and the object cannot be null.</value>
    public InteracModel InteracInformation { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AnswerSalt { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string MerchantEmail { get; set; }

    }
}