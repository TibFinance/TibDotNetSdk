
using System;
using Tib.Api.Financial;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ProcessDropInInteracAccountArgs : BaseProcessDropInArgs
    {
        
    /// <summary>
    /// This model encapsulates the details required to manage Interac payment methods for customers. It is used to facilitate electronic funds transfers via the Interac network, a widely used payment system in Canada.
    /// </summary>
    /// <value>The model does not directly return a value. It serves as a data structure to store and manage Interac payment information.</value>
    public InteracModel InteracInformation { get; set; }

    }
}