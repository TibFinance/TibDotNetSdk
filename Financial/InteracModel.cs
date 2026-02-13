
using System;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class InteracModel 
    {
        
    /// <summary>
    /// Provides a detailed explanation of the function's purpose and usage within the API.
    /// </summary>
    /// <value>This property offers a comprehensive description of how the function interacts with the API, detailing its role in retrieving customer data associated with a merchant account.</value>
    public string Description { get; set; }

    /// <summary>
    /// The 'Owner' property is designed to assign and identify the ownership of a specific resource or object within the system.
    /// </summary>
    /// <value>The 'Owner' property holds a unique string value that signifies the identifier of the owner, ensuring distinct representation within the system.</value>
    public string Owner { get; set; }

    /// <summary>
    /// TargetEmailAddress specifies the email address to which the Interac request is sent. It identifies the recipient for initiating an Interac transaction.
    /// </summary>
    /// <value>A string containing a valid email address, limited to 80 characters.</value>
    public string TargetEmailAddress { get; set; }

    /// <summary>
    /// Specifies the mobile phone number to which the Interac request is sent.
    /// </summary>
    /// <value>Contains the 10‑digit Canadian mobile phone number of the recipient. The field may be left empty if no mobile number is used.</value>
    public string TargetMobilePhoneNumber { get; set; }

    /// <summary>
    /// The question displayed to the Interac recipient to request acceptance of a deposit.
    /// </summary>
    /// <value>Holds the question text as a string.</value>
    public string InteracQuestion { get; set; }

    /// <summary>
    /// InteracAnswer is the response string that the target must provide to accept an Interac deposit.
    /// </summary>
    /// <value>Holds the answer supplied by the Interac recipient to confirm the deposit operation.</value>
    public string InteracAnswer { get; set; }

    }
}