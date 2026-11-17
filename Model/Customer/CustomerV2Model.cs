
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the CustomerV2Model model.
    /// </summary>
    public class CustomerV2Model 
    {
        
    /// <summary>
    /// Required: the customer's name, up to 150 characters, none of them &lt; &gt; { } [ ] \ ` ~ ^ or a double quote. It cannot hold emoji, characters outside the Western European alphabets, or control characters such as a line break.
    /// </summary>
    public string CustomerName { get; set; }

    /// <summary>
    /// Optional: your identifier for the customer. Use one identifier per customer across all the merchants of a service: a later CreateTransferBatch item with this identifier, from any merchant of the service, uses this customer. Up to 150 characters: unaccented letters, digits, '.', '_' and '-'. Case is ignored: "a" and "A" are one identifier. A repeated CustomerExternalId is allowed: the call still creates a new customer, and CreateTransferBatch keeps using the first one that CreateCustomerV2 or CreateTransferBatch created with this identifier (a customer made with CreateCustomer does not count). GetCustomersByExternalId returns both. When that first one was deleted before the call, and was not blocked, the new customer takes its place.
    /// </summary>
    public string CustomerExternalId { get; set; }

    /// <summary>
    /// Required: the customer's language: 1 or fr for French, 2 or en for English.
    /// </summary>
    public LanguageEnum? Language { get; set; }

    /// <summary>
    /// Optional: a note about the customer, up to 150 characters, none of them &lt; &gt; { } [ ] \ ` ~ ^ or a double quote. It cannot hold emoji, characters outside the Western European alphabets, or control characters such as a line break.
    /// </summary>
    public string CustomerDescription { get; set; }

    /// <summary>
    /// Required: the customer's contact details. Email and Phone are required: a missing or malformed value refuses the call (2003). Email must be ASCII with no space, up to 250 characters, and is stored in lower case. Phone accepts the common North American formats, such as 514-555-0100, (514) 555-0100 or +1 514 555 0100, and is stored as +1 and 10 digits; a trailing extension is dropped. The area code cannot start with 0 or 1. The address fields are optional: a value longer than its limit, an unknown Province or Country id, or a ZipCode that is not a Canadian or US postal code refuses the call (2003). Address and City cannot hold emoji, characters outside the Western European alphabets, or control characters such as a line break. Province and Country are numeric ids: a text such as QC refuses the call. Leave ContactInfo.Language out: it is not read, and a text such as fr in it refuses the call.
    /// </summary>
    public ContactInfoModel ContactInfo { get; set; }

    }
}