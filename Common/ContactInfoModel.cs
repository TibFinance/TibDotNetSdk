
using System;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the ContactInfoModel model.
    /// </summary>
    public class ContactInfoModel 
    {
        
    /// <summary>
    /// Specifies the email address associated with the merchant.
    /// </summary>
    /// <value>Represents the merchant's email address, which is used for communication and identification purposes within the TIB Finance API.</value>
    public string Email { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Phone { get; set; }

    /// <summary>
    /// Gets or sets the address associated with the entity.
    /// </summary>
    /// <value>The address represented by an AddressModel object.</value>
    public string Address { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string City { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? Province { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? Country { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ZipCode { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public int Language { get; set; }

    }
}