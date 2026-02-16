
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
    /// This model encapsulates the details required to manage Interac payment methods for customers. It is used to facilitate electronic funds transfers via the Interac network, a widely used payment system in Canada.
    /// </summary>
    /// <value>The model does not directly return a value. It serves as a data structure to store and manage Interac payment information.</value>
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