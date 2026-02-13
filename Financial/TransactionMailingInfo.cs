
using System;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class TransactionMailingInfo 
    {
        
    /// <summary>
    /// Gets or sets the mail body.
    /// </summary>
    /// <value>The mail body.</value>
    public string MailBody { get; set; }

    /// <summary>
    /// Gets or sets the mail subject.
    /// </summary>
    /// <value>The mail subject.</value>
    public string MailSubject { get; set; }

    /// <summary>
    /// Converts to address.
    /// </summary>
    /// <value>To address.</value>
    public string ToAddress { get; set; }

    /// <summary>
    /// Gets or sets from address.
    /// </summary>
    /// <value>From address.</value>
    public string FromAddress { get; set; }

    }
}