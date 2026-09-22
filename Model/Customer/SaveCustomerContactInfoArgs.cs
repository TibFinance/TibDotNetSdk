
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the SaveCustomerContactInfoArgs model.
    /// </summary>
    public class SaveCustomerContactInfoArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Unique identifier of the customer owning the recurring transfers
    /// </summary>
    /// <value>A non‑null GUID that matches an existing customer record; used to correlate transfers with the correct account</value>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Contact information of the customer to be created
    /// </summary>
    /// <value>Provides email, phone, and address; at least one contact method (email or phone) is required; fields must conform to standard format and length constraints defined in ContactInfoModel</value>
    public ContactInfoModel ContactInfo { get; set; }

    }
}