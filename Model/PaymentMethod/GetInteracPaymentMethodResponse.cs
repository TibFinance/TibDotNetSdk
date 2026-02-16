
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.PaymentMethod
{
    /// <summary>
    /// Represents the GetInteracPaymentMethodResponse model.
    /// </summary>
    public class GetInteracPaymentMethodResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Question { get; set; }

    /// <summary>
    /// The 'Owner' property is designed to assign and identify the ownership of a specific resource or object within the system.
    /// </summary>
    /// <value>The 'Owner' property holds a unique string value that signifies the identifier of the owner, ensuring distinct representation within the system.</value>
    public string Owner { get; set; }

    /// <summary>
    /// Specifies the email address associated with the merchant.
    /// </summary>
    /// <value>Represents the merchant's email address, which is used for communication and identification purposes within the TIB Finance API.</value>
    public string Email { get; set; }

    /// <summary>
    /// Provides a detailed explanation of the function's purpose and usage within the API.
    /// </summary>
    /// <value>This property offers a comprehensive description of how the function interacts with the API, detailing its role in retrieving customer data associated with a merchant account.</value>
    public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Mobile { get; set; }

    }
}