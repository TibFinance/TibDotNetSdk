
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.TransferBatch
{
    /// <summary>
    /// Represents the TransferBatchCustomerModel model.
    /// </summary>
    public class TransferBatchCustomerModel 
    {
        
    /// <summary>
    /// Optional: the CustomerId a previous call returned for this CustomerExternalId. When sent, it must match the customer of that CustomerExternalId in the merchant's service.
    /// </summary>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// Required on every item: your identifier for the customer, unique across all the merchants of a service: the same identifier at two merchants of one service is one customer. 1 to 150 characters: letters, digits, '.', '_' and '-'. Case is ignored: "a" and "A" are one customer.
    /// </summary>
    public string CustomerExternalId { get; set; }

    /// <summary>
    /// Required on every item: the customer's name, up to 150 characters, none of them &lt; &gt; { } [ ] \ ` ~ ^ or a double quote. It cannot hold emoji, characters outside the Western European alphabets, or control characters such as a line break. A sent value replaces the stored one.
    /// </summary>
    public string CustomerName { get; set; }

    /// <summary>
    /// Required on every item: the customer's language: 1 or fr for French, 2 or en for English. A missing or invalid value refuses the item (2154). A sent value replaces the stored one.
    /// </summary>
    public LanguageEnum? Language { get; set; }

    /// <summary>
    /// Required on every item: the customer's contact details. Email and Phone are required: a missing or malformed value refuses the item (2152, 2153). Email must be ASCII with no space, and is stored in lower case. Phone accepts the common North American formats, such as 514-555-0100, (514) 555-0100 or +1 514 555 0100, and is stored as +1 and 10 digits; a trailing extension is dropped. The area code cannot start with 0 or 1. A sent value replaces the stored one. The address fields are optional: an empty one keeps the stored value, and a malformed one is not saved and the item gets a warning (2142). Address and City cannot hold emoji, characters outside the Western European alphabets, or control characters such as a line break: such a value counts as malformed. Province and Country are numeric ids: a text such as QC refuses the whole call. ContactInfo.Language is ignored, so leave it out and use Language: a text such as fr in ContactInfo.Language refuses the whole call.
    /// </summary>
    public ContactInfoModel ContactInfo { get; set; }

    }
}