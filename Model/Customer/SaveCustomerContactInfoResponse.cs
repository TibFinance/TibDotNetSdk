
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
    /// The customer's contact information
    /// </summary>
    /// <value>A ContactInfoModel object containing phone numbers, email addresses, and mailing address. All fields are optional and may be null if not provided. Values follow standard E.164 format for phone numbers and RFC 5322 for email. Address fields are normalized per ISO 3166 country codes.</value>
    public ContactInfoModel ContactInfo { get; set; }

    }
}