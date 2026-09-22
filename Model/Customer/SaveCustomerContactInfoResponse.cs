
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the SaveCustomerContactInfoResponse model.
    /// </summary>
    public class SaveCustomerContactInfoResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Contact information of the customer to be created
    /// </summary>
    /// <value>Provides email, phone, and address; at least one contact method (email or phone) is required; fields must conform to standard format and length constraints defined in ContactInfoModel</value>
    public ContactInfoModel ContactInfo { get; set; }

    }
}